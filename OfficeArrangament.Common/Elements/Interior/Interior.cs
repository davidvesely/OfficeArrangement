using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common
{
    public abstract class Interior : FreeSpace
    {
        public abstract Palette Palette { set; }

        public Interior(ElementType type, int width)
            : base(type, width)
        {
            // Default palette
            Palette = Palette.Light;
        }
    }
}
