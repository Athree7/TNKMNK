using System;
using Sys = Cosmos.System;

namespace TNKMNK
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("TNKMNK KERNEL");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
        }
    }
}
