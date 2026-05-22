using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using static CodeCode.SoundUtils;
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
                //goodbeep();
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 2))
            {
                D2 = true;
                //goodbeep();
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 3))
            {
                D3 = true;
                //goodbeep();
                return;
            }
            else if ((key == Spacebar || key == Enter) && (option == 4))
            {
                D4 = true;
                //goodbeep();
                return;
            }


        }

        static char menu(string A, string B, string C, string D, int opt = 4) {
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

            return ' ';

        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WriteLine("Welcome to the game yo! €  wow look its the euro symbol ");

            room1();

            Write("advance to room 2");
           


            room2();

            plantScene1();

            fishScene1();
            wormlife();
            amebaScene1();
            dolphinlife1();
            Console.Write("Press enter to close program");
            Console.ReadLine(); // stops program exiting
        }

        static void room1()
        {
            
            
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
            Clear();
            int selfishness = 0;
            int stupidity = 0;
            int plant = 0;
            /*
            WriteLine("LEVEL 1");
            WriteLine("GAME OF HONEY");
            */
            WriteLine("I AM A SUNFLOWER IN THE VALLEYS OF DUNEDIN IN MR. 沃恩·马尔金'S GARDEN. I HAVE SPENT MOST OF MY LIFE LISTENING TO HIM ABOUT MAKING SQL DATABASES.");
            WriteLine(" ");
            WriteLine("IT IS NOW THE TIME TO DECIDE YOUR DESTINY: ");
            WriteLine(" ");
            WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎LEVEL 1");
            WriteLine(" ");

            WriteLine(" ");
            WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎GAME OF HONEY");
            WriteLine(" ");

            WriteLine(" ");
            menu("LET BEE EXTRACT HONEY", "KILL  THE BEE INSTEAD", "FIGHT BACK", "NONE OF THESE");

            if (D1 == true)
            {
                
                plant += 100;
                stupidity += 100;
                selfishness += 0;
                    
            }
            if (D2 == true)
            {

                plant += 10; 

             

                selfishness += 500;

                stupidity += 200;
            }
            if (D3 == true)
            {

                 plant += 200;
                 selfishness += 100;
                 stupidity += 50;
            }
            if (D4 == true)
            {
                 plant += 0;
                 selfishness += 100;
                 stupidity += 200;

                
            }
            if (D4 == true)
            {
                plant += 0;
                selfishness += 100;
                stupidity += 200;

            }



            Clear();
            WriteLine("LEVEL 2");
            WriteLine("USA VS VENEZUELA OIL EXTRACTION");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎LEVEL 2");
            WriteLine(" ");

            WriteLine(" ");
            WriteLine("‎‎‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎USA VS VENEZUELA OIL EXTRACTION");
            WriteLine(" ");

            WriteLine(" ");
            menu("KILL THE EXTRACTOR", "LET IT HAPPEN", "SUICIDE", "NONE OF THESE");
            if (D1 == true)
            {

                 selfishness += 0;

                stupidity += 0;
                plant += 0;
            }
            if (D2 == true)
            {

             selfishness += 0;
                 stupidity += 0;
                 plant += 0;
            }
            if (D3 == true)
            {
                 selfishness += 0;
                 stupidity += 0;
                 plant += 0;
            }
            if (D4 == true)
            {
                 selfishness += 0;
                 stupidity += 0;

              
                plant += 0;
            }
            if (D3 == true)
            {
                selfishness += 0;
                stupidity += 0;
                plant += 0;
            }
            if (D4 == true)
            {
                selfishness += 0;
                stupidity += 0;

                plant += 0;
            }

            Clear();
            WriteLine("LEVEL 3");
            WriteLine("DOG AND HIS POOP");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎LEVEL 3");
            WriteLine(" ");

            WriteLine(" ");
            WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎ ‎‎‎ ‎‎‎ ‎‎‎ ‎‎‎DOG AND HIS POOP");
            WriteLine(" ");

            WriteLine(" ");
            menu("LET HIM DO IT", "KILL HIM", "DO NOTHING", "SMILE AT HIM");
            if (D1 == true)
            {
                selfishness  += 0;

               

                stupidity += 0;
                plant += 0;

            }
            if (D2 == true)
            {
                selfishness += 0;
                stupidity += 0;
                plant += 0;

            }
            if (D3 == true)
            {

                 selfishness += 0;
                stupidity += 0;
                 plant += 0;

             


            }
            if (D4 == true)
            {

                 selfishness += 0;
                stupidity += 0;
                 plant += 0;
                 selfishness = 0;
                 stupidity = 0;
                 plant = 0;


           

            }
            Clear();
            WriteLine("DEATH LEVEL");
            WriteLine("GAME OF WINDS");

            menu("FIGHT BACK","HOLD YOUR ROOTS HARDER","DIE PEACEFULLY", "卧槽，这是什么鬼？是中文的？");
            WriteLine("so your stupidness being a plant is ", stupidity);
            WriteLine("so your selfishness being a plant is ", selfishness);
            WriteLine("so your global score after being a plant is", plant);

            ForegroundColor = ConsoleColor.Red;
            string Level4 = ("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎DEATH LEVEL");
            
            WriteLine(" ");

            WriteLine(" ");
            WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎GAME OF WINDS");
            WriteLine(" ");
            WriteLine(" ");

            menu("FIGHT BACK","HOLD YOUR ROOTS HARDER","DIE PEACEFULLY", "卧槽，这是什么鬼？是中文的？");
            WriteLine(" ");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("SO YOUR STUPIDNESS BEING A PLANT IS ", stupidity);
            WriteLine("SO YOUR SELFISHNESS BEING A PLANT IS ", selfishness);
            WriteLine("SO YOUR GLOBAL SCORE AFTER BEING A PLANT IS", plant);
            WriteLine(" ");
            WriteLine(" ");
            WriteLine("PLEASE PRESS ENTER TO CONTINUE");
            ReadLine();
           
            Console.ResetColor();

            return;
        }

        static void fishScene1()
        {
            Clear();
            int selfishness = 15;
            int stupidity = 15;
            int bravery = 0;
            Play(@"epicsfx.wav");
            //Play(Path.Combine(AppContext.BaseDirectory, "epicsfx.wav"));
            WriteLine("You have been reincarnated as a fish in a vast ocean of many pools and many schools (of fish)");
            WriteLine("You hatch as a fish egg");
            WriteLine("Your fish siblings are also hatched");
            WriteLine("You hatched later than your siblings and there isn't much food left in the hatchery and \nyour younger sister named Serelipanilla is very hungry, but guess what you are also very hungry");
            switch(menu("Leave the food for your younger sister", 
                "Eat all her food", 
                "Burn all the food", 
                "", 3)
            )
            {
                case 'A':
                    goodbeep();
                    selfishness -= 10;
                    bravery += 1;
                    //Clear();
                    
                    
                    break;
                case 'B':
                    okaybeep();
                    selfishness += 10;
                    stupidity -= 1;
                    WriteLine("A gluttonous action, but perhaps a justified one (you didn't like Serelipanilla anyways)");
                    break;
                default:
                    badbeep();
                    stupidity += 3;
                    WriteLine("You break the laws of physics and burn the food underwater");
                    WriteLine($"Serelipanilla: \u001b[1m'dude wtf'\x1b[0m    (short for what the fish)");
                    break;
            }
            WriteLine("You vernture out into the open ocean in search of finding \nyour school or some food");
            WriteLine("To the west, You see some glimmers off into the distance");
            WriteLine("Towards the east you can smell some blood (there may be some food in the form of remains)");
            WriteLine("Towards the north there is a dark area");
            WriteLine("Where do you go?");
            switch (menu(
                "Go west",
                "Go east",
                "Go north",
                "", 3
                )
                )
            {
                case 'A':
                    WriteLine("the uncle question");
                    WriteLine();
                    break;
                case 'B':

                    WriteLine("the brave one");
                    break;
                case 'C':
                    WriteLine("the cave one");
                    break;
                default:
                    break;
            }


            /*
            if (D1 == true)
            {
                selfishness -= 10;
                loyalty += 3;
            }
            else if (D2 == true)
            {
                selfishness += 10;
            }
            */


            Clear();


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


        static void dolphinlife1() 
        { 
            Clear();
            int AbusePoint = 0;
            int OkayEnough = 0;
            int WereAllInThisTogether = 0;

            WriteLine("You are a dolphin. \r\nA Delphinus Delphis to be exact, known as a common dolphin \r\n\r\nBeing a dolphin is pretty difficult."); ReadLine();
            WriteLine("But hey! At least you’re smart :) "); ReadLine();Clear();
            WriteLine("Whilst swimming around your normal route, you found a pufferfish close to some corals. What will you do?");
            switch (menu("Approach it", "Leave it alone","Tell your dolphin friends","",3)) 
            {
                case 'A':
                    AbusePoint += 5; okaybeep(); Clear();
                    WriteLine("You approach the pufferfish \r\n\r\n" +
                        "The pufferfish looks quite scared, " +
                        "which does make sense as the next action you take is to chew on the pufferfish."); Thread.Sleep(100);
                    WriteLine("You are successfully high");
                    break;
                case 'B':
                    OkayEnough += 10; goodbeep(); Clear(); 
                    WriteLine("No need to bother the little poisonous guy; we shall venture our route without fail, I dare say.");
                    break;
                case 'C':
                    AbusePoint += 10; badbeep(); Clear();
                    WereAllInThisTogether += 5;
                    WriteLine("You swim back to your buddies to tell them about your discovery, and they cheer.");Thread.Sleep(100);
                    WriteLine("When you get back to the pufferfish, you all take a hit"); Thread.Sleep(100);
                    WriteLine("You and your dolphin bruvs are successfully high");
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
