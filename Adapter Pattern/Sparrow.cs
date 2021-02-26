using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Sparrow:IBird
    {
        public void FlapWingsToFly()
        {
            Console.WriteLine("Bird is now flying!");
        }
    }
}
