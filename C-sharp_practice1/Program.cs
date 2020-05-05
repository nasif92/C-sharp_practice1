using System;

namespace C_sharp_practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nasif";
            for (int i= 0; i < 5; i++)
            {
                Console.WriteLine("Hello World!");

            }
            Console.WriteLine("Hello " + name);
            human x = new human("Nasif");
            Console.WriteLine("Hello there new object " + x.myName());
        }
    }
}
