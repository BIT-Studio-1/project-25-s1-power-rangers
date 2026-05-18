using Microsoft.VisualBasic.FileIO;
using System;
using static System.Console;
using static System.ConsoleKey;

namespace CodeCode
{
    public class MenuTest
    {

        static ConsoleKey key;

        static int option = 1;
        static bool D1 = false;
        static bool D2 = false;
        static bool D3 = false;
        static bool D4 = false;


        static void controller()
        {
            //Controller for scrolling up and down options
            if ((key == DownArrow || key == S) && (option < 4))
            {
                option++;
            }
            else if ((key == UpArrow || key == W) && (option > 1))
            {
                option--;
            }

            //Controller for making a decision by selecting an option
            if ((key == Spacebar || key == Enter) && (option == 1))
            {
                D1 = true;
            }
            else if ((key == Spacebar || key == Enter) && (option == 2))
            {
                D2 = true;
            }
            else if ((key == Spacebar || key == Enter) && (option == 3))
            {
                D3 = true;
            }
            else if ((key == Spacebar || key == Enter) && (option == 4))
            {
                D4 = true;
            }


        }







        static void Main(string[] args)
        {
            WriteLine("yo");



            ReadLine();
            
        }
    }
}
