using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_homework
{
    internal class FireWizard : Wizard
    {
        public FireWizard(string name) : base(name) { }
        public override void PrintInfo()
        {
            Console.WriteLine($"- 불마법사 : {Name}");
            SpellBook.PrintSpells();
        }

    }
}
