using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common.Interior
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
                base.Palette = value;
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
