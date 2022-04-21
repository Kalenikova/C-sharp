using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1 - Инкапсуляция");
            Console.WriteLine("Выполнила - Каленикова Анастасия");

            Sudent a = new Sudent() { Name="Ivan", Sex="male", Age="20", Color="brown" };
            Sudent b = new Sudent() { Name = "Anna", Sex = "female", Age = "19", Color = "blonde" };
            Sudent c = new Sudent() { Name = "Petr", Sex = "male", Age = "21", Color = "black" };
            Sudent d = new Sudent() { Name = "Kate", Sex = "female", Age = "22", Color = "ginger" };


            a.Add(b);

            b.Add(a);

            c.Add(d);

            d.Add(c);

            Console.WriteLine("a = {0} + {1} + {2} + {3}", a.Name, a.Sex, a.Age, a.Color );
            Console.WriteLine("b = {0} + {1} + {2} + {3}", b.Name, b.Sex, b.Age, b.Color );
            Console.WriteLine("c = {0} + {1} + {2} + {3}", c.Name, c.Sex, c.Age, c.Color );
            Console.WriteLine("d = {0} + {1} + {2} + {3}", d.Name, d.Sex, d.Age, d.Color );
        }
    }
}