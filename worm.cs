using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CodeCode.Program;
using static CodeCode.SoundUtils;
using static System.Console;

namespace CodeCode
{
    internal class worm
    {
        public static void wormlife()
        {
            wormscene();
            wormtotal();
            return;
        }

        public static bool fishGateway;
        private static int length = 8;
        private static int dirt_consumed = 0;
        private static int wiggles = 0;

        public static void wormscene()
        {
            //davids shitty ass code
            fishGateway = false;
            Clear();
            WriteLine("**You are a worm now**");
            WriteLine("It's time to decide your destiny...");
            Read();
            Clear();
            WriteLine("You wake up, confused in the dark, feeling your long slender body wiggling through the dirt ");
            Read();
            Clear();
            Write("It beguins to rain, what will you do?");
            Read();
            Clear();
            switch (menu("Swim to the surface", "hold your breath", "drink the water", "wiggle"))


            {
                case 'A':
                    WriteLine("You swim your way to the surface, you feel the rain drops falling against your long wormy body. your hear the sound of wings flapping overhead. ");
                    wiggles += 10;
                    dirt_consumed += 10;
                    break;

                case 'B':
                    WriteLine("You grown gills.");
                    WriteLine("You.");
                    Thread.Sleep(500);
                    Clear();
                    WriteLine("Are.");
                    Thread.Sleep(500);
                    Clear();
                    WriteLine("A.");
                    Thread.Sleep(500);
                    Clear();
                    WriteLine("Fish...");
                    Thread.Sleep(500);
                    Clear();
                    return;
                    break;

                case 'C':
                    WriteLine("You keep drinking and drinking and drinking and drinking until you're more of a balloon then a worm.");
                    WriteLine("You can't hold in the liquid and rocket towards the surface, propelled by the water, flying all through the air, slamming into a bird");
                    WriteLine("it seems all the water has stretched you out and increased your length.");

                    length += 10;

                    break;

                default:
                    Clear();
                    bool wiggle = false;
                    WriteLine("wiggle.");
                    while (wiggle == false && wiggles <= 30)
                    {
                        switch (menu("wiggle?", "wiggle more?", "wiggle a little less", "stop wiggling"))
                        {
                            default:
                                Clear();
                                wiggle = true;
                                break;

                            case 'A':
                            case 'B':
                            case 'C':
                                CursorVisible = false;
                                Clear();
                                wiggles += 3;
                                WriteLine("\n\n\t\t");
                                Write(@"      \");
                                WriteLine("\t\t");
                                Write("      /");
                                Thread.Sleep(400);
                                Clear();
                                WriteLine("\n\n\t\t");
                                Write(@"      /");
                                WriteLine("\t\t");
                                Write(@"      \");
                                Thread.Sleep(400);
                                Clear();
                                WriteLine("\n\n\t\t");
                                Write(@"      \");
                                WriteLine("\t\t");
                                WriteLine("      /");
                                Thread.Sleep(400);
                                Clear();
                                WriteLine("\n\n\t\t");
                                Write("      /");
                                WriteLine("\t\t");
                                Write(@"      \");
                                Thread.Sleep(400);
                                Clear();
                                WriteLine("\n\n\t\t");
                                Write(@"      \");
                                WriteLine("\t\t");
                                WriteLine("      /");
                                Thread.Sleep(400);
                                Clear();
                                CursorVisible = true;

                                WriteLine("You have wiggled.");

                                break;

                        }

                    }
                    break;

            }

            WriteLine("After escaping that perilous situation, you are face to face with...");
            Thread.Sleep(500);
            Clear();
            WriteLine("Another worm!!!!");
            WriteLine("FIGHT ME. he declares");
            WriteLine("of course you know, in worm on worm combat, the winner will eat the loser and gain their length!");
            Random rand = new Random();
            int op_len = rand.Next(1,20);
            WriteLine($"Your current length is {length}, your opponent is {op_len}");
            switch (menu("wiggle away", "strangle your opponent", "talk it out", "wiggle"))


            {
                case 'A':
                    Write("You manage to wiggle away without any conflict and live to wiggle another day");
                    break;

                case 'B':
                    if (length > op_len)
                    {
                        Write("you manage to wrap your body around your opponent and squeeze with all your might until... POP your opponent explodes.");
                        Thread.Sleep(500);
                        Clear();
                        Write("You consume your opponent");
                        length = length + op_len;
                    }
                    else 
                    {
                        Write("You attempt to wrap around your opponent but they're longer and faster then you! they snake their way around you and POP... you rip in half, your lenth reduced to 1.");
                        length = 1;
                    }

                    
                    break;

                case 'C':
                    Write("Hey Hey Hey we can talk about this! you say to your opponent.");
                    Thread.Sleep(500);
                    Write("I HUNGER FOR WORM BLOOD!!!! replies your opponent.");
                    Write("What will you say?");
                    switch (menu("A sob story", "Insult him", "Sneak attack", ""))
                    {
                        case 'A':
                            Write("You give the worm a sob story about how when you were younger, a bird swooped down and ate your worm parents\n and that youve been alone ever since...");
                            Thread.Sleep(500);
                            Write("your opponent feels bad for you and lets you move on.");
                            break;

                        case 'B':
                            
                            break;

                        default:

                            break;
                    }
                    break;

                default:
                    Write("");
                    break;



            }
                    return;


        }
        
        public static void wormtotal()
        {
            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Worm Life"); Thread.Sleep(300);
            WriteLine($"how much dirt you ate: {dirt_consumed}" +
            $"\nHow long were you: {length}" +
            $"\nHow many times did you wiggle: {wiggles}"); ResetColor(); Write("Press enter to reincarnate to your next life");
            ReadLine();
            return;
        }
    }
}