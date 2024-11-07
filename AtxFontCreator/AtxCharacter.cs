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
        private bool EditWay = false;

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
            LockWidth();
        }

        public char Character { get; set; }

        private bool selected = true;

        public bool Selected
        {
            get { return selected; }
            set 
            { 
                selected = value; 
                Invalidate();
            }
        }

        private bool locked;

        public bool Locked
        {
            get { return locked; }
            set 
            { 
                locked = value;
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
                LockWidth();
                Invalidate();
            }
        }

        public Bitmap GetBitmap()
        {
            if (Dimensions.Width == 0 || Dimensions.Height == 0)
            {
                return new Bitmap(1, 1);
            }

            Bitmap bmp = new(Dimensions.Width, Dimensions.Height);
            for (int y = 0; y < Dimensions.Height; y++)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    bmp.SetPixel(x, y, pixels[x, y] ? Color.White : Color.Black);
                }
            }

            return bmp;
        }

        public bool GetPixel(Point location)
        {
            if (location.X < 0 || location.Y < 0 || location.X >= Dimensions.Width || location.Y >= Dimensions.Height)
            {
                return false;
            }

            return pixels[location.X, location.Y];
        }

        public void SetPixel(Point location, bool value)
        {
            if (locked)
            {
                return;
            }

            if (location.X < 0 || location.Y < 0 || location.X >= Dimensions.Width || location.Y >= Dimensions.Height)
            {
                return;
            }

            if (pixels[location.X, location.Y] == value)
            {
                return;
            }

            pixels[location.X, location.Y] = value;
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

        public void StartEditPixel(Point location)
        {
            if (locked)
            {
                return;
            }

            for (int y = 0; y < Dimensions.Height; y++)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    if (GetPixelRectF(new Point(x, y)).Contains(location))
                    {
                        pixels[x, y] = !pixels[x, y];
                        EditWay = pixels[x, y];
                        Invalidate();
                        return;
                    }
                }
            }
        }

        public void ContinueEditPixel(Point location)
        {
            if (locked)
            {
                return;
            }

            for (int y = 0; y < Dimensions.Height; y++)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    if (GetPixelRectF(new Point(x, y)).Contains(location))
                    {
                        if (pixels[x, y] != EditWay)
                        {
                            pixels[x, y] = EditWay;
                            Invalidate();
                        }

                        return;
                    }
                }
            }
        }

        private void AtxCharacter_Paint(object sender, PaintEventArgs e)
        {
            for (int y = 0; y < Dimensions.Height; y++)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    RectangleF rectF = GetPixelRectF(new Point(x, y));
                    e.Graphics.FillRectangle(pixels[x, y] ? Brushes.Ivory : Brushes.DimGray, rectF);
                    e.Graphics.DrawRectangle(Pens.Gray, rectF);
                }
            }

            Pen pen = selected ? Pens.White : Pens.Black;
            e.Graphics.DrawRectangle(pen, 0, 0, Width - pen.Width, Height - pen.Width);
            if (locked)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, Color.Black)), 0, 0, Width, Height);
            }
        }

        private RectangleF GetPixelRectF(Point location)
        {
            return new RectangleF(location.X * GetPixelHeight(), location.Y * GetPixelHeight(), GetPixelHeight(), GetPixelHeight());
        }

        private float GetPixelHeight()
        {
            return Dimensions.Height == 0 ? 0 : (float)Height / Dimensions.Height;
        }

        private void LockWidth()
        {
            int w = (int)(GetPixelHeight() * Dimensions.Width);
            if (Width != w)
            {
                Width = w;
            }
        }

        private void AtxCharacter_Resize(object sender, EventArgs e)
        {
            LockWidth();
        }
    }
}
