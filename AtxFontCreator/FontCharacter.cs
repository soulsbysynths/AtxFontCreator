using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AtxFontCreator
{
    public partial class FontCharacter : UserControl
    {
        public event EventHandler? SelectedChanged;
        public event EventHandler? SourceRectChanged;
        public FontCharacter()
        {
            InitializeComponent();
        }
        private char character = 'A';

        public char Character
        {
            get { return character; }
            set
            {
                character = value;
                lblCharacter.Text = ((int)character).ToString() + Environment.NewLine + character.ToString();
            }
        }

        private Font characterFont = new(FontFamily.GenericSerif, 32);

        public Font CharacterFont
        {
            get { return characterFont; }
            set
            {
                characterFont = value;
            }
        }

        private bool selected;

        public bool Selected
        {
            get { return selected; }
            set
            {
                if (value == selected)
                {
                    return;
                }

                selected = value;
                Invalidate();
                SelectedChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        private RectangleF sourceRect;

        public RectangleF SourceRect
        {
            get { return sourceRect; }
            set
            {
                if (sourceRect == value)
                {
                    return;
                }

                sourceRect = value;
                this.Width = (int)Math.Ceiling(sourceRect.Width);
                this.Height = (int)Math.Ceiling(sourceRect.Height);
                SourceRectChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool LabelVisible
        {
            set
            {
                lblCharacter.Visible = value;
            }
        }

        public RectangleF SourceBoundingBox
        {
            get
            {
                GraphicsPath path = new();
                path.AddString(character.ToString(), characterFont.FontFamily, (int)characterFont.Style, characterFont.Size, new PointF(0, 0), CentreFormat());
                return path.GetBounds();
            }
        }

        public bool Include { get; set; }

        public static StringFormat CentreFormat()
        {
            StringFormat stringFormat = StringFormat.GenericDefault;
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            return stringFormat;
        }

        private void FontCharacter_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new(Color.White);
            GraphicsPath path = new();
            path.AddString(character.ToString(), characterFont.FontFamily, (int)characterFont.Style, characterFont.Size, new PointF(-sourceRect.X, -sourceRect.Y), CentreFormat());
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
            Pen pen = (sourceRect.Top == SourceBoundingBox.Top ||
                sourceRect.Right == SourceBoundingBox.Right ||
                sourceRect.Bottom == SourceBoundingBox.Bottom ||
                sourceRect.Left == SourceBoundingBox.Left) ?
                new Pen(Color.Cyan) : new Pen(Color.DarkGray);
            e.Graphics.DrawRectangle(pen, path.GetBounds());
            e.Graphics.FillPath(solidBrush, path);
            if (selected)
            {
                e.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, Size.Width - (int)Pens.White.Width, Size.Height - (int)Pens.White.Width));
            }
        }

        private void FontCharacter_Click(object sender, EventArgs e)
        {
            Selected = !selected;
        }

        private void FontCharacter_SizeChanged(object sender, EventArgs e)
        {
            lblCharacter.Size = Size;
            lblCharacter.BackColor = Color.FromArgb(192, 0, 0, 0);
        }
    }
}
