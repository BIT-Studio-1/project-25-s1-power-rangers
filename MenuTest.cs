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

        static void WaitForKeyRelease()
        {
            // Clear ALL repeated enter/space inputs
            while (Console.KeyAvailable)
            {
                ConsoleKey k = Console.ReadKey(true).Key;

                if (k != ConsoleKey.Enter && k != ConsoleKey.Spacebar)
                    break;
            }
        }
        static bool acceptInput = true;

        static void controller(int opt)
        {
            CursorVisible = false;

            key = Console.ReadKey(true).Key;

            // ENTER / SPACE
            if (key == Enter || key == Spacebar)
            {
                // Ignore held confirm key
                if (!acceptInput)
                    return;

                acceptInput = false;

                if (option == 1) D1 = true;
                else if (option == 2) D2 = true;
                else if (option == 3) D3 = true;
                else if (option == 4) D4 = true;

                return;
            }

            // ANY OTHER KEY reenables input
            acceptInput = true;

            // Movement
            if ((key == DownArrow || key == S) && option < opt)
            {
                option++;
            }
            else if ((key == UpArrow || key == W) && option > 1)
            {
                option--;
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
            // Flush old buffered keys before menu starts
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            option = 1;
            D1 = D2 = D3 = D4 = false;
            //acceptInput = true;

            WriteLine("\nMove: Arrows  Select: Space/Enter");

            savedLeft = CursorLeft;
            savedTop = CursorTop;

            while (true)
            {
                Console.SetCursorPosition(savedLeft, savedTop);

                ResetColor();

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

                if (D1) return 'A';
                if (D2) return 'B';
                if (D3) return 'C';
                if (D4) return 'D';
            }
        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            debug();
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

        public static void debug()
        {
            int debug, go = 0;
            string temp;

            while (go == 0)
            {
                WriteLine("Debug menu\n1. Amoeba\n2. Plant\n3. Worm\n4. Fish\n5. Dolphin\n6. To proceed normally");
                temp = ReadLine();
                debug = Convert.ToInt32(temp);

                switch (debug)
                {
                    case 5:
                        dolphinlife();
                        break;

                    case 4:
                        fishLife();
                        break;

                    case 3:
                        wormlife();
                        break;

                    case 2:
                        plantLife();
                        break;

                    case 1:
                        amebaScene1();
                        break;

                    default:
                        go = 1;
                        break;

                }
            }





        }





    }
}
