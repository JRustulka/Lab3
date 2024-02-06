using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_part_2
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }

        public Dog(string name, string color, string height, string age)
        {
            this.Name = name;
            this.Color = color;
            this.Height = height;
            this.Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            return "Woof!";
        }

    }
}
