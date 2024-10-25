using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtxFontCreator
{
    public partial class AtxCharacter : UserControl
    {
        private bool[,] pixels = new bool[0, 0];
        private bool MouseMoveWay = false;

        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        public AtxCharacter()
        {
            InitializeComponent();
        }

        public enum CharacterMode
        {
            Select,
            Lock,
            Edit
        }

        public char Character { get; set; }

        private CharacterMode mode;

        public CharacterMode Mode
        {
            get { return mode; }
            set
            {
                mode = value;
                Invalidate();
            }
        }


        public Size Dimensions
        {
            get
            {
                return new Size(pixels.GetLength(0), pixels.GetLength(1));
            }
            set
            {
                if (value.Width == pixels.GetLength(0) && value.Height == pixels.GetLength(1))
                {
                    return;
                }

                bool[,] newPixels = new bool[value.Width, value.Height];
                for (int x = 0; x < Math.Min(pixels.GetLength(0), newPixels.GetLength(0)); x++)
                {
                    Array.Copy(pixels, x * pixels.GetLength(1), newPixels, x * newPixels.GetLength(1), Math.Min(pixels.GetLength(1), newPixels.GetLength(1)));
                }

                pixels = newPixels;
                Invalidate();
            }
        }

        public void SetPixel(int x, int y, bool value)
        {
            if (Mode == CharacterMode.Lock)
            {
                return;
            }

            if (x < 0 || y < 0 || x >= Dimensions.Width || y >= Dimensions.Height)
            {
                return;
            }

            if (pixels[x, y] == value)
            {
                return;
            }

            pixels[x, y] = value;
            Invalidate();
        }

        public void Clear()
        {
            Array.Clear(pixels);
            Invalidate();
        }

        public void MovePixels(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    {
                        for (int y = 0; y < Dimensions.Height; y++)
                        {
                            for (int x = 0; x < (Dimensions.Width - 1); x++)
                            {
                                pixels[x, y] = pixels[x + 1, y];
                            }

                            pixels[Dimensions.Width - 1, y] = false;
                        }
                    }
                    break;
                case Direction.Right:
                    {
                        for (int y = 0; y < Dimensions.Height; y++)
                        {
                            for (int x = (Dimensions.Width - 1); x > 0; x--)
                            {
                                pixels[x, y] = pixels[x - 1, y];
                            }

                            pixels[0, y] = false;
                        }
                    }
                    break;
                case Direction.Up:
                    {
                        for (int x = 0; x < Dimensions.Width; x++)
                        {
                            for (int y = 0; y < (Dimensions.Height - 1); y++)
                            {
                                pixels[x, y] = pixels[x, y + 1];
                            }

                            pixels[x, Dimensions.Height - 1] = false;
                        }
                    }
                    break;
                case Direction.Down:
                    {
                        for (int x = 0; x < Dimensions.Width; x++)
                        {
                            for (int y = (Dimensions.Height - 1); y > 0; y--)
                            {
                                pixels[x, y] = pixels[x, y - 1];
                            }

                            pixels[x, 0] = false;
                        }
                    }
                    break;
            }

            Invalidate();
        }

        private void AtxCharacter_Paint(object sender, PaintEventArgs e)
        {
            int w = (int)(GetPixelHeight() * Dimensions.Width);
            if (Width != w)
            {
                Width = w;
            }

            for (int y = 0; y < Dimensions.Height; y++)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    e.Graphics.FillRectangle(pixels[x, y] ? Brushes.Ivory : Brushes.DimGray, GetPixelRectF(x, y));
                    e.Graphics.DrawRectangle(Pens.Gray, GetPixelRectF(x, y));
                }
            }

            Pen pen = Mode switch
            {
                CharacterMode.Lock => Pens.Red,
                CharacterMode.Select => Pens.Yellow,
                CharacterMode.Edit => Pens.Blue,
                _ => Pens.Black
            };

            e.Graphics.DrawRectangle(pen, 0, 0, Width - Pens.Black.Width, Height - Pens.Black.Width);
        }

        private void AtxCharacter_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Button != MouseButtons.Left || Mode == CharacterMode.Lock)
                {
                    return;
                }

                for (int y = 0; y < Dimensions.Height; y++)
                {
                    for (int x = 0; x < Dimensions.Width; x++)
                    {
                        if (GetPixelRectF(x, y).Contains(e.Location))
                        {
                            pixels[x, y] = !pixels[x, y];
                            MouseMoveWay = pixels[x, y];
                            Invalidate();
                            return;
                        }
                    }
                }
            }
            else
            {
                if (Mode == CharacterMode.Edit)
                {
                    Mode = CharacterMode.Select;
                }
                else
                {
                    Mode = (CharacterMode)((int)Mode + 1);
                }
            }

        }

        private RectangleF GetPixelRectF(int x, int y)
        {
            return new RectangleF(x * GetPixelHeight(), y * GetPixelHeight(), GetPixelHeight(), GetPixelHeight());
        }

        private float GetPixelHeight()
        {
            return Dimensions.Height == 0 ? 0 : (float)Height / Dimensions.Height;
        }

        private void AtxCharacter_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || Mode == CharacterMode.Lock || Control.ModifierKeys != Keys.Control)
            {
                return;
            }

            for (int y = 0; y < Dimensions.Height; y++)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    if (GetPixelRectF(x, y).Contains(e.Location) && pixels[x, y] != MouseMoveWay)
                    {
                        pixels[x, y] = MouseMoveWay;
                        Invalidate();
                        return;
                    }
                }
            }
        }
    }
}
