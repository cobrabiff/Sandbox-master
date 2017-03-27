using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // Since GermanShepard inherits from Dog, its AnimalType is already known. 
    public class GermanShepard : Dog
    {
        public GermanShepard()
        {
            // Set the specific size of GermanShepard
            Size = AnimalSize.Medium;
        }
    }
}