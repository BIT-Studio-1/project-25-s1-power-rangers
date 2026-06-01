using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCode
{
    internal class worm
    {
        public static void wormlife()
        {
            wormscene1();
        }

        
        
        public static void wormscene1()
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
            controller();
            switch (menu("Swim to the surface", "hold your breath", "drink the water", "wiggle"))
            {
                1:
                    WriteLine("THE WORM BULLY");
                    WriteLine("It beguins to rain");
                    break;


            }

            return;
        }
    }

}
