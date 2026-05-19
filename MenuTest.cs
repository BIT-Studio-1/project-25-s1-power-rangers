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

            plantScene1();
            
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

        static void plantScene1 ()
        {
            int selfishness = 0;
            int stupidity = 0;
            int plant = 0;
            WriteLine("I am a sunflower in the valleys of dunedin in Mr. Vaughn Malkin's Garden. I have spent most of my life listening to him about making SQL databases.");
            WriteLine("It is now the time to decide your destiny: ");

            WriteLine("LEVEL 1");
            WriteLine("GAME OF HONEY");
            menu("LET BEE EXTRACT HONEY", "KILL  THE BEE INSTEAD", "FIGHT BACK", "NONE OF THESE");

            if (D1 == true)
            {
                plant += 100;
                stupidity += 100;
                selfishness += 0;
                    
            }
            if (D2 == true)
            {
                plant = 10;
                selfishness = 500;
                stupidity = 200;
            }
            if (D3 == true)
            {
                plant = 200;
                selfishness = 100;
                stupidity = 50;
            }
            if (D4 == true)
            {
                plant = 0;
                selfishness = 100;
                stupidity = 200;
            }




            WriteLine("LEVEL 2");
            WriteLine("USA VS VENEZUELA OIL EXTRACTION");
            menu("KILL THE EXTRACTOR", "LET IT HAPPEN", "SUICIDE", "NONE OF THESE");
            if (D1 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;
            }
            if (D2 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;
            }
            if (D3 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;
            }
            if (D4 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;
            }

            WriteLine("LEVEL 3");
            WriteLine("DOG AND HIS POOP");
            menu("LET HIM DO IT", "KILL HIM", "DO NOTHING", "SMILE AT HIM");
            if (D1 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;
            }
            if (D2 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;

            }
            if (D3 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;

            }
            if (D4 == true)
            {
                selfishness = 0;
                stupidity = 0;
                plant = 0;
            }

            WriteLine("DEATH LEVEL");
            WriteLine("GAME OF WINDS");
            menu("FIGHT BACK", "", "", "");

            return;
        }

        static void fishScene1()
        {
            int selfishness = 0;
            int stupidity = 0;
            int loyalty = 0;
            WriteLine("You have reincarnated to a fish in a vast ocean of many pools and many schools (of fish)");
            WriteLine("You hatch as a fish egg");
            WriteLine("Your fish siblings are also hatched");

        }

    }
}
