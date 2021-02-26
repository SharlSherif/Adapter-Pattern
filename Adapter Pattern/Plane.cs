using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Plane: IPlane
    {
        public void Fly()
        {
            Console.WriteLine("Plane is now flying!");
        }
    }
}
