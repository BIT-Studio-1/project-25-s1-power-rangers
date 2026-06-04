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
    public class worm
    {
        

        public static bool fishGateway;
        private static int length = 8;
        private static int dirt_consumed = 0;
        private static int wiggles = 0;
        public static int Length
        {
            get { return length; }
        }

        public static int Dirt_consumed
        {
            get { return dirt_consumed; }
        }

        public static int Wiggles
        {
            get { return wiggles; }
        }


        public static void wormlife()
        {
            wormscene();
            wormtotal();
            return;
        }
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
            switch (menu("Swim to the surface", "hold your breath", "drink the water", "wiggle"))


            {
                case 'A':
                    WriteLine("You swim your way to the surface, you feel the rain drops falling against your long wormy body. your hear the sound of wings flapping overhead. ");
                    ReadLine();
                    wiggles += 10;
                    dirt_consumed += 5;
                    break;

                case 'B':
                    WriteLine("You grown gills.");
                    WriteLine("You.");
                    Thread.Sleep(700);
                    Clear();
                    WriteLine("Are.");
                    Thread.Sleep(700);
                    Clear();
                    WriteLine("A.");
                    Thread.Sleep(700);
                    Clear();
                    WriteLine("Fish...");
                    Thread.Sleep(700);
                    Clear();
                    fishGateway = true;
                    return;
                    break;

                case 'C':
                    WriteLine("You keep drinking and drinking and drinking and drinking until you're more of a balloon then a worm.");
                    Thread.Sleep(1000);
                    WriteLine("You can't hold in the liquid and rocket towards the surface, propelled by the water, flying all through the air, slamming into a bird");
                    Thread.Sleep(1000);
                    WriteLine("it seems all the water has stretched you out and increased your length.");
                    Thread.Sleep(1000);
                    ReadLine();
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
            Clear();
            WriteLine("After escaping that perilous situation, you are face to face with...");
            Thread.Sleep(2500);
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
                    Write("You manage to wiggle away into the ground without any conflict and live to wiggle another day");
                    wiggles += 5;
                    dirt_consumed +=5;
                    ReadLine();
                    break;


                case 'B':
                    if (length > op_len)
                    {
                        Write("you manage to wrap your body around your opponent and squeeze with all your might until... POP your opponent explodes.");
                        Thread.Sleep(1500);
                        
                        WriteLine("You consume your opponent");
                        length = length + op_len;
                        ReadLine();
                    }
                    else 
                    {
                        Write("You attempt to wrap around your opponent but they're longer and faster then you! they snake their way around you and POP... \nyou rip in half, your lenth reduced to 1.");
                        length = 1;
                        ReadLine();
                    }

                    
                    break;

                case 'C':
                    Write("Hey Hey Hey we can talk about this! you say to your opponent.");
                    Thread.Sleep(500);
                    Write("I HUNGER FOR WORM BLOOD!!!! replies your opponent.");
                    Thread.Sleep(1000);
                    Write("What will you say?");
                    switch (menu("A sob story", "Insult him", "Sneak attack", ""))
                    {
                        case 'A':
                            Write("You give the worm a sob story about how when you were younger, a bird swooped down and ate your worm parents\n and that youve been alone ever since...");
                            Thread.Sleep(1000);
                            Write("your opponent feels bad for you and lets you move on.");
                            ReadLine();
                            break;

                        case 'B':
                            Write("You say to your opponent: Looking small there!! wheres your  other half?\nThe worm replies, tears forming: My other half is my brother, we were siamese twins and he hated me so much that he cut himself off of me...");
                            Write("your opponent wiggles away in tears, dreaming of his long lost brother.");
                            ReadLine();
                            break;

                        default:
                            length = length + op_len;
                            Write("While your opponent is waiting for a reply you point and say WHATS OVER THERE??!!?!?!?!?\nhe turns around to see...");
                            Thread.Sleep(1000);
                            Clear();
                            Write("Absolutely nothing.\n you take this opportunity of confusion to sneak attack him, wrapping around him and tightening your grip until POP, he bursts.");
                            Write($"You eat the wormy remains in shame from the tactic you used against him.\n Your length increases by {op_len}. your total length is now {length}");
                            ReadLine();
                            break;
                    }
                    break;

                default:
                    CursorVisible = false;
                    Clear();
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
                    Write("You wiggle, hypnotyzing your opponent with the rythmic wiggles. he leaves you alone.\n wiggles + 5");
                    ReadLine();
                    wiggles += 5;
                    break;



            }
            Read();
            Write("after all that, you're inredibly hungry!");
            Thread.Sleep(2000);
            Clear();
            Write("dirtttttt");
            Write("How much dirt do you want to eat?");
            switch (menu("just a little bit of dirt", "a medium amount of dirt", "okay... thats alot of dirt-", "HOLY HOW DID YOU EAT THAT MUCH"))
            {
                case 'A':
                    dirt_consumed+=1;
                    Write("that wasnt much, you sure you dont want more?");
                    switch (menu("a little more couldnt hurt...", "no, im okay", "", ""))
                    {
                        case 'A':
                            Write("you eat a little more dirt");
                            goodbeep();
                            dirt_consumed+=1;
                            break;

                        default:
                            Write("you refuse to eat any more dirt.");
                            Read();
                            break;
                    }
                    break;

                case 'B':
                    dirt_consumed+=5;
                    Write("You eat a reasonable amount of dirt");
                    Read();
                    break;

                case 'C':
                    dirt_consumed+=10;
                    length+=10;
                    Write("you eat a questionable amount of dirt, it converts into length");
                    Read();
                    break;

                default:
                    dirt_consumed+=20;
                    Write("HOLYYYY... THATS ALOT OF DIRT");
                    Write("You start to resemble a fleshy coloured ping pong ball.");
                    Read();
                    break;

            }

            if (dirt_consumed >= 20)
            {
                Write("While sleeping off your dirt eating, you find a nice spot in the grass.\n just as you're starting to fall asleep, you see a large shape over you...");
                Thread.Sleep(2000);
                Clear();
                Write("\nthen it starts to come closer...");
                Thread.Sleep(2000);
                Clear();
                Write("\nIt's a foot!!");
                Thread.Sleep(2000);
                Clear();
                Write("\nThe very hairy foot, comes down hard on you like a hammer and theres nothing you can do as theres too much dirt in you to be able to move.\n it crushes you");
                Thread.Sleep(2000);
                Clear();
            }
            else
            {
                Write("You think to yourself: wow, i wish i ate more dirt, im really hungry and barely have the strenth to move.");
                Thread.Sleep(2000);
                Write("Just then, a bird swoops down and plucks you off of the ground and in one foul bite, you're gone...");
                Thread.Sleep(2000);
            }

            return;

        }
        
        public static void wormtotal()
        {
            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Worm Life"); Thread.Sleep(300);
            WriteLine($"how much dirt you ate: {dirt_consumed}" +
            $"\nHow long were you: {length}" +
            $"\nHow many times did you wiggle: {wiggles}"); ResetColor();
            Write("Press enter to reincarnate to your next life");
            ReadLine();
            return;
        }
    }
}