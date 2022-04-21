using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Trapezoid : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (Side1+Side2) * Height * 0.5;
        }
    }
}
