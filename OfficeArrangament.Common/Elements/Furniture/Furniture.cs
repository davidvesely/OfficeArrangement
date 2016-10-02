using OfficeArrangament.Common.Enumerations;
using System.Drawing;

namespace OfficeArrangament.Common
{
    public abstract class Furniture : Tile
    {
        protected string OccupiedImageName { get; set; }

        protected string NotOccupiedImageName { get; set; }

        public abstract Brand Brand { set; }

        public bool IsOccupied { get; set; }

        public Furniture(ElementType type)
            : base(type)
        {
            // Default brand
            Brand = Brand.HermanMiller;
        }

        public void ToggleIsOccupied()
        {
            IsOccupied = !IsOccupied;
        }

        public override Bitmap Draw()
        {
            string resourceName;
            if (IsOccupied)
            {
                resourceName = OccupiedImageName;
            }
            else
            {
                resourceName = NotOccupiedImageName;
            }

            return Utility.GetEmbeddedImage(resourceName);
        }
    }
}
