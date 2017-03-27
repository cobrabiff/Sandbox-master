using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    /// <summary>
    /// Animal is our base class or 'superclass'.
    /// A derived class is a class created or derived from another existing class. 
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// All derived classes will inherit Classification
        /// </summary>
        public AnimalType Classification { get; set; } // get/set is the same as read/write
        /// <summary>
        /// All derived classes will inherit Size
        /// </summary>
        public AnimalSize Size { get; set; }

        /// <summary>
        /// Is not inheritable because it is a private 'Field'
        /// </summary>
        private int _myInteger;

        /// <summary>
        /// Inheritable in derived classes
        /// </summary>
        public int MyInteger
        {
            get
            {
                //Example of encapsulation
                if (_myInteger > 5)
                {
                    return _myInteger;
                }
                return 0;
            }
            set
            {
                _myInteger = value;
            }
        }
        /// <summary>
        /// This is the constructor for the Animal class. Calling 'new Animal()' creates 
        /// a new Animal object. An object is and instance of a class.
        /// </summary>
        public Animal()
        {
            Classification = AnimalType.Unknown;
            Size = AnimalSize.Unknown;
        }
    }
}