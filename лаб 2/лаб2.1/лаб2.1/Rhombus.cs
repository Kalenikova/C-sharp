using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Rhombus : Figure
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public override double GetArea()
        {
            return Diagonal1 * Diagonal2 * 0.5;
        }
    }
}
