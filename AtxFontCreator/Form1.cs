using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Security.Cryptography;

namespace AtxFontCreator
{
    public partial class Form1 : Form
    {
        [Flags]
        private enum IncludeCharacters
        {
            None = 0,
            Numbers = 1,
            Characters = 2,
            Punctuation = 4,
            Misc = 8
        }

        private void SetIncludeCharacters(IncludeCharacters include)
        {
            chkIncludeNumbers.Checked = include.HasFlag(IncludeCharacters.Numbers);
            chkIncludeCharacters.Checked = include.HasFlag(IncludeCharacters.Characters);
            chkIncludePunctuation.Checked = include.HasFlag(IncludeCharacters.Punctuation);
            chkIncludeMisc.Checked = include.HasFlag(IncludeCharacters.Misc);
            foreach (Control c in flpFontConverter.Controls)
            {
                if (c is not FontCharacter)
                {
                    continue;
                }

                FontCharacter character = (FontCharacter)c;
                char ch = character.Character;
                if (ch >= 127)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Misc);
                }
                else if (ch >= 123)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Punctuation);
                }
                else if (ch >= 97)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Characters);
                }
                else if (ch >= 91)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Punctuation);
                }
                else if (ch >= 65)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Characters);
                }
                else if (ch >= 58)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Punctuation);
                }
                else if (ch >= 48)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Numbers);
                }
                else if (ch >= 33)
                {
                    character.Include = include.HasFlag(IncludeCharacters.Punctuation);
                }
                else
                {
                    character.Include = include.HasFlag(IncludeCharacters.Misc);
                }
            }

            BuildFont();
        }

        public Form1()
        {
            InitializeComponent();
            fontDialog1.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            for (int i = 0; i < 256; i++)
            {
                FontCharacter character = new();
                if (i < 33 || i > 126)
                {
                    character.Include = false;
                }
                character.IncludeClicked += FontCharacter_IncludeClicked;
                character.CharacterFont = fontDialog1.Font;
                character.Character = (char)i;

                flpFontConverter.Controls.Add(character);
            }

            SetIncludeCharacters(IncludeCharacters.Characters | IncludeCharacters.Numbers);
            BuildFont();
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            BuildFont();
        }

        private void BuildFont()
        {
            // Build font
            flpFontConverter.SuspendLayout();
            RectangleF sourceRect = new();
            bool rectInitialised = false;
            foreach (Control c in flpFontConverter.Controls)
            {
                if (c is not FontCharacter)
                {
                    continue;
                }

                FontCharacter character = (FontCharacter)c;
                character.CharacterFont = fontDialog1.Font;
                if (character.Include)
                {
                    if (!rectInitialised)
                    {
                        sourceRect = character.SourceBoundingBox;
                        rectInitialised = true;
                    }
                    else
                    {
                        sourceRect = RectangleF.Union(sourceRect, character.SourceBoundingBox);
                    }
                }
            }

            foreach (Control c in flpFontConverter.Controls)
            {
                if (c is not FontCharacter)
                {
                    continue;
                }

                FontCharacter character = (FontCharacter)c;
                character.SourceRect = sourceRect;
                character.DestinationBitmap = new Bitmap(atxFont1.Dimensions.Width, atxFont1.Dimensions.Height);
            }

            lblFont.Text = fontDialog1.Font.Name + ", " + fontDialog1.Font.Style + ", " + fontDialog1.Font.Size + "pt";
            if (fontDialog1.Font.Strikeout)
            {
                lblFont.Text += ", Strikeout";
            }

            if (fontDialog1.Font.Underline)
            {
                lblFont.Text += ", Underline";
            }

            String format = "0";
            lblFont.Text += ", rect = " + sourceRect.Width.ToString(format) + "x" + sourceRect.Height.ToString(format) + " at (" + sourceRect.Location.X.ToString(format) + "," + sourceRect.Location.Y.ToString(format) + ")";
            flpFontConverter.ResumeLayout();
            foreach (Control c in flpFontConverter.Controls)
            {
                if (c is not FontCharacter)
                {
                    continue;
                }

                FontCharacter character = (FontCharacter)c;
                character.Refresh();
            }

            if (!chkCopyToAtxFont.Checked)
            {
                return;
            }

            // Copy to ATX font
            for (int i = 0; i < atxFont1.CharacterCount; i++)
            {
                if (atxFont1.Characters[i].Mode != AtxCharacter.CharacterMode.Select)
                {
                    continue;
                }

                foreach (Control c in flpFontConverter.Controls)
                {
                    if (c is not FontCharacter)
                    {
                        continue;
                    }

                    FontCharacter fontCharacter = (FontCharacter)c;
                    if (fontCharacter.Character != atxFont1.Characters[i].Character)
                    {
                        continue;
                    }

                    for (int y = 0; y < atxFont1.Dimensions.Height; y++)
                    {
                        for (int x = 0; x < atxFont1.Dimensions.Width; x++)
                        {
                            Color col = fontCharacter.DestinationBitmap.GetPixel(x, y);
                            int greyscale = (col.R + col.G + col.B) / 3;
                            atxFont1.Characters[i].SetPixel(x, y, greyscale >= 128);
                        }
                    }
                    break;
                }
            }
        }

        private void FontCharacter_IncludeClicked(object? sender, EventArgs e)
        {
            BuildFont();
        }

        private void AtxFont1_DimensionsChanged(object sender, EventArgs e)
        {
            BuildFont();
        }

        private void ChkInclude_CheckedChanged(object sender, EventArgs e)
        {
            IncludeCharacters newInclude = IncludeCharacters.None;
            if (chkIncludeNumbers.Checked)
            {
                newInclude |= IncludeCharacters.Numbers;
            }

            if (chkIncludeCharacters.Checked)
            {
                newInclude |= IncludeCharacters.Characters;
            }

            if (chkIncludePunctuation.Checked)
            {
                newInclude |= IncludeCharacters.Punctuation;
            }

            if (chkIncludeMisc.Checked)
            {
                newInclude |= IncludeCharacters.Misc;
            }

            SetIncludeCharacters(newInclude);
        }

        private void AtxFont1_CharacterCountChanged(object sender, EventArgs e)
        {
            BuildFont();
        }

        private void AtxFont1_StartCharacterChanged(object sender, EventArgs e)
        {
            BuildFont();
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Header files|*.h";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using StreamReader reader = File.OpenText(openFileDialog1.FileName);
            AtxFontHeaderParser.ImportHeader(reader, ref atxFont1);
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
