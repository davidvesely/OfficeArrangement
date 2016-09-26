using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeArrangament.Common.Enumerations;
using System.Drawing;

namespace OfficeArrangament.Common
{
    public abstract class Furniture : Tile
    {
        protected Color Color { get; set; }

        protected Shape Shape { get; set; }

        private Brand _brand;
        public virtual Brand Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public Furniture(ElementType type)
            : base(type)
        {
        }
    }
}
