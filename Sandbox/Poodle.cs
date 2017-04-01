using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // Since Poodle inherits from Dog, its AnimalType is already known.
    public class Poodle : Dog
    {
        public Poodle()
        {
            // Set the specific size of Poodle
            Size = AnimalSize.Small;            
        }

        //public override void MakeNoise()
        //{
        //    //throw new NotImplementedException();
        //}

        public override void Bark()
        {
            //base.Bark();
            Console.WriteLine("Yip!");
        }

        public new void OtherBark()
        {
            base.Bark();
            //Console.WriteLine("Yip!");
        }
    }
}