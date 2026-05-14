using System;

namespace CodeCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user;

            Console.WriteLine("Enter the word quit to leave the game: ");
            user = Console.ReadLine();
            while (user != "quit")
            {


                Console.WriteLine("i said enter the word quit, come on its so damn easy man: ");
                user = Console.ReadLine();

                if (user == "no")
                {
                    Console.WriteLine("what do you mean no???");
                }

                if (user == "why")
                {
                    Console.WriteLine("are you dense?");
                }


            }
            Console.Clear();
        }
    }
}
