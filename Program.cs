using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using static CodeCode.SoundUtils;
using static CodeCode.Fish;
using static System.Console;
using static System.ConsoleKey;
using static CodeCode.Starfish;
using static CodeCode.dolphin;
using static CodeCode.GameTitle;
using static CodeCode.plant;
using static CodeCode.bird;
using static CodeCode.Human;
using static CodeCode.Sasquatch;
using static CodeCode.worm;

namespace CodeCode
{
    public class Program
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
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 2))
            {
                D2 = true;
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 3))
            {
                D3 = true;
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 4))
            {
                D4 = true;
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
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


        public static char menu(string A, string B, string C, string D, int opt = 4)
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
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
                    CursorVisible = true;
                    return 'A';
                }
                else if (D2 == true)
                {
                    CursorVisible = true;
                    return 'B';
                }
                else if (D3 == true)
                {
                    CursorVisible = true;
                    return 'C';
                }
                else if (D4 == true)
                {
                    CursorVisible = true;
                    return 'D';
                }
            }
            // the line below never runs, as controller will always make one of the D bools true
            // it's just to fix an error that happens when the method finishes without returning anything
            CursorVisible = true;
            return ' ';

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            debug();
            TitleScreen();
            if (GameTitle.start1 == 1)
            { 
                amebaScene1();
                plantLife();
                // Plant needs an if statement for going to either fish or 
                wormlife();
                if(worm.fishgateway == true)
                {
                    fishLife();
                    if (Fish.Selfishness >= 25)
                    {
                        dolphinlife();
                        if (dolphin.OkayEnough1 >= 15)
                        {

                            Write("go next life\n");
                        }
                    }
                    else
                    {
                        starfishLife();
                    }
                }
                else
                {
                    //this is where the statements for going to sasquatch and penguin will be
                }
            }
            else if (GameTitle.end1 == 1)
            { return; }



            
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
        static void room2()
        { // also test room
            Clear();
            WriteLine("this is room 2 heres the words");
            menu("room 2 choice 1", "room 2 choice 2", "room 2 choice 3", "room 2 choice 4");

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

            switch (menu("Try to see", "try to smell", "Try to taste", "Slide about", 4))
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

        public static void debug()
        {
            int debug, go = 0;
            string temp;

            while (go == 0)
            {
                Write("1. Proceed normally\n2. Amoeba\n3. Plant\n4. Worm\n5. Fish\n6. Dolphin\n7. Starfish\n8. Bird\n9. Human\n10. Sasquatch\n: ");
                temp = ReadLine();
                // Handles invalid input
                if (int.TryParse(temp, out debug))
                {
                    switch (debug)
                    {
                        case 10:
                            sasquatchLife();
                            break;
                        case 9:
                            HumanLife();
                            break;
                        case 8:
                            birdLife();
                            break;
                        case 7:
                            starfishLife();
                            break;
                        case 6:
                            dolphinlife();
                            break;
                        case 5:
                            fishLife();
                            break;
                        case 4:
                            wormlife();
                            break;
                        case 3:
                            plantLife();
                            break;
                        case 2:
                            amebaScene1();
                            break;
                        
                        default:
                            go = 1;
                            break;
                    }
                }
                else {
                    Clear();
                    WriteLine("Invalid input, please enter a single digit number");
                }


            }


        }





    }
}
