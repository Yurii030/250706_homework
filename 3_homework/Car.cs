using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_homework
{
    internal class Car
    {
        public string Models;
        private int index = 0;
        Engine Engine;
        Part[] parts = new Part[3];

        public Car()
        {

        }

        public virtual void AddPart(Part part)
        {
            if (index < parts.Length)
            {
                parts[index] = part;
                index++;
            }
        }

        public virtual void PrintPartInfo() 
        {
            foreach(Part part in parts) { 
                if(part != null)
                {
                    part.PrintInfo();
                }
            }
        }
    }
}
