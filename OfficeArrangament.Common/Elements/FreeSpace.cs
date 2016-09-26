using OfficeArrangament.Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OfficeArrangament.Common
{
    public class FreeSpace : Tile
    {
        protected Color Color { get; set; } = Color.White;

        public FreeSpace() : base(ElementType.Free)
        {
        }

        public FreeSpace(ElementType type) : base(type)
        {
        }

        protected override void DrawGraphics(Graphics graph, int width)
        {
            Brush brush = new SolidBrush(this.Color);
            Fill(graph, brush, width);
        }

        /// <summary>
        /// Auxiliary method for drawing color filled elements
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="brush"></param>
        /// <param name="width"></param>
        private void Fill(Graphics graph, Brush brush, int width)
        {
            Rectangle imageSize = new Rectangle(0, 0, width, width);
            graph.FillRectangle(brush, imageSize);
        }
    }
}
