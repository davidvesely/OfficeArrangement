using System;
using OfficeArrangament.Common.Enumerations;
using OfficeArrangament.Common.Images;

namespace OfficeArrangament.Common
{
    public class Chair : Furniture
    {
        public Chair() : base(ElementType.Chair)
        {
            NotOccupiedImageName = ImageNames.ChairEmpty;
        }

        public override Brand Brand
        {
            set
            {
                switch (value)
                {
                    case Brand.HermanMiller:
                        OccupiedImageName = ImageNames.ChairHermanMiller;
                        break;
                    case Brand.Wilkhahn:
                        OccupiedImageName = ImageNames.ChairWilkhahn;
                        break;
                    default:
                        throw new NotImplementedException(value.ToString());
                }
            }
        }
    }
}
