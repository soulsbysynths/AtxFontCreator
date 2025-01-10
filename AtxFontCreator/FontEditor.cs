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

            SetIncludeCharacters(IncludeCharacters.Characters | IncludeCharacters.Numbers);
            SetAllSourceRects();
            RefreshFontCharacters();
            RefreshFontInfo();
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
                flpFontConverter.SuspendLayout();
                foreach (Control c in flpFontConverter.Controls)
                {
                    if (c is not FontCharacter)
                    {
                        continue;
                    }

                    FontCharacter character = (FontCharacter)c;
                }
                flpFontConverter.ResumeLayout();
                RefreshSelectedCharacter();
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

            RefreshFontCharacters();
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            RefreshFontCharacters();
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

        public void SetAllSourceRects()
        {
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
        }

        private void RefreshFontCharacters()
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
        }

        private void RefreshFontInfo()
        {
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

        private void NumBB_ValueChanged(object sender, EventArgs e)
        {
            RectangleF newRect = new ((float)numBBX.Value, (float)numBBY.Value, (float)numBBWidth.Value, (float)numBBHeight.Value);
            //SelectedCharacter.SourceRect = newRect;
        }
    }
}
