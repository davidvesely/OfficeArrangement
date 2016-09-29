using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common.Interior
{
    public abstract class Interior : FreeSpace
    {
        private Palette _palette;
        public virtual Palette Palette
        {
            get { return _palette; }
            set { _palette = value; }
        }

        public Interior(ElementType type, int width)
            : base(type, width)
        {
        }
    }
}
