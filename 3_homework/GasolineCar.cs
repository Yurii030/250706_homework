using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_homework
{
    internal class GasolineCar : Car
    {
        public GasolineCar(string name,Engine engine) : base(name,engine) { } 
        // 해당 키워드를 사용하는 클래스 부모 클래스를 가리키는것  : base()

        public override void PrintInfo()
        {
            Console.WriteLine($"- 휘발유 자동차 : {name}");
            base.PrintInfo(); // 기본클래스 메서드 호출

        }
    }
}
