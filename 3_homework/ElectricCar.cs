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
        //  매개변수 넘겨줘야해서 base(name,engine)
        public ElectricCar(string name,Engine engine) : base(name,engine) { }
        // 해당 키워드를 사용하는 클래스 부모 클래스를 가리키는것  : base()

        public override void PrintInfo()
        {
            Console.WriteLine($"- 전기 자동차 : {name}");
            base.PrintInfo(); // 기본클래스 메서드 호출
        }

    }

}

