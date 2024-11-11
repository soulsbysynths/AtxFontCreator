using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AtxFontCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtxFontLibrary.Focus();
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Header files|*.h";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            AtxFontLibrary.ImportFont(openFileDialog1.FileName);
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Header files|*.h";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

           AtxFontLibrary.ExportFont(saveFileDialog1.FileName);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void LibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Properties.Settings.Default.LibraryPath = folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.Save();
            //PopulateFontLibrary();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtxFontLibrary.AddNewFont();
        }

        private void LibraryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtxFontLibrary.Focus();
        }

        public AtxFontLibrary AtxFontLibrary
        {
            get 
            {
                AtxFontLibrary? fontLibrary = null;
                foreach (Form f in this.MdiChildren)
                {
                    if (f is AtxFontLibrary)
                    {
                        fontLibrary = f as AtxFontLibrary;
                        break;
                    }
                }

                fontLibrary ??= new AtxFontLibrary();
                fontLibrary.MdiParent = this;
                return fontLibrary;
            }
        }

        public FontEditor FontEditor
        {
            get
            {
                FontEditor? fontEditor = null;
                foreach (Form f in this.MdiChildren)
                {
                    if (f is FontEditor)
                    {
                        fontEditor = f as FontEditor;
                        break;
                    }
                }

                fontEditor ??= new FontEditor();
                fontEditor.MdiParent = this;
                return fontEditor;
            }
        }


        private void SystemFontEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontEditor.Focus();
        }

        private void CopyFromSystemFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontEditor.Dimensions != AtxFontLibrary.CurrentFont.Dimensions)
            {
                if (MessageBox.Show("ATX font and system font dimensions do not match. Set system font to ATX font dimensions?", "Copy System Font To ATX Font", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    FontEditor.Dimensions = AtxFontLibrary.CurrentFont.Dimensions;
                }
            }

            FontEditor.CopyToAtxFont(ref AtxFontLibrary.CurrentFont);
            AtxFontLibrary.Focus();
        }
    }
}
