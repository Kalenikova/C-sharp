using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Radius * Radius * 3.14;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Radius / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Radius);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
