using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CodeCode.Program;
using static CodeCode.SoundUtils;

namespace CodeCode
{
    public class bird
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
        public static void birdLife()
        {
            birdScene1();
        } 
        public static void birdScene1()
        {
            WriteLine("You now have been recarnated to a bird");
        
        }

    }
}
