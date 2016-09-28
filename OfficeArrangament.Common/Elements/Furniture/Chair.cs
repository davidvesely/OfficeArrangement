using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common
{
    public class Chair : Furniture
    {
        public Chair() : base(ElementType.Chair)
        {

        }

        public override Brand Brand
        {
            set
            {
                base.Brand = value;
                switch (value)
                {
                    case Brand.HermanMiller:
                        this.Color = System.Drawing.Color.White;
                        this.Shape = Shape.Square;
                        break;
                    case Brand.Wilkhahn:
                        this.Color = System.Drawing.Color.Blue;
                        this.Shape = Shape.Star;
                        break;
                    default:
                        throw new NotImplementedException(value.ToString());
                }
            }
        }

        protected override void DrawGraphics(Graphics graph, int width)
        {
            throw new NotImplementedException();
        }
    }
}
