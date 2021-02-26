using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class BirdAdapter: IPlane
    {
        private IBird bird;

        public BirdAdapter (IBird Bird)
        {
            this.bird = Bird;
        }

        public void Fly()
        {
            bird.FlapWingsToFly();
        }
    }
}
