using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_homework
{
    internal class Car
    {
        private int index = 0;
        public Engine Engine { get; set; }
        Part[] parts = new Part[3];
        public string name;
        
        public Car(string name, Engine engine)
        {
            this.name = name;
            Engine = engine;
        }

        public virtual void AddPart(Part part)
        {
            if (index < parts.Length)
            {
                parts[index] = part;
                index++;
            }
        }

        public virtual void PrintInfo() 
        {
            Console.WriteLine($"자동차 : {name}");
            if(Engine != null)
            {
                Engine.PrintInfo();
            }
            Console.WriteLine("부품:");
            foreach (Part part in parts) { 
                if(part != null)
                {
                    part.PrintInfo();
                }
            }
        }
    }
}
