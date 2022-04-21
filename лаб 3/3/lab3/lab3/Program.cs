using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Program
    {
        public static Figure[] figures = {
            new Rectangle()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50,
                Height = 50
            },

            new Square()
            {
                Name = "Прямоугольник",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200, 200),
                Width = 100,
                Height = 50
            }

        };
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №3 - Полиморфизм");
            Console.WriteLine("Выполнила - Каленикова Анастасия");

            Form frm = new Form()
            {
                Text = "Лабораторная №3 - Полиморфизм",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };

            frm.Paint += Frm_Paint;

            Application.Run(frm);
        }

        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }

    }
}