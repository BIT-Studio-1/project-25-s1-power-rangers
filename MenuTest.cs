using Microsoft.VisualBasic.FileIO;
using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using static System.Console;
using static System.ConsoleKey;

namespace CodeCode
{
    public class MenuTest
    {
        
        static ConsoleKey key;

        static int globalScore = 0;
        static int option = 1;
        static bool D1 = false;
        static bool D2 = false;
        static bool D3 = false;
        static bool D4 = false;



        static int savedLeft;
        static int savedTop;


        static void controller()
        {
            // This is all benjamin's code

            key = ReadKey(true).Key;
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
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 2))
            {
                D2 = true;
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 3))
            {
                D3 = true;
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 4))
            {
                D4 = true;
                return;
            }


        }

        static void menu(string A, string  B, string  C, string  D) {
            WriteLine("\nMove: Arrows  Select Space/Enter");
            savedLeft = CursorLeft;
            savedTop = CursorTop;

            D1 = false; D2 = false; D3 = false; D4 = false;


            // This is also all benjamin's code
            while (D1 != true || D2 != true || D3 != true || D4 != true)
            {
                Console.SetCursorPosition(savedLeft, savedTop);

                if (option == 1)
                {
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                    WriteLine($" > {A}");
                    ResetColor();
                    WriteLine($"   {B}");
                    WriteLine($"   {C}");
                    WriteLine($"   {D}");
                }
                else if (option == 2)
                {
                    WriteLine($"   {A}");
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                    WriteLine($" > {B}");
                    ResetColor();
                    WriteLine($"   {C}");
                    WriteLine($"   {D}");
                }
                else if (option == 3)
                {
                    WriteLine($"   {A}");
                    WriteLine($"   {B}");
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                    WriteLine($" > {C}");
                    ResetColor();
                    WriteLine($"   {D}");
                }
                else if (option == 4)
                {
                    WriteLine($"   {A}");
                    WriteLine($"   {B}");
                    WriteLine($"   {C}");
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                    WriteLine($" > {D}");
                    ResetColor();
                }

                controller();


                if (D1 == true || D2 == true || D3 == true || D4 == true)
                {
                    return;
                }

            }
            
        }
        static void Main(string[] args)
        {
            WriteLine("Welcome to the game yo");

            room1();

            Write("advance to room 2");
            // ReadLine();


            room2();

            plantscene1();
            
        }

        static void room1()
        {
            // D1 = false; D2 = false; D3 = false; D4 = false;
            
            Clear();
            WriteLine("a man has fallen into a river in lego city");
            WriteLine("Will you make choice 1 for this reason?");
            WriteLine("Or perhaps choice 2");
            WriteLine("Blablabla");

            menu("choice 1", "choice 2, do this", "choice 3", "choice 4");



            return;
        }

        static void room2() {

            
            Clear();
            WriteLine("this is room 2 heres the words");
            menu("room 2 choice 1", "room 2 choice 2", "room 2 choice 3", "room 2 choice 4");


            return;

        }

        static void plantscene1 ()
        {
            Clear();
            WriteLine("I am a sunflower in the valleys of dunedin in Mr. Vaughn Malkin's Garden. I have spent most of my life listening to him about making SQL databases.");
            WriteLine("");




            return;
        }

    }
}
