using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // Since GreatDane inherits from Dog, its AnimalType is already known.
    public class GreatDane : Dog
    {
        public GreatDane()
        {
            // Set the specific size of GreatDane
            Size = AnimalSize.Large;
        }
    }
}