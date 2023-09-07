using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird:Animal
    {
        public Bird() 
        {
        
        }
        
        public bool HasFeathers { get; set; }

        public bool CanFly { get; set; }

        public int NumOfWings { get; set; }

        public string TypeOfChirpSound { get; set; }


    }
}
