using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Trapezoid : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (Side1 + Side2) * Height * 0.5;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Side1 / 2), (int)(Position.Y + Height / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawPolygon(new Pen(Color), Position.X, Position.Y, (int)Side1, (int)Height);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
