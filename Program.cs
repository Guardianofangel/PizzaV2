using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Store theCode = new Store();
            theCode.MyCode();

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}

