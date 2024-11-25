using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtxFontCreator
{
    public partial class FontEditor : Form
    {
        private int selectedCharacterIndex = 0;
        public FontEditor()
        {
            InitializeComponent();
            fontDialog1.Font = new Font(FontFamily.GenericSansSerif, 40, FontStyle.Bold);
            for (int i = 0; i < 256; i++)
            {
                FontCharacter character = new();
                if (i < 33 || i > 126)
                {
                    character.Include = false;
                }
                character.SelectedChanged += FontCharacter_SelectChanged;
                character.CharacterFont = fontDialog1.Font;
                character.Character = (char)i;

                flpFontConverter.Controls.Add(character);
            }

            SetIncludeCharacters(IncludeCharacters.Characters | IncludeCharacters.Numbers);
        }

        public Span<FontCharacter> FontsSpan
        {
            get
            {
                return CollectionsMarshal.AsSpan(flpFontConverter.Controls.OfType<FontCharacter>().ToList());
            }
        }

        public ref FontCharacter SelectedCharacter
        {
            get
            {
                return ref FontsSpan[selectedCharacterIndex];
            }
        }

        private Size outputSize = new(8, 16);

        public Size OutputSize
        {
            get { return outputSize; }
            set
            {
                if (outputSize == value)
                {
                    return;
                }

                outputSize = value;
                numWidth.Value = outputSize.Width;
                numHeight.Value = outputSize.Height;
                atxCharacter1.PixelSize = outputSize;
                BuildFont();
            }
        }


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

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            BuildFont();
        }

        private void FontCharacter_SelectChanged(object? sender, EventArgs e)
        {
            if (sender is null)
            {
                return;
            }

            FontCharacter selectedCharacter = (FontCharacter)sender;
            if (selectedCharacter.Selected == false)
            {
                return;
            }

            CopyToAtxCharacter(ref selectedCharacter, ref atxCharacter1);

            for (int i = 0; i < FontsSpan.Length; i++)
            { 
                if (FontsSpan[i] != selectedCharacter)
                {
                    FontsSpan[i].Selected = false;
                }
                else
                {
                    selectedCharacterIndex = i;
                }
            }
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

        private void NumWidth_ValueChanged(object sender, EventArgs e)
        {
            OutputSize = new Size((int)numWidth.Value, outputSize.Height);
        }

        private void NumHeight_ValueChanged(object sender, EventArgs e)
        {
            OutputSize = new Size(outputSize.Width, (int)numHeight.Value);
        }

        public void BuildFont()
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
                character.DestinationBitmap = new Bitmap(outputSize.Width, outputSize.Height);
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
        }

        public void CopyToAtxFont(ref AtxFont destinationFont)
        {
            // Copy to ATX font
            for (int i = 0; i < destinationFont.CharacterCount; i++)
            {
                AtxCharacter atxCharacter = destinationFont.GetCharacter(i);
                if (!atxCharacter.Selected)
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
                    if (fontCharacter.Character != atxCharacter.Character)
                    {
                        continue;
                    }

                    CopyToAtxCharacter(ref fontCharacter, ref atxCharacter);
                    break;
                }
            }
        }

        private static void CopyToAtxCharacter(ref FontCharacter source, ref AtxCharacter destination)
        {
            for (int y = 0; y < destination.PixelSize.Height; y++)
            {
                for (int x = 0; x < destination.PixelSize.Width; x++)
                {
                    Color col = source.DestinationBitmap.GetPixel(x, y);
                    int greyscale = (col.R + col.G + col.B) / 3;
                    destination.SetPixel(new Point(x, y), greyscale >= 128);
                }
            }
        }

        private void ChkShowLabels_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            foreach (Control c in flpFontConverter.Controls)
            {
                if (c is not FontCharacter)
                {
                    continue;
                }

                FontCharacter character = (FontCharacter)c;
                character.LabelVisible = checkBox.Checked;
            }
        }
    }
}
