using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_homework
{
    internal class Engine
    {
        public Engine(int HorsePower, string Type)
        {
            this.HorsePower = HorsePower;
            this.Type = Type;
        }

        public int HorsePower { get; set; }
        public string Type { get; set; } 

        
        public void PrintInfo()
        {
            Console.WriteLine($"엔진 : {HorsePower}cc {Type}");
        }

    }
}
