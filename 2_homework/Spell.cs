using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_homework
{
    internal class Spell : SpellBook
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Spell(string name, int power)
        {
            
            Name = name;
            Power = power;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" > {Name} (Power : {Power})");

        }
    }
}
