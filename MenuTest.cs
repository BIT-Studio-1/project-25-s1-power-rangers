using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using static CodeCode.SoundUtils;
using static CodeCode.fish;
using static System.Console;
using static System.ConsoleKey;
using static CodeCode.starfish;
using static CodeCode.dolphin;
using static CodeCode.GameTitle;
using static CodeCode.plant;


namespace CodeCode
{
    public class MenuTest
    {
        
        static ConsoleKey key;

        static int globalScore = 0;
        static int option = 1;
        public static bool D1 = false;
        public static bool D2 = false;
        public static bool D3 = false;
        public static bool D4 = false;



        static int savedLeft;
        static int savedTop;


        static void controller(int opt)
        {
            // This is all benjamin's code

            CursorVisible = false;
            key = ReadKey(true).Key;
            //Controller for scrolling up and down options
            if ((key == DownArrow || key == S) && (option < opt))
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

        // Input a chance 1 - 100 and return a bool
        public static bool deathRoll(int chance)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 101);
            if (roll <= chance)
            {
                return true;
            }


            return false;
        }


        public static char menu(string A, string B, string C, string D, int opt = 4) {
            //WriteLine("param: " + opt);
            WriteLine("\nMove: Arrows  Select: Space/Enter");
            savedLeft = CursorLeft;
            savedTop = CursorTop;

            
            option = 1;
            D1 = false; D2 = false; D3 = false; D4 = false;


            // This is also all benjamin's code
            while (D1 != true && D2 != true && D3 != true && D4 != true)
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

                controller(opt);
                

              
                    if (D1 == true)
                    {
                        return 'A';
                    }
                    else if (D2 == true)
                    {
                        return 'B';
                    }
                    else if (D3 == true)
                    {
                        return 'C';
                    }
                    else if (D4 == true) {
                    
                        return 'D';
                    }
                    
               

            }
            // the line below never runs, as controller will always make one of the D bools true
            // it's just to fix an error that happens when the method finishes without returning anything
            return ' ';

        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TitleScreen();
            if (GameTitle.start1 == 1)
            { amebaScene1(); }
            else if (GameTitle.end1 == 1)
            { return;}
            plantLife();
            fishLife();

            if (fish.Selfishness >= 25) {
                dolphinlife();
            }
            else {
                starfishLife();
            }
            wormlife();  
            Console.Write("Press enter to close program");
            Console.ReadLine(); // stops program exiting
        }

        static void room1() // test room
        {
            Clear();
            WriteLine("a man has fallen into a river in lego city");
            WriteLine("Will you make choice 1 for this reason?");
            WriteLine("Or perhaps choice 2");
            WriteLine("Blablabla");
            menu("choice 1", "choice 2, do this", "choice 3", "choice 4");

            return;
        }

        static void room2() { // also test room
            Clear();
            WriteLine("this is room 2 heres the words");
            menu("room 2 choice 1", "room 2 choice 2", "room 2 choice 3", "room 2 choice 4");

            return;
        }

      




        static void wormlife()
        {
            //davids shitty ass code
            Clear();
            int length = 0;
            int dirt_consumed = 0;
            int wiggles = 0;

            WriteLine("**You are a worm now**");
            WriteLine("It's time to decide your destiny...");
            Clear();
            WriteLine("You wake up, confused in the dark, feeling your long slender body wiggling through the dirt ");
            Clear();
            WriteLine("LEVEL 1");
            WriteLine("It beguins to rain, what will you do?");
            switch(menu("Swim to the surface", "hold your breath", "drink the water", "wiggle"))
                {
                    default:
                        WriteLine("THE WORM BULLY");
                        WriteLine("It beguins to rain");
                        break;


                }

            return;
        }


        static void amebaScene1()
            {
                int selfishness = 50;
                int stupidity = 50;
                int bravery = 0;
                Clear();
                WriteLine("You've spawned in as an Ameba");
                WriteLine("This is the beginning");
                WriteLine("You have no eyes to see, no nose to smell, no tongue to taste");
                WriteLine("Senses are very minimal");
                WriteLine("Life as an Ameba is very 'Slide about'");

                switch(menu("Try to see", "try to smell", "Try to taste", "Slide about",4))
                {
                    case 'A': stupidity += 10; badbeep(); break;
                    case 'B': stupidity += 10; badbeep(); break;
                    case 'C': stupidity += 10; badbeep(); break;
                    case 'D': stupidity -= 10; goodbeep(); break;
                }

                Clear();
                WriteLine("Ameba life is slow");
                WriteLine("Ameba");
                return;
            }







    }
}
