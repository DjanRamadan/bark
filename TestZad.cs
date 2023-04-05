using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestZad
{
    internal class TestZad
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.Name = "Sharo";
            myDog.Age = 3;
            Console.WriteLine($"{myDog.Name} is {myDog.Age} years old");
            myDog.Bark(5);
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Bark(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"Dog {Name} barks!");
            }
        }
    }
}