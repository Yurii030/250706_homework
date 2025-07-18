using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_homework
{
    internal class ElectricCar : Car
    {
        public ElectricCar(string name,Engine engine) : base() { }
        // 해당 키워드를 사용하는 클래스 부모 클래스를 가리키는것  : base()

        public override void PrintInfo()
        {
            Console.WriteLine($"- 전기 자동차 : {Models}");
            Car.PrintInfo();
        }


        public IceWizard(string name) : base(name) { }
        public override void PrintInfo()
        {
            Console.WriteLine($"- 얼음마법사 : {Name}");
            SpellBook.PrintSpells();
        }
    }

}

