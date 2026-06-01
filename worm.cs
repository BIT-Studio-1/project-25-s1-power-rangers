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

        private static int length = 0;
        private static int dirt_consumed = 0;
        private static int wiggles = 0;

        public static void wormscene1()
        {
            //davids shitty ass code

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
                    WriteLine("");
                    break;

                case 'C':
                    WriteLine("You've drank so much ocean that you became one with it");
                    Clear();
                    WriteLine("you.");
                    Thread.Sleep(500);
                    Clear();
                    WriteLine("are.");
                    Thread.Sleep(500);
                    Clear();
                    WriteLine("a.");
                    Thread.Sleep(500);
                    Clear();
                    WriteLine("fish.");
                    Thread.Sleep(1000);
                    break;

                case 'D':
                    WriteLine("");
                    break;

            }


            return;
        }

    }
}