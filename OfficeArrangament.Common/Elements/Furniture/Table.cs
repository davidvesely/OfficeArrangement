using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common
{
    public class Table : Furniture
    {
        public Table() : base(ElementType.Table)
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
                        this.Color = System.Drawing.Color.Blue;
                        this.Shape = Shape.Circle;
                        break;
                    case Brand.Wilkhahn:
                        this.Color = System.Drawing.Color.Red;
                        this.Shape = Shape.Hexagon;
                        break;
                    default:
                        throw new NotImplementedException(value.ToString());
                }
            }
        }
    }
}
