//This *VERY* top section just saves a bit of time writing code.
using static System.Console;
using static System.ConsoleKey;

namespace Menu_System
{
   
    internal class Program
    {
        //This Top section is used outside of all of the voids!
        //We must place this section just under the "internal class Program"
        //This section defines the GLOBAL VARIABLES.

        static int option = 1, scene = 1, globalScore = 0;
        static ConsoleKey key;
        static string? A, B, C, D;
        static bool D1, D2, D3, D4;
        
        //Below is the static void "Main" which is the default.
        //Each actual "Menu"/Room/Scene is actually contained within it's own unique void and then called to main.
        //For this example we will call "exampleroom1" from it's home to the main void, essentially begining the game.

        static void Main(string[] args)
        {
            CursorVisible = false;
            WriteLine("Press any key to start");
            ReadLine();
            //The first room called in main will define the "spawn point" 
            exampleRoom1();
            
         
        }


        //This is where our example rooms unique void or home is.
        //Each "ROOM" or "Scene" in our game can be created as a seperate void just like this example one below
        
        static void exampleRoom1()
        {
                while (true)
                {

                // Insert text to display as strings of text indicating the player has a choice to make.
                // Each option must be a string in double quotes and assigned to a letter from A to D.
                // "A", "B", "C" and "D" are global variables used to assign text to a menu option. 
                // "D1", "D2", "D3" and "D4" are also globally defined variables that control actually making a decision
                // The desicion variables must be reset to false at the top of each room as shown below
                
                D1 = false; D2 = false; D3 = false; D4 = false;
                A = "Hello"; B = "Goodbye"; C = "Wow Look!"; D = "Woopsie Daisy!";


                // This is where we draw the "room/scene" of the game for this "menu" to spawn below.
                // We must make sure that we are drawing below our console "Clear" command!
                
                Clear();
                WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~EXAMPLE ROOM ONE~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                WriteLine(" | *     *      ____              o                               |");
                WriteLine(" |    *        |^uu^|3                                    o       |");
                WriteLine(" |            |0--0|2'''''''4                  o                  |");
                WriteLine(" |             l9--4j                o                            |");
                WriteLine(" | mmm   nmn        mnm   nm    nnnn    mn n  m    n mmm n m  n   |");
                WriteLine("###################################################################");
                
                
                //The below 'if' statements define the number of options the players has to choose from.
                //This example/template is giving the player 4 different options.
                //We use one 'if' statement for the initial option and then an 'else if' statement for each additional option.
                //This section needs to be below the drawing of the room section shown above

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

                //This assigns the global variable "key" to the key we are currently pressing on the keyboard
                //This section needs to be called below the scene and menu drawing sections shown above 
                //**Always use this line for every room**
                key = ReadKey(true).Key;
                
                //This line calls the "controler" void which defines the games "controls"
                //**Always use this line for every room**
                controler();
                
                //Below the controler call line we can define which 'next room' each decision leads to
                if (D1 == true)
                {
                    exampleroom2();
                }

                //The entire room is contained within a 'while true' loop which must be closed off here 
                }
         //The void itself that is uniquely containing this room is closed off here   
        }


        //Boom! Yay! The next room just begins below all tidy and happy in it's own "void" 
        static void exampleroom2()
        {
                while (true)
                {
                D1 = false; D2 = false; D3 = false; D4 = false;
                A = "Hello"; B = "Goodbye"; C = "Wow Look!"; D = "Woopsie Daisy!";

                Clear();
                WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~EXAMPLE ROOM TWO~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                WriteLine(" | *     *      ____              o                               |");
                WriteLine(" |    *        |^uu^|3                                    o       |");
                WriteLine(" |            |0--0|2'''''''4                  o                  |");
                WriteLine(" |             l9--4j                o                            |");
                WriteLine(" | mmm   nmn        mnm   nm    nnnn    mn n  m    n mmm n m  n   |");
                WriteLine("###################################################################");

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
                key = ReadKey(true).Key;

                controler();

                if (D2 == true)
                {
                    exampleRoom1();
                }
            }
        }


        


        static void controler()
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
    }
}
