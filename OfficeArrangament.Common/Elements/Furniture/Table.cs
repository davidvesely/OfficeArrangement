using System;
using OfficeArrangament.Common.Enumerations;
using OfficeArrangament.Common.Images;

namespace OfficeArrangament.Common
{
    public class Table : Furniture
    {
        public Table() : base(ElementType.Table)
        {
            NotOccupiedImageName = ImageNames.TableEmpty;
        }

        public override Brand Brand
        {
            set
            {
                switch (value)
                {
                    case Brand.HermanMiller:
                        OccupiedImageName = ImageNames.TableHermanMiller;
                        break;
                    case Brand.Wilkhahn:
                        OccupiedImageName = ImageNames.TableWilkhahn;
                        break;
                    default:
                        throw new NotImplementedException(value.ToString());
                }
            }
        }
    }
}
