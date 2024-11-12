using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtxFontCreator
{
    public partial class AtxFontLibrary : Form
    {
        private readonly List<AtxFont> fonts = [];

        public AtxFontLibrary()
        {
            InitializeComponent();
            PopulateFontLibrary();
            if (fonts.Count == 0)
            {
                AddNewFont();
            }
        }

        public void AddNewFont()
        {
            fonts.Add(new AtxFont()
            {
                FontName = "newAtxFont",
                PixelSize = new Size(8, 16),
                StartCharacter = 33,
                CharacterCount = 95,
            });

            lstAtxFontLibrary.DataSource = fonts;
            lstAtxFontLibrary.DisplayMember = "FontName";
        }

        public void ImportFont(string filePath)
        {
            using StreamReader reader = File.OpenText(filePath);
            AtxFont newFont = new();
            if (!AtxFontHeaderParser.ImportHeader(reader, ref newFont))
            {
                MessageBox.Show("Could not import header file.", "Import Header File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fonts.Add(newFont);
                lstAtxFontLibrary.DataSource = fonts;
                lstAtxFontLibrary.DisplayMember = "FontName";
            }
            reader.Close();
        }

        public void ExportFont(string filePath)
        {
            using StreamWriter writer = File.CreateText(filePath);

            AtxFontHeaderParser.ExportHeader(writer, lstAtxFontLibrary.SelectedItem as AtxFont ?? new AtxFont());
            writer.Close();
        }

        public ref AtxFont CurrentFont
        {
            get 
            {
                Span<AtxFont> span = CollectionsMarshal.AsSpan(fonts);
                return ref span[lstAtxFontLibrary.SelectedIndex]; 
            }
        }

        private void LstAtxFontLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAtxFontLibrary.SelectedIndex < 0 || lstAtxFontLibrary.SelectedIndex >= fonts.Count)
            {
                return;
            }

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(fonts[lstAtxFontLibrary.SelectedIndex]);
        }

        public void PopulateFontLibrary()
        {
            fonts.Clear();
            string[] filePaths = Directory.GetFiles(Properties.Settings.Default.LibraryPath, "*.h");
            foreach (string filePath in filePaths)
            {
                FileStream file = File.Open(filePath, FileMode.Open);
                StreamReader reader = new(file);
                AtxFont newFont = new();
                if (AtxFontHeaderParser.ImportHeader(reader, ref newFont))
                {
                    fonts.Add(newFont);
                }

                reader.Close();
                file.Close();
            }

            lstAtxFontLibrary.DataSource = fonts;
            lstAtxFontLibrary.DisplayMember = "FontName";
        }
    }
}
