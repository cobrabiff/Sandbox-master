using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public enum AnimalType
    {
        Unknown,
        Dog, 
        Cat,
        Mouse
    }

    public enum AnimalSize
    {
        Unknown,
        Small,
        Medium,
        Large
    }

    public class Animal
    {
        public AnimalType Classification { get; set; }
        public AnimalSize Size { get; set; }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Unknown");
        }
    }

    public interface IAnimal
    {
        AnimalType Classification { get; set; }
        void MakeNoise();
    }

    public class Dog : Animal
    {
        public new AnimalType Classification
        {
            get
            {
                return base.Classification;
            }
            set
            {
                base.Classification = value;
            }
        }

        public Dog()
        {
            //Classification = AnimalType.Dog;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Poodle : Dog
    {
        public Poodle()
        {
            Size = AnimalSize.Small;
        }

        //public override void MakeNoise()
        //{
        //    Console.WriteLine("Yip");
        //}
    }
    
    class Program
    {
        static void Main()
        {
            Poodle poodle = new Poodle();

            poodle.MakeNoise();

            poodle.Classification = AnimalType.Dog;

            Console.ReadLine();
        }
    }
}