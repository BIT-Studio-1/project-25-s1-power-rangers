using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics.CodeAnalysis;
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
            ForegroundColor = ConsoleColor.Red;
            
            int selfishness = 0;
            int stupidity = 0;
            int plant = 0;
            WriteLine("I AM A SUNFLOWER IN THE VALLEYS OF DUNEDIN IN MR. 沃恩·马尔金'S GARDEN. I HAVE SPENT MOST OF MY LIFE LISTENING TO HIM ABOUT MAKING SQL DATABASES.");
            WriteLine(" ");
            WriteLine("IT IS NOW THE TIME TO DECIDE YOUR DESTINY: ");
            WriteLine(" ");
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
            ForegroundColor = ConsoleColor.Red;
            WriteLine("LEVEL 2");
            WriteLine("USA VS VENEZUELA OIL EXTRACTION");
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
            ForegroundColor = ConsoleColor.Red;
            WriteLine("LEVEL 3");
            WriteLine("DOG AND HIS POOP");
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

<<<<<<< HEAD
                 selfishness = 0;
                 stupidity = 0;
                 plant = 0;
=======
                 selfishness += 0;
                stupidity += 0;
                 plant += 0;
>>>>>>> 80261e58ffa5b6ca76a2c5c1f410a4754b508064

           

            }
            Clear();
            ForegroundColor = ConsoleColor.Red;
            WriteLine("DEATH LEVEL");
            WriteLine("GAME OF WINDS");

            menu("FIGHT BACK","HOLD YOUR ROOTS HARDER","DIE PEACEFULLY", "卧槽，这是什么鬼？是中文的？");
            WriteLine("so your stupidness being a plant is ", stupidity);
            WriteLine("so your selfishness being a plant is ", selfishness);
            WriteLine("so your global score after being a plant is", plant);
            Console.ResetColor();

            return;
        }

        static void fishScene1()
        {
            Clear();
            int selfishness = 20;
            int stupidity = 0;
            int bravery = 0;
            Play(@"epicsfx.wav");
            //Play(Path.Combine(AppContext.BaseDirectory, "epicsfx.wav"));
            WriteLine("You have been reincarnated as a fish in a vast ocean of many pools and many schools (of fish)");
            WriteLine("You hatch as a fish egg");
            WriteLine("Your fish siblings are also hatched");
            WriteLine("You hatched later than your siblings and there isn't much food left in the hatchery and your younger sister named Serelipanilla is very hungry, but guess what you are also very hungry");
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
                    Clear();
                    WriteLine("You break the laws of physics and burn the food underwater");
                    WriteLine("You vernture out into the open ocean in search of finding \ryour school or some food");
                    WriteLine("To the west, You see some glimmers off into the distance");
                    WriteLine("Towards the east you can smell some blood,  it could mean food \ras you can eat remains of other fish");
                    WriteLine("Towards the north you can see one a cave");

                    switch(menu(
                        "Go west",
                        "Go east", 
                        "Go north", 
                        "", 3
                        )
                        )
                    {
                        case 'A':
                            WriteLine("The distant glimmers");
                            break;
                        case 'B':
                            WriteLine("hgewio");
                            break;
                        case 'C':
                            WriteLine("hgewio");
                            break;
                        default:
                            break;
                    }
                    break;
                case 'B':
                    okaybeep();
                    selfishness += 10;
                    break;
                default:
                    badbeep();
                    stupidity += 3;
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



        static void dolphinlife1() 
        { 
            Clear();
            
            WriteLine("You are a dolphin. \r\nA Delphinus Delphis to be exact, known as a common dolphin \r\n\r\nBeing a dolphin is pretty difficult.  ");
            Clear();

        }


        

    }
}
