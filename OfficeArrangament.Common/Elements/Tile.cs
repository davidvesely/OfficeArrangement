using OfficeArrangament.Common.Enumerations;
using System.Drawing;

namespace OfficeArrangament.Common
{
    public abstract class Tile
    {
        public ElementType Type { get; protected set; }

        public Tile(ElementType type)
        {
            Type = type;
        }

        /// <summary>
        /// Draw single map element. For simplicity
        /// we assume that the drawing field is square
        /// </summary>
        /// <returns>Single drawn tile</returns>
        public abstract Bitmap Draw();
    }
}
