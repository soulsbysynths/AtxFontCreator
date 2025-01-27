using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace AtxFontCreator
{
    public partial class FontEditor : Form
    {
        [Flags]
        private enum IncludeCharactersTypes
        {
            None = 0,
            Numbers = 1,
            Characters = 2,
            Punctuation = 4,
            Misc = 8
        }

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
                character.SourceRectChanged += FontCharacter_SourceRectChanged;
                character.CharacterFont = fontDialog1.Font;
                character.Character = (char)i;

                flpFontConverter.Controls.Add(character);
            }

            IncludeCharacters = (IncludeCharactersTypes.Characters | IncludeCharactersTypes.Numbers);
            SetAllSourceRects();
            RefreshAllCharacters();
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
                RefreshSelectedCharacter();
            }
        }

        private IncludeCharactersTypes includeCharacters = IncludeCharactersTypes.None;
        private IncludeCharactersTypes IncludeCharacters
        {
            set
            {
                if (includeCharacters == value)
                {
                    return;
                }

                includeCharacters = value;
                chkIncludeNumbers.Checked = includeCharacters.HasFlag(IncludeCharactersTypes.Numbers);
                chkIncludeCharacters.Checked = includeCharacters.HasFlag(IncludeCharactersTypes.Characters);
                chkIncludePunctuation.Checked = includeCharacters.HasFlag(IncludeCharactersTypes.Punctuation);
                chkIncludeMisc.Checked = includeCharacters.HasFlag(IncludeCharactersTypes.Misc);
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
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Misc);
                    }
                    else if (ch >= 123)
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Punctuation);
                    }
                    else if (ch >= 97)
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Characters);
                    }
                    else if (ch >= 91)
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Punctuation);
                    }
                    else if (ch >= 65)
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Characters);
                    }
                    else if (ch >= 58)
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Punctuation);
                    }
                    else if (ch >= 48)
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Numbers);
                    }
                    else if (ch >= 33)
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Punctuation);
                    }
                    else
                    {
                        character.Include = includeCharacters.HasFlag(IncludeCharactersTypes.Misc);
                    }
                }

                RefreshAllCharacters();
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            SetAllSourceRects();
            RefreshAllCharacters();
        }

        private void FontCharacter_SourceRectChanged(object? sender, EventArgs e)
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

            RefreshSelectedCharacter();
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

            RefreshSelectedCharacter();
        }

        private void RefreshSelectedCharacter()
        {
            CopyToAtxCharacter(ref SelectedCharacter, ref atxCharacter1);
            numBBWidth.Value = (decimal)SelectedCharacter.SourceRect.Width;
            numBBHeight.Value = (decimal)SelectedCharacter.SourceRect.Height;
            numBBX.Value = (decimal)SelectedCharacter.SourceRect.X;
            numBBY.Value = (decimal)SelectedCharacter.SourceRect.Y;
            lblFont.Text = SelectedCharacter.CharacterFont.Name + ", " + SelectedCharacter.CharacterFont.Style + ", " + SelectedCharacter.CharacterFont.Size + "pt";
            if (SelectedCharacter.CharacterFont.Strikeout)
            {
                lblFont.Text += ", Strikeout";
            }

            if (SelectedCharacter.CharacterFont.Underline)
            {
                lblFont.Text += ", Underline";
            }

            String format = "0";
            RectangleF rect = SelectedCharacter.SourceRect;
            lblFont.Text += ", rect = " +
                rect.Width.ToString(format) +
                "x" +
                rect.Height.ToString(format) +
                " at (" +
                rect.Location.X.ToString(format) +
                "," +
                rect.Location.Y.ToString(format) +
                ")";
        }

        private void WriteIncludeFlag(IncludeCharactersTypes flag, bool way)
        {
            IncludeCharactersTypes newInclude = includeCharacters;
            if (way)
            {
                newInclude |= flag;
            }
            else
            {
                newInclude &= ~flag;
            }
            IncludeCharacters = newInclude;
        }

        private void NumWidth_ValueChanged(object sender, EventArgs e)
        {
            OutputSize = new Size((int)numWidth.Value, outputSize.Height);
        }

        private void NumHeight_ValueChanged(object sender, EventArgs e)
        {
            OutputSize = new Size(outputSize.Width, (int)numHeight.Value);
        }

        public void SetAllSourceRects()
        {
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
            }

            flpFontConverter.ResumeLayout();
        }

        private void RefreshAllCharacters()
        {
            foreach (Control c in flpFontConverter.Controls)
            {
                if (c is not FontCharacter)
                {
                    continue;
                }

                FontCharacter character = (FontCharacter)c;
                character.Refresh();
            }

            RefreshSelectedCharacter();
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
            Bitmap destinationBitmap = new(destination.PixelSize.Width, destination.PixelSize.Height);
            Graphics g = Graphics.FromImage(destinationBitmap);
            SolidBrush solidBrush = new(Color.White);
            GraphicsPath path = new();
            path.AddString(source.Character.ToString(), source.CharacterFont.FontFamily, (int)source.CharacterFont.Style, source.CharacterFont.Size, new PointF(-source.SourceRect.X, -source.SourceRect.Y), FontCharacter.CentreFormat());
            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
            if (source.SourceRect.Height > 0)
            {
                g.ScaleTransform((float)destinationBitmap.Width / (float)source.SourceRect.Width, (float)destinationBitmap.Height / (float)source.SourceRect.Height);
            }

            g.FillPath(solidBrush, path);

            for (int y = 0; y < destination.PixelSize.Height; y++)
            {
                for (int x = 0; x < destination.PixelSize.Width; x++)
                {
                    Color col = destinationBitmap.GetPixel(x, y);
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

        private void NumBBWidth_ValueChanged(object sender, EventArgs e)
        {
            SelectedCharacter.SourceRect = new RectangleF(SelectedCharacter.SourceRect.X, SelectedCharacter.SourceRect.Y, (float)numBBWidth.Value, SelectedCharacter.SourceRect.Height);
        }

        private void NumBBHeight_ValueChanged(object sender, EventArgs e)
        {
            SelectedCharacter.SourceRect = new RectangleF(SelectedCharacter.SourceRect.X, SelectedCharacter.SourceRect.Y, SelectedCharacter.SourceRect.Width, (float)numBBHeight.Value);
        }

        private void NumBBX_ValueChanged(object sender, EventArgs e)
        {
            SelectedCharacter.SourceRect = new RectangleF((float)numBBX.Value, SelectedCharacter.SourceRect.Y, SelectedCharacter.SourceRect.Width, SelectedCharacter.SourceRect.Height);
        }

        private void NumBBY_ValueChanged(object sender, EventArgs e)
        {
            SelectedCharacter.SourceRect = new RectangleF(SelectedCharacter.SourceRect.X, (float)numBBY.Value, SelectedCharacter.SourceRect.Width, SelectedCharacter.SourceRect.Height);
        }

        private void BtnSelectedFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            SelectedCharacter.CharacterFont = fontDialog1.Font;
            RefreshSelectedCharacter();
        }

        private void BtnSetBoundingBoxes_Click(object sender, EventArgs e)
        {
            SetAllSourceRects();
            RefreshAllCharacters();
        }

        private void ChkIncludeCharacters_CheckedChanged(object sender, EventArgs e)
        {
            WriteIncludeFlag(IncludeCharactersTypes.Characters, chkIncludeCharacters.Checked);
        }

        private void ChkIncludePunctuation_CheckedChanged(object sender, EventArgs e)
        {
            WriteIncludeFlag(IncludeCharactersTypes.Punctuation, chkIncludePunctuation.Checked);
        }

        private void ChkIncludeMisc_CheckedChanged(object sender, EventArgs e)
        {
            WriteIncludeFlag(IncludeCharactersTypes.Misc, chkIncludeMisc.Checked);
        }

        private void ChkIncludeNumbers_CheckedChanged(object sender, EventArgs e)
        {
            WriteIncludeFlag(IncludeCharactersTypes.Numbers, chkIncludeNumbers.Checked);
        }
    }
}
