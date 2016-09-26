using OfficeArrangament.Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeArrangament.Common
{
    public abstract class Tile
    {
        public ElementType Type { get; protected set; }

        public Tile(ElementType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Draw single map element. For simplicity
        /// we assume that the drawing field is square
        /// </summary>
        /// <param name="width">Width and height of the drawing field</param>
        /// <returns></returns>
        public Bitmap Draw(int width)
        {
            Bitmap bmp = new Bitmap(width, width);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                DrawGraphics(graph, width);
            }
            return bmp;
        }

        /// <summary>
        /// Main method, used for drawing single element
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="width"></param>
        protected abstract void DrawGraphics(Graphics graph, int width);
    }
}
