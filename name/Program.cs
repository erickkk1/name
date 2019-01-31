using System;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?!");
            try
            {

                String name;
                name = Console.ReadLine();


                Console.WriteLine("Hello !" + name);
                Console.WriteLine("press any key to continue...");
                Console.ReadKey(true);



            }
            catch
            {
                Console.WriteLine("enter a name");
                Console.ReadKey(true);
            }
        }
    }
}
