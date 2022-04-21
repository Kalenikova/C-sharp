using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Rhombus : Figure
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public override double GetArea()
        {
            return Diagonal1 * Diagonal2 * 0.5;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Diagonal1 / 2), (int)(Position.Y + Diagonal2 / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawPolygon(new Pen(Color), Position.X, Position.Y, (int)Diagonal1, (int)Diagonal2);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
