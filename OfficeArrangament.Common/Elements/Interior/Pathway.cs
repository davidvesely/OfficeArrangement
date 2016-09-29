﻿using System;
using OfficeArrangament.Common.Enumerations;

namespace OfficeArrangament.Common.Interior
{
    public class Pathway : Interior
    {
        public Pathway(int width) : base(ElementType.Pathway, width)
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
                        Color = System.Drawing.Color.Gray;
                        break;
                    case Palette.Dark:
                        Color = System.Drawing.Color.Brown;
                        break;
                    default:
                        throw new NotImplementedException(value.ToString());
                }
            }
        }
    }
}
