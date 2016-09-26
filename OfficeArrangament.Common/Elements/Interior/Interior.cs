using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeArrangament.Common.Enumerations;
using System.Drawing;

namespace OfficeArrangament.Common.Interior
{
    public class Interior : FreeSpace
    {
        private Palette _palette;
        public virtual Palette Palette
        {
            get { return _palette; }
            set { _palette = value; }
        }

        public Interior(ElementType type)
            : base(type)
        {
        }
    }
}
