using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Ten : Figure
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return (5 * Side * Side) * (1.0 / Math.Tan(3.14 / 10));
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Side / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawPolygon(new Pen(Color), Position.X, Position.Y, (int)Side);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
