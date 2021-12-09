using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_3
{
    abstract class Triangle
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public double Angle { get; set; }

        protected string Name;

        public abstract double Square();
        public abstract double Perimeter();

        public override string ToString()
        {
            return Name + " with sides " + Side1 + ", " + Side2 + " and angle " + Angle;
        }
    }
}
