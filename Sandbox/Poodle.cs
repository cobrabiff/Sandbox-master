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
    }
}