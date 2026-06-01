using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CodeCode.Program;
using static CodeCode.SoundUtils;

namespace CodeCode
{
    internal class worm
    {
        public static void wormlife()
        {
            wormscene1();

            return;
        }

        public static bool fishgateway;
        private static int length = 0;
        private static int dirt_consumed = 0;
        private static int wiggles = 0;

        public static void wormscene1()
        {
            //davids shitty ass code
            fishgateway = false;
            Clear();
            WriteLine("**You are a worm now**");
            WriteLine("It's time to decide your destiny...");
            Clear();
            WriteLine("You wake up, confused in the dark, feeling your long slender body wiggling through the dirt ");
            Clear();
            WriteLine("LEVEL 1");
            WriteLine("It beguins to rain, what will you do?");
            switch (menu("Swim to the surface", "hold your breath", "drink the water", "wiggle"))


            {
                case 'A':
                    WriteLine("You swim your way to the surface, you feel the rain drops falling against your long wormy body. your hear the sound of wings flapping overhead. ");
                    wiggles += 10;
                    dirt_consumed += 10;
                    break;

                case 'B':
                    WriteLine("you drown.");
                    break;

                case 'C':
                    WriteLine("You keep drinking and drinking and drinking and drinking until you're more of a balloon then a worm.");
                    WriteLine("You can't hold in the liquid and rocket towards the surface, propelled by the water, flying all through the air, slamming into a bird");
                    WriteLine("it seems all the water has stretched you out and increased your length.");
                    length += 10;

                    break;

                default:
                    bool wiggle = false;
                    WriteLine("wiggle.");
                    while (wiggle = false) 
                    {
                        switch (menu("wiggle?", "wiggle more?", "wiggle a little less", "stop wiggling"))
                        {
                            default:
                                wiggle = true;
                                break;

                            case 'A':
                            case 'B':
                            case 'C':

                                wiggles += 3;
                                wiggle = false;
                                break;

                        }
                            
                    }
                    break;

            }


            return;
        }

    }
}