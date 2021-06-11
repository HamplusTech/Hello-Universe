using System;
using System.IO;

namespace Hello_Universe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Universe");
            Console.ReadKey();
            //iterate over command line
            // and print them out
            for (int arg = 0; arg < args.Length; arg++)
            {
                Console.WriteLine("arg{0}:{1}", arg, args[arg]);
            }
         }
    }
}
