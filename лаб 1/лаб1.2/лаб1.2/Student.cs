using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sudent
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string Color { get; set; }
        public void Add(Sudent x)
        {
            Name += x.Name;
            Sex += x.Sex;
            Age += x.Age;
            Color += x.Color;
        }
    }
}
