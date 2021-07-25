using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    struct FigureStruct
    {
        public double SideLength { get; set; }
        public double NumberSides { get; set; }
        public double Square { get; set; }

        public FigureStruct(double sideLength, double numberSides, double square)
        {
            SideLength = sideLength;
            NumberSides = numberSides;
            Square = square;
        }
    }
}
