using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AtxFontCreator.AtxCharacter;

namespace AtxFontCreator
{
    public partial class AtxLayer : UserControl
    {
        public event EventHandler? DrawModeChanged;
        public enum LayerColour
        {
            CO_WHITE = 0,
            CO_LIGHTGREY,
            CO_GREY,
            CO_DARKGREY,
            CO_BLACK
        };

        public enum LayerDrawMode
        {
            DM_MASK = 0,
            DM_NOT_MASK,
            DM_AND_MASK,
            DM_AND_NOT_MASK,
            DM_OR_MASK,
            DM_OR_NOT_MASK,
            DM_XOR_MASK,
            DM_XOR_NOT_MASK
        };

        public AtxLayer()
        {
            InitializeComponent();
            cboColour.SelectedIndex = 0;
            cboDrawMode.SelectedIndex = 0;
            LockWidth();
        }

        private char[,] characters = new char[0, 0];

        private AtxFont atxFont = new()
        {
            FontName = "newAtxFont",
            PixelSize = new Size(8, 16),
            StartCharacter = 33,
            CharacterCount = 95,
        };

        public AtxFont AtxFont
        {
            get { return atxFont; }
            set
            {
                atxFont = value;
                Invalidate();
            }
        }

        private LayerColour colour;

        public LayerColour Colour
        {
            get { return colour; }
            set
            {
                if (colour == value)
                {
                    return;
                }

                colour = value;
                cboColour.SelectedIndex = (int)colour;
                Invalidate();
            }
        }

        public int Id { get; set; }

        public string IdName
        {
            get { return "Layer" + Id.ToString(); }
        }


        private LayerDrawMode drawMode;

        public LayerDrawMode DrawMode
        {
            get { return drawMode; }
            set
            {
                if (value == drawMode)
                {
                    return;
                }

                drawMode = value;
                cboDrawMode.SelectedIndex = (int)drawMode;
                DrawModeChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        public Size CharacterSize
        {
            get
            {
                return new Size(characters.GetLength(0), characters.GetLength(1));
            }
            set
            {
                if (value.Width == characters.GetLength(0) && value.Height == characters.GetLength(1))
                {
                    return;
                }

                char[,] newCharacters = new char[value.Width, value.Height];
                for (int x = 0; x < Math.Min(characters.GetLength(0), newCharacters.GetLength(0)); x++)
                {
                    Array.Copy(characters, x * characters.GetLength(1), newCharacters, x * newCharacters.GetLength(1), Math.Min(characters.GetLength(1), newCharacters.GetLength(1)));
                }

                characters = newCharacters;
                numWidth.Value = characters.GetLength(0);
                numHeight.Value = characters.GetLength(1);
                LockWidth();
                Invalidate();
            }
        }

        public void Clear()
        {
            Array.Clear(characters);
            Invalidate();
        }

        public void SetCharacter(Point location, char value)
        {
            if (location.X >= CharacterSize.Width || location.Y >= CharacterSize.Height)
            {
                return;
            }

            if (characters[location.X, location.Y] == value)
            {
                return;
            }

            characters[location.X, location.Y] = value;
            string s = String.Empty;
            string h = String.Empty;
            for (int y = 0; y < CharacterSize.Height; y++)
            {
                for (int x = 0; x < CharacterSize.Width; x++)
                {
                    s += characters[x, y];
                    h += ((int)characters[x, y]).ToString("X2");
                    h += " ";

                }

                s += Environment.NewLine;
                h += Environment.NewLine;
            }

            lblCharacters.Text = h + s;
            picLayer.Invalidate();
        }

        public void PrintString(Point location, string value)
        {
            Point p = new()
            {
                Y = location.Y
            };

            while (p.X < location.X)
            {
                SetCharacter(p, ' ');
                p.X++;
            }

            while (p.X < (location.X + value.Length))
            {
                SetCharacter(p, value[p.X - location.X]);
                p.X++;
            }

            while (p.X < CharacterSize.Width)
            {
                SetCharacter(p, ' ');
                p.X++;
            }
        }

        private RectangleF GetCharacterRectF(Point location)
        {
            return new RectangleF(location.X * GetCharacterWidth(), location.Y * GetCharacterHeight(), GetCharacterWidth(), GetCharacterHeight());
        }

        private float GetCharacterWidth()
        {
            return atxFont.PixelSize.Height == 0 ?
                0 : GetCharacterHeight() == 0 ?
                0 : (GetCharacterHeight() / atxFont.PixelSize.Height) * atxFont.PixelSize.Width;
        }

        private float GetCharacterHeight()
        {
            return CharacterSize.Height == 0 ? 0 : (float)picLayer.Height / CharacterSize.Height;
        }

        private void PicLayer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            for (int y = 0; y < CharacterSize.Height; y++)
            {
                for (int x = 0; x < CharacterSize.Width; x++)
                {
                    e.Graphics.DrawImage(atxFont.GetCharacter(characters[x, y]).GetBitmap(), GetCharacterRectF(new Point(x, y)));
                }
            }
        }

        private void LockWidth()
        {
            int w = (int)(GetCharacterWidth() * CharacterSize.Width);
            if (picLayer.Width != w)
            {
                picLayer.Width = w;
                picLayer.Invalidate();
            }
        }

        private void CboDrawMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            DrawMode = (LayerDrawMode)combo.SelectedIndex;
        }

        private void CboColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            Colour = (LayerColour)combo.SelectedIndex;
        }

        private void NumWidth_ValueChanged(object sender, EventArgs e)
        {
            CharacterSize = new Size((int)numWidth.Value, CharacterSize.Height);
            numColumn.Maximum = numWidth.Value;
        }

        private void NumHeight_ValueChanged(object sender, EventArgs e)
        {
            CharacterSize = new Size(CharacterSize.Width, (int)numHeight.Value);
            numRow.Maximum = numHeight.Value;
        }

        private void PicLayer_Resize(object sender, EventArgs e)
        {
            LockWidth();
        }

        private void BtnPrintString_Click(object sender, EventArgs e)
        {
            PrintString(new Point((int)numColumn.Value, (int)numRow.Value), txtPrintString.Text);
        }
    }
}
