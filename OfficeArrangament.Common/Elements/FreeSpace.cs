using OfficeArrangament.Common.Enumerations;
using System.Drawing;

namespace OfficeArrangament.Common
{
    public class FreeSpace : Tile
    {
        protected Color Color { get; set; } = Color.White;

        protected int Width { get; private set; }

        public FreeSpace(int width) : base(ElementType.Free)
        {
            Width = width;
        }

        public FreeSpace(ElementType type, int width) : base(type)
        {
            Width = width;
        }

        public override Bitmap Draw()
        {
            Bitmap bmp = new Bitmap(Width, Width);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Brush brush = new SolidBrush(Color);
                Rectangle imageSize = new Rectangle(0, 0, Width, Width);
                graph.FillRectangle(brush, imageSize);
            }
            return bmp;
        }
    }
}
