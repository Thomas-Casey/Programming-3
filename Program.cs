using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your first name?");
            string firstname = Console.ReadLine();

            Console.writeline("whats your surname?");
            string surname = Console.ReadLine();

            string fullname = firstname + " " + surname;

            Console.WriteLine(fullname);
        }
    }
}
