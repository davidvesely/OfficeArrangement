using System;
using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common
{
    public class Flowers : Interior
    {
        public Flowers(int width) : base(ElementType.Flowers, width)
        {
        }

        public override Palette Palette
        {
            set
            {
                switch (value)
                {
                    case Palette.Light:
                        Color = System.Drawing.Color.Purple;
                        break;
                    case Palette.Dark:
                        Color = System.Drawing.Color.Green;
                        break;
                    default:
                        throw new NotImplementedException(value.ToString());
                }
            }
        }
    }
}
