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
        public List<AtxFont> Fonts { get; set; } = [];

        public AtxFontLibrary()
        {
            InitializeComponent();
            PopulateFontLibrary();
            if (Fonts.Count == 0)
            {
                AddNewFont();
            }
        }

        public void AddNewFont()
        {
            Fonts.Add(new AtxFont()
            {
                FontName = "newAtxFont",
                PixelSize = new Size(8, 16),
                StartCharacter = 33,
                CharacterCount = 95,
            });

            lstAtxFontLibrary.DataSource = Fonts;
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
                Fonts.Add(newFont);
                lstAtxFontLibrary.DataSource = Fonts;
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
                Span<AtxFont> span = CollectionsMarshal.AsSpan(Fonts);
                return ref span[lstAtxFontLibrary.SelectedIndex];
            }
        }

        private void LstAtxFontLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAtxFontLibrary.SelectedIndex < 0 || lstAtxFontLibrary.SelectedIndex >= Fonts.Count)
            {
                return;
            }

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(Fonts[lstAtxFontLibrary.SelectedIndex]);
        }

        public void PopulateFontLibrary()
        {
            if (!Directory.Exists(Properties.Settings.Default.LibraryPath))
            {
                return;
            }

            Fonts.Clear();
            string[] filePaths = Directory.GetFiles(Properties.Settings.Default.LibraryPath, "*.h");
            foreach (string filePath in filePaths)
            {
                FileStream file = File.Open(filePath, FileMode.Open);
                StreamReader reader = new(file);
                AtxFont newFont = new();
                if (AtxFontHeaderParser.ImportHeader(reader, ref newFont))
                {
                    Fonts.Add(newFont);
                }

                reader.Close();
                file.Close();
            }

            lstAtxFontLibrary.DataSource = Fonts;
            lstAtxFontLibrary.DisplayMember = "FontName";
        }
    }
}
