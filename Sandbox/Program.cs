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
            List<Animal> animals = new List<Animal>();

            Animal animal = new Animal();
            Console.WriteLine("***Animal Object***");
            Console.WriteLine("Type: " + animal.Classification);
            Console.WriteLine("Size: " + animal.Size);

            animal.MakeNoise();

            animals.Add(animal);

            Dog dog = new Dog();
            Console.WriteLine("***Dog Object***");
            Console.WriteLine("Type: " + dog.Classification);
            Console.WriteLine("Size: " + dog.Size);

            dog.MakeNoise();

            animals.Add(dog);

            Poodle poodle = new Poodle();
            poodle.Name = "Fifi";
            poodle.MakeNoise();
            Console.WriteLine("***Poodle Object***");
            Console.WriteLine("Type: " + poodle.Classification);
            Console.WriteLine("Size: " + poodle.Size);
            animals.Add(poodle);

            poodle = new Poodle();
            poodle.Name = "Rex";
            animals.Add(poodle);

            poodle = new Poodle();
            poodle.Name = "Fido";
            animals.Add(poodle);

            GermanShepard germanShepard = new GermanShepard();
            Console.WriteLine("***GermanShepard Object***");
            Console.WriteLine("Type: " + germanShepard.Classification);
            Console.WriteLine("Size: " + germanShepard.Size);

            germanShepard.MakeNoise();

            animals.Add(germanShepard);

            GreatDane greatDane = new GreatDane();
            Console.WriteLine("***GreatDane Object***");
            Console.WriteLine("Type: " + greatDane.Classification);
            Console.WriteLine("Size: " + greatDane.Size);

            greatDane.MakeNoise();

            animals.Add(greatDane);

            Console.WriteLine("List of animals length {0}", animals.Count());

            List<Poodle> poodles = new List<Poodle>();

            foreach(Animal a in animals)
            {
                if (a.Classification == AnimalType.Dog && a.GetType() == typeof(Poodle))
                {
                    poodles.Add((Poodle)a);
                }

                //Console.Write("GetType() {0} ", a.GetType());
                //Console.Write(" {0} ", a is Animal);
                //Console.Write(" {0} ", a is Dog);
                //Console.Write(" {0} ", a.GetType() == typeof(Dog));
                //Console.Write(" {0} ", a.GetType() == typeof(Poodle));
                //Console.Write(" {0} \n", a.GetType() == typeof(Animal));
            }

            Console.WriteLine("*** List of poodles ***");
            foreach(Poodle p in poodles)
            {
                Console.WriteLine("Name: {0}", p.Name);
                Console.WriteLine("I'm a poodle. ({0} - {1})", p.Classification, p.Size);
                
            }

            Console.ReadLine();
        }
    }
}