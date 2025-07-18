using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_homework
{
    internal class Wizard
    {
        public string Name { get; set; } // 마법사 이름
        public SpellBook SpellBook { get; set; } // 위력
        public Wizard(string name)
        {
            Name = name;
            SpellBook = new SpellBook();
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"- 마법사  : {Name}");
            SpellBook.PrintSpells();
        }
    }
}
