using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{

    class Program
    {
        static void Main()
        {
            Animal animal = new Animal();
            Console.WriteLine("***Animal Object***");
            Console.WriteLine("Type: " + animal.Classification);
            Console.WriteLine("Size: " + animal.Size);
            
            Dog dog = new Dog();
            Console.WriteLine("***Dog Object***");
            Console.WriteLine("Type: " + dog.Classification);
            Console.WriteLine("Size: " + dog.Size);

            Poodle poodle = new Poodle();
            Console.WriteLine("***Poodle Object***");
            Console.WriteLine("Type: " + poodle.Classification);
            Console.WriteLine("Size: " + poodle.Size);

            GermanShepard germanShepard = new GermanShepard();
            Console.WriteLine("***GermanShepard Object***");
            Console.WriteLine("Type: " + germanShepard.Classification);
            Console.WriteLine("Size: " + germanShepard.Size);

            GreatDane greatDane = new GreatDane();
            Console.WriteLine("***GreatDane Object***");
            Console.WriteLine("Type: " + greatDane.Classification);
            Console.WriteLine("Size: " + greatDane.Size);

            Console.ReadLine();
        }
    }
}