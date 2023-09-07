using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile:Animal
    {
        public Reptile()
        {

        }
        public bool HasScales { get; set; }

        public bool IsColdblooded { get; set; }

        public int NumOfArmsAndLegs { get; set; }

        public string ColorOfSkin { get; set; }


    }
}
