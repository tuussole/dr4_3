using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_3
{
    class RectularTriangle : Triangle
    {
        public RectularTriangle()
        {
            Name = "Rectular triangle";
        }
        public override double Perimeter()
        {
            var side3 = Math.Sqrt(Side1 * Side1 + Side2 * Side2);
            return Side1 + Side2 + side3;
        }

        public override double Square()
        {
            return (double)Side1 * (double)Side2 / 2.0;
        }
    }
}
