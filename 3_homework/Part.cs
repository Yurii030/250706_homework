using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_homework
{
    internal class Part
    {
        public string PartName { get; set; }
        public int Price { get; set; }

        public Part(string partName, int price)
        {
            PartName = partName;
            Price = price;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"> {PartName} (Price : {Price})");
        }
    }
}
