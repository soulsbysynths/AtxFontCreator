using AtxFontCreator;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AtxFontCreator
{
    public partial class AtxFontCreator : Form
    {
        public AtxFontCreator()
        {
            InitializeComponent();
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
            saveFileDialog1.FileName = AtxFontLibrary.CurrentFont.FontName;
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
            AtxFontLibrary.PopulateFontLibrary();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtxFontLibrary.AddNewFont();
        }

        private void LibraryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtxFontLibrary.Focus();
        }

        public AtxScreen AtxScreen
        {
            get
            {
                AtxScreen? atxScreen = null;
                foreach (Form f in this.MdiChildren)
                {
                    if (f is AtxScreen)
                    {
                        atxScreen = f as AtxScreen;
                        break;
                    }
                }

                if (atxScreen == null)
                {
                    atxScreen = new()
                    {
                        MdiParent = this
                    };
                    atxScreen.Show();
                }

                return atxScreen;
            }
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

                if (fontLibrary == null)
                {
                    fontLibrary = new()
                    {
                        MdiParent = this
                    };
                    fontLibrary.Show();
                }

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

                if (fontEditor == null)
                {
                    fontEditor = new()
                    {
                        MdiParent = this
                    };
                    fontEditor.Show();
                }

                return fontEditor;
            }
        }


        private void SystemFontEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontEditor.Focus();
        }

        private void CopyFromSystemFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontEditor.OutputSize != AtxFontLibrary.CurrentFont.PixelSize)
            {
                if (MessageBox.Show("ATX font and system font dimensions do not match. Set system font to ATX font dimensions?", "Copy System Font To ATX Font", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    FontEditor.OutputSize = AtxFontLibrary.CurrentFont.PixelSize;
                }
            }

            FontEditor.CopyToAtxFont(ref AtxFontLibrary.CurrentFont);
            AtxFontLibrary.Focus();
        }

        private void PreviewScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtxScreen.Focus();
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            AtxFontLibrary.Focus();
        }
    }
}
