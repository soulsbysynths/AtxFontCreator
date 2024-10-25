using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AtxFontCreator
{
    public partial class FontCharacter : UserControl
    {
        public event EventHandler? IncludeClicked;
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
                lblCharacter.Text = character.ToString();
            }
        }

        private Font font = new(FontFamily.GenericSerif, 18);

        public Font CharacterFont
        {
            get { return font; }
            set
            {
                font = value;
            }
        }


        private RectangleF sourceRect;

        public RectangleF SourceRect
        {
            get { return sourceRect; }
            set
            {
                sourceRect = value;
                Resize();
            }
        }

        private Bitmap destinationBitmap = new(66, 92);

        public Bitmap DestinationBitmap
        {
            get { return destinationBitmap; }
            set
            {
                destinationBitmap = value;
                Resize();
            }
        }


        public RectangleF SourceBoundingBox
        {
            get
            {
                GraphicsPath path = new();
                path.AddString(character.ToString(), font.FontFamily, (int)font.Style, font.Size, new PointF(0, 0), CentreFormat());
                return path.GetBounds();
            }
        }

        private bool include = true;

        public bool Include
        {
            get { return include; }
            set
            {
                if (include == value)
                {
                    return;
                }

                include = value;
                chkInclude.Checked = include;
            }
        }

        private new void Resize()
        {
            Graphics g = Graphics.FromImage(DestinationBitmap);
            SolidBrush solidBrush = new(Color.White);
            GraphicsPath path = new();
            path.AddString(character.ToString(), font.FontFamily, (int)font.Style, font.Size, new PointF(-sourceRect.X, -sourceRect.Y), CentreFormat());
            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
            if (sourceRect.Height > 0)
            {
                g.ScaleTransform((float)destinationBitmap.Width / (float)sourceRect.Width, (float)destinationBitmap.Height / (float)sourceRect.Height);
            }

            g.FillPath(solidBrush, path);
            picSource.Left = picSource.Margin.Left;
            picSource.Size = new Size((int)Math.Ceiling(sourceRect.Size.Width), (int)Math.Ceiling(sourceRect.Height));  //sourceRect.Size.ToSize();
            picDestination.Left = picSource.Right + picSource.Margin.Right + picDestination.Margin.Left;
            picDestination.Size = destinationBitmap.Size;
            Width = Math.Max(picDestination.Right + picDestination.Margin.Right, chkInclude.Right + chkInclude.Margin.Right);
            Height = Math.Max(picSource.Bottom + picDestination.Margin.Bottom, picDestination.Bottom + picSource.Margin.Bottom);
        }

        private static StringFormat CentreFormat()
        {
            StringFormat stringFormat = StringFormat.GenericDefault;
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            return stringFormat;
        }

        private void PicSource_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new(Color.White);
            GraphicsPath path = new();
            path.AddString(character.ToString(), font.FontFamily, (int)font.Style, font.Size, new PointF(-sourceRect.X, -sourceRect.Y), CentreFormat());
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
            Pen pen = (sourceRect.Top == SourceBoundingBox.Top ||
                sourceRect.Right == SourceBoundingBox.Right ||
                sourceRect.Bottom == SourceBoundingBox.Bottom ||
                sourceRect.Left == SourceBoundingBox.Left) ?
                new Pen(Color.Cyan) : new Pen(Color.DarkGray);
            e.Graphics.DrawRectangle(pen, path.GetBounds());
            e.Graphics.FillPath(solidBrush, path);
        }

        private void PicDestination_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(DestinationBitmap, 0, 0);
        }

        private void ChkInclude_Click(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                Include = checkBox.Checked;
                IncludeClicked?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
