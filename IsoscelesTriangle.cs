using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_3
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle()
        {
            Name = "Isosceles triangle";
        }

        public override double Perimeter()
        {
            var side3 = (double)(Side1 * Side1 + Side2 * Side2) - 2.0 * (double)Side1 * (double)Side2 * Math.Cos(Angle);

            side3 = Math.Sqrt(side3);

            return Side1 + Side2 + side3;
        }

        public override double Square()
        {
            return (double)Side1 * (double)Side2 * Math.Sin(Angle) / 2.0;
        }

    }
}
