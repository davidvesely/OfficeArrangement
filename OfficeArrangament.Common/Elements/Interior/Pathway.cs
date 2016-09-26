using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common.Interior
{
    public class Pathway : Interior
    {
        public Pathway() : base(ElementType.Pathway)
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
                        this.Color = System.Drawing.Color.Gray;
                        break;
                    case Palette.Dark:
                        this.Color = System.Drawing.Color.Brown;
                        break;
                    default:
                        throw new NotImplementedException(value.ToString());
                }
            }
        }
    }
}
