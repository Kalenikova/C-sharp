using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №2 - Наследование");
            Console.WriteLine("Выполнила - Каленикова Анастасия");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник", 
                Width = 15.2, 
                Height = 13.7        
            };

            Circle c = new Circle()
            {
                Name = "Круг",
                Radius = 10.5
            };

            Square s = new Square()
            {
                Name = "Квадрат",
                Width =9.2 
            };

            Triangle t = new Triangle()
            {
                Name = "Треугольник",
                Width = 9.2,
                Height = 5
            };

            Trapezoid tr = new Trapezoid()
            {
                Name = "Трапеция",
                Side1 = 3.2,
                Side2 = 1.8,
                Height = 6
            };

            Rhombus r = new Rhombus()
            {
                Name = "Ромб",
                Diagonal1 = 7.5,
                Diagonal2 = 11.5
            };

            Parallelogram p = new Parallelogram()
            {
                Name = "Параллелограм",
                Side = 12.5,
                Height = 4
            };

            Five f = new Five()
            {
                Name = "Правильный пятиугольник",
                Side = 2.5
            };

            Ten w = new Ten()
            {
                Name = "Правильный десятиугольник",
                Side = 3.14
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Площадь фигуры: {0}", c.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", s.Name);
            Console.WriteLine("Площадь фигуры: {0}", s.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", t.Name);
            Console.WriteLine("Площадь фигуры: {0}", t.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", tr.Name);
            Console.WriteLine("Площадь фигуры: {0}", tr.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", r.Name);
            Console.WriteLine("Площадь фигуры: {0}", r.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", p.Name);
            Console.WriteLine("Площадь фигуры: {0}", p.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", f.Name);
            Console.WriteLine("Площадь фигуры: {0}", f.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", w.Name);
            Console.WriteLine("Площадь фигуры: {0}", w.GetArea());
        }
    }
}