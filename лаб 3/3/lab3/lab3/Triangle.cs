using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Triangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Point m1 { get; set; }
        public Point m2 { get; set; }
        public Point m3 { get; set; }


        public override double GetArea()
        {
            return Width * Height * 0.5;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Width / 3), (int)(Position.Y + Height / 3));
        }

        public override void Draw(Graphics gr)
        {
            Point[] point = { m1, m2, m3 };
            gr.DrawPolygon(new Pen(Color.Red, 1) , point);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}