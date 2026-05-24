using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CodeCode.SoundUtils;
using static CodeCode.MenuTest;
namespace CodeCode
{
    public class fish
    {
        private static int selfishness = 15;
        private static int stupidity = 15;
        private static int bravery = 0;

        public static void fishWait()
        {
            Thread.Sleep(500); Write(".");
            Thread.Sleep(500); Write(".");
            Thread.Sleep(500); Write(".\n");
            Thread.Sleep(500);
        }
        public static void fishLife()
        { 
            
            
            fishScene1();
            fishScene2();
            return;

        }
        public static void fishScene1()
        {
            Clear();


            Play(@"epicsfx.wav");
            //Play(Path.Combine(AppContext.BaseDirectory, "epicsfx.wav"));
            WriteLine("You have been reincarnated as a fish in a vast ocean of many pools and many schools (of fish)");
            WriteLine("You hatch as a fish egg");
            WriteLine($" selfishness {selfishness}");
            WriteLine("Your fish siblings are also hatched");
            WriteLine("You hatched later than your siblings and there isn't much food left in the hatchery and \nyour younger sister named Serelipanilla is very hungry, but guess what you are also very hungry");
            switch (menu("Leave the food for your younger sister",
                "Eat all her food",
                "Burn all the food",
                "", 3)
            )
            {
                case 'A':
                    Clear();
                    WriteLine("You left the food for Serelipanilla");
                    goodbeep();
                    selfishness -= 10;
                    bravery += 1;
                    //Clear();


                    break;
                case 'B':
                    okaybeep();
                    Clear();
                    selfishness += 10;
                    stupidity -= 1;
                    WriteLine("A gluttonous action, but perhaps a justified one (you didn't like Serelipanilla anyways)");
                    break;
                default:
                    badbeep();
                    stupidity += 3;
                    Clear();
                    WriteLine("You break the laws of physics and burn the food underwater");
                    WriteLine($"Serelipanilla: \u001b[1m'dude wtf'\x1b[0m    (short for what the fish)");
                    break;
            }


            Write("You swim up to the surface");
            fishWait();
            WriteLine("You see the hook of a fisherman trying to fish");
            WriteLine("Do you give him a fish to feed him for a day or teach the man to fish to feed him for a lifetime");
            switch(menu("Give him a fish (latch on to his hook)", "Teach him to fish", "Give him TO the fishes", "", 3))
            {
                case 'A':
                    Clear();
                    stupidity += 5;
                    WriteLine("You give him a fish");
                    break;
                case 'B':
                    Clear();
                    bravery += 5;
                    Write("You teach him to fish"); fishWait();
                    WriteLine("To achieve this, you obviously perform a calculated jump onto his boat, precisely right into his ear");
                    WriteLine("And then vibrate in morse code the instructions of how to fish");
                    Write("He is now armed with the instuctions of how to fish"); fishWait();
                    
                    break;

                default:
                    break;
            }



            }
            public static void fishScene2()
            {
                //WriteLine($" selfishness {selfishness}");
                WriteLine("");
                WriteLine("You venture out into the open ocean in search of finding \nyour school, some food, or your fish Uncle \u001b[1mVishnu\u001b[0m");
                WriteLine("Towards the east you can smell some blood (there may be some food in the form of remains)"); ;
                WriteLine("Towards the west, You see some glimmers off into the distance");
                WriteLine("Towards the north there is a dark area");
                WriteLine("Where do you go?");
                switch (menu(
                    "Go east",
                    "Go west",
                    "Go north",
                    "", 3
                    )
                    )
                {
                    case 'A':
                        bravery += 5;
                        WriteLine("");

                        WriteLine("");
                        break;
                    case 'B':
                        WriteLine("You found your school of fish!");
                        Write("You swim with your school");
                        fishWait();
                        break;
                    case 'C':
                        Clear();
                        Write("You swim into the darkness");
                        fishWait();
                        WriteLine("You see what you believe to be is a large opening");
                        menu("Go in", "Go in", "", "", 2);
                        break;
                    default:
                        break;


                }



        }
    }
}
