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
            LockWidth();
            cboColour.SelectedIndex = 0;
            cboDrawMode.SelectedIndex = 0;
        }

        private char[,] characters = new char[0, 0];

        private AtxFont atxFont = new();

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
                colour = value;
                Invalidate();
            }
        }

        public LayerDrawMode DrawMode { get; set; }

        public Size Dimensions
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
            if (location.X >= Dimensions.Width || location.Y >= Dimensions.Height)
            {
                return;
            }

            if (characters[location.X, location.Y] == value)
            {
                return;
            }

            characters[location.X, location.Y] = value;

            picLayer.Invalidate();
        }

        public void SetString(Point location, string value)
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

            while (p.X < Dimensions.Width)
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
            return atxFont.Dimensions.Height == 0 ?
                0 : GetCharacterHeight() == 0 ?
                0 : (GetCharacterHeight() / atxFont.Dimensions.Height) * atxFont.Dimensions.Width;
        }

        private float GetCharacterHeight()
        {
            return Dimensions.Height == 0 ? 0 : (float)picLayer.Height / Dimensions.Height;
        }

        private void AtxLayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicLayer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            for (int y = 0; y < Dimensions.Height; y++)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    e.Graphics.DrawImage(atxFont.GetCharacter(characters[x, y]).GetBitmap(), GetCharacterRectF(new Point(x, y)));
                }
            }
        }

        private void LockWidth()
        {
            int w = (int)(GetCharacterWidth() * Dimensions.Width);
            if (picLayer.Width != w)
            {
                picLayer.Width = w;
                Width = picLayer.Left + w + picLayer.Margin.Right;
                picLayer.Invalidate();
            }
        }

        private void AtxLayer_Resize(object sender, EventArgs e)
        {
            picLayer.Height = this.Height - picLayer.Top - picLayer.Margin.Bottom;
            LockWidth();
        }

        private void TxtCharacters_TextChanged(object sender, EventArgs e)
        {
            string[] lines = txtCharacters.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                SetString(new Point(0, i), lines[i]);
            }
        }
    }
}
