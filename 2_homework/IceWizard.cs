using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_homework
{
    internal class IceWizard : Wizard
    {
        public IceWizard(string name) : base(name) { }
        public override void PrintInfo()
        {
            Console.WriteLine($"- 얼음마법사 : {Name}");
            SpellBook.PrintSpells();
        }
    }
}
