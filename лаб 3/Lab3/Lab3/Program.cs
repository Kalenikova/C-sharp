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
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №3 - Полиморфизм");
            Console.WriteLine("Выполнила - Каленикова Анастасия");

            Figure f = new Rectangle()
            {
                Name = "Прямоугольник",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50,
                Height = 50
            };

            Console.WriteLine("Фигура: " + f.Name);
            Console.WriteLine("Площадь: " + f.GetArea());
            Console.WriteLine("Цвет: " + f.Color);
            Console.WriteLine("Положение фигуры: " + f.Position);
            Console.WriteLine("Координаты центра: " + f.GetCenter());
        }
    }
}