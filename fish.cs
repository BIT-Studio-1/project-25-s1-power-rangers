using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static CodeCode.Program;
using static CodeCode.SoundUtils;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
namespace CodeCode
{
    internal class fish
    {
        private static int selfishness = 20;
        private static int stupidity = 20;
        private static int bravery = 20;
        public static int Selfishness
        {
            get { return selfishness; }
        }

        public static int Stupidity
        {
            get { return stupidity; }
        }

        public static int Bravery
        {
            get { return bravery; }
        }
        public static void fishWait(int time = 500)
        {
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".\n");
            Thread.Sleep(time);
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
            Write("You have been reincarnated as a fish in a vast ocean of many pools and many schools (of fish)");
            fishWait();
            Write("You hatch as a fish, out of your egg"); fishWait();
            // WriteLine($" selfishness {selfishness}");
            Write("Your fish siblings are also hatched"); fishWait();
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
                    stupidity -= 2;
                    //Clear();


                    break;
                case 'B':
                    okaybeep();
                    Clear();
                    selfishness += 10;
                    stupidity -= 2;
                    WriteLine("A gluttonous action, but perhaps a justified one (you didn't like Serelipanilla anyways)");
                    break;
                default:
                    badbeep();
                    stupidity += 3;
                    selfishness += 2;
                    Clear();
                    Write("You break the laws of physics and burn the food underwater");
                    fishWait();
                    WriteLine($"Serelipanilla: \u001b[1m'dude wtf'\x1b[0m    (short for what the fish)");
                    break;
            }


            Write("You swim up to the surface");
            fishWait();
            WriteLine("You see the hook of a fisherman trying to fish");
            WriteLine("Do you give him a fish to feed him for a day or teach the man to fish to feed him for a lifetime");
            switch(menu("Give him a fish", "Teach him to fish", "Give him TO the fishes", "", 3))
            {
                case 'A':
                    Clear();
                    stupidity += 5;
                    selfishness -= 1;
                    Write("You give him a fish"); fishWait();
                    Write("The aforementioned fish was");
                    
                    Thread.Sleep(1200); Suspense2SFX();
                    Write(" \u001b[1mYOURSELF\u001b[0m");
                    fishWait(); Thread.Sleep(1200);

                    Write("After he catches you, he suddenly remembers that he is actually a vegan, so he releases you"); fishWait();


                    break;
                case 'B':
                    Clear();
                    bravery += 5;
                    stupidity -= 5;
                    Write("You teach him to fish"); fishWait();
                    WriteLine("To achieve this, you obviously perform a calculated jump onto his boat, precisely right into his ear");
                    Write("And then vibrate in morse code the instructions of how to fish"); fishWait();
                    Write("He is now armed with the instuctions of how to fish"); fishWait();
                    Write("The information won't be useful to him, as he suddenly remembers that he is actually a vegan"); fishWait();
                    break;

                default:
                    selfishness -= 2;
                    bravery += 2;
                    Clear();
                    WriteLine("You give him TO the fishes");
                    Write("You latch onto his hook and pull him into the water"); fishWait();
                    Write("He falls into the water"); fishWait();
                    Write("His body is seen by a fish school, shooting towards him their eyes widen in ravenous hunger"); fishWait();
                    Write("The fish devour him, leaving only the bones"); fishWait();
                    break;
                
            }

            return;

            }
        public static void fishScene2()
        {

            //WriteLine($" selfishness {selfishness}");
            WriteLine("");
            Write("You venture out into the open ocean in search of finding \nyour school, some food, or your fish Uncle \u001b[1mVishnu\u001b[0m");
            fishWait();
            WriteLine("Towards the east, you can smell some danger");
            WriteLine("Towards the west, you see some glimmers off into the distance");
            WriteLine("Towards the north, there is a dark area");
            WriteLine("Where do you go?");
            switch (menu(
                "Go east",
                "Go west",
                "Go north",
                "", 3)
                )
            {
                case 'A':
                    bravery += 5;
                    Clear();
                    Write("You smell some danger"); fishWait();

                    Write("It smells very dangerous"); fishWait();
                    WriteLine("But danger is your middle name"); Thread.Sleep(800);
                    Write("You swim towards the smell"); fishWait();

                    WriteLine("You see a damselfish getting chased by a dangerous eel");
                    WriteLine("What do you do?");
                    switch (menu(
                        "Mind your own business and hurry away\n\t(0% chance of death, 0% chance of success)",
                        "Attempt to save the damselfish by going inbetween the eel and the damselfish, distracting the eel\n\t(50% chance of death, 50% chance of success)",
                        "Attempt to save the damselfish by letting it swim behind you in your slipstream\n\t(50% chance of death, 50% chance of success)",
                        "Attempt to save the damselfish by throwing a nearby baby fish between the eel and the damselfish\n\t(0% chance of death, 100% chance of success)", 3)
                    )
                    {
                        case 'A':
                            Clear();
                            bravery -= 5;
                            stupidity -= 4;
                            selfishness += 3;
                            Write("You mind your own business and swim away"); fishWait();
                            break;
                        case 'B':
                            Clear();
                            bravery += 10;
                            selfishness -= 5;
                            Write("You attempt to save the damselfish by going inbetween the eel and the damselfish, distracting the eel");
                            fishWait();
                            if (deathRoll(50) == true)
                            {
                                Write("The eel devoured up you and the damselfish"); fishWait();
                                Write("You died a fishful life"); fishWait();
                                Write("Press enter to reincarnate to your next life");
                                ReadLine();
                                return;
                            }
                            Write("You successfully distract the eel away from the damselfish and escape");
                            fishWait();


                            break;
                        case 'C':
                            Clear();
                            bravery += 7;
                            selfishness -= 4;
                            Write("You attempt to save the damselfish by letting it swim behind you in your slipstream, distracting the eel");
                            fishWait();
                            if (deathRoll(50) == true)
                            {
                                Write("The eel devoured up you and the damselfish"); fishWait();
                                Write("You died a fishful life"); fishWait();
                                Write("Press enter to reincarnate to your next life");
                                ReadLine();
                                return;
                            }
                            Write("You successfully distract the eel away from the damselfish and escape");
                            fishWait();


                            break;
                        default:
                            Clear();
                            selfishness += 10;
                            Write("You attempt to save the damselfishby throwing a nearby baby fish between the eel and the damselfish"); fishWait();
                            Write("You successfully distract the eel away from the damselfish and escape");
                            fishWait();

                            break;
                    }

                    break;
                case 'B':
                    Clear();
                    // This one will just bring you below down to the next question (the uncle Vishnu one)

                    break;
                case 'C':
                    Clear();
                    Write("You swim into the darkness");
                    fishWait();
                    WriteLine("You see what you believe to be is a large opening");
                    menu("Go in", "Go in lol", "", "", 2);
                    break;
                default:
                    // This never gets triggered
                    break;


            }
            WriteLine("You found your school of fish! They weren't too far.");
            Write("You swim with your school for a while");
            fishWait();

            Write("Your fish uncle named Vishnu, who tended to you when you were a fish egg, is struggling with dementia and forgets which school of fish to belong to");
            fishWait();
            Write("The school you are swimming in is going towards some nutritious food");
            fishWait();
            WriteLine("After him being missing from the school for a few days you see him swimming with a dangerous rival school of fish and they haven’t noticed him yet.");
            Write("It's about to be spawning season, and you need to be nutritionally healthy to carry on a strong bloodline");
            fishWait();


            switch (menu("Keep going with your school to feed",
                "Swim up to Vishnu and guide him back to your school of fish",
                "Blend in with the rival school and wait until you and Vishnu are alone to save him (you might not come back to your school and be stranded)",
                "", 3))
                {
                case 'A':
                    Clear();
                    Write("You keep going with your school to feed"); fishWait(200);
                    Write("You never see Vishnu again"); fishWait(200);

                    break;
                case 'B':
                    Clear();
                    Write("You swim up to Vishnu and attempt to guide him back to your school of fish"); fishWait();
                    Write("The rival school attacks and they kill Vishnu in cold blood"); fishWait();
                    WriteLine("RIP Vishnu, fly high\n");

                    WriteLine(@"|╲__.-.");
                    WriteLine(@"|    x <  ");
                    WriteLine(@"|╱‾‾`'`");

                    break;

                default:
                    Clear();
                    Write("You blend in with the rival school and wait until you’re alone with Vishnu"); fishWait(200);
                    break;
                }


                return;

        }
    }
}
