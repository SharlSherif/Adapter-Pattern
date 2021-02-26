using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sparrow = new Sparrow();
            var plane = new Plane();
            sparrow.FlapWingsToFly();
            plane.Fly();

            IPlane bird = new BirdAdapter(new Sparrow());
            bird.Fly();

            if (System.Diagnostics.Debugger.IsAttached) Console.ReadLine();
        }
    }
}
