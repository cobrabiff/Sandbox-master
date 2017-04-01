using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Dog : Animal
    {
        public string Name { get; set; }

        public Dog()
        {
            Classification = AnimalType.Dog;
        }

        public override void MakeNoise()
        {
            Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Bark!");
        }

        public void OtherBark()
        {
            Console.WriteLine("Bark!");
        }


    }
}