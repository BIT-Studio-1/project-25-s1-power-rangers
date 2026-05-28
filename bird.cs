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
        private static int variable = 20;
        private static int flyish = 20;
        private static int berd = 20;

        public static int Variable
        {
            get { return variable; }
        }

        public static int Flyish
        {
            get { return flyish; }
        }

        public static int Berd
        {
            get { return berd; }
        }
        public static void birdLife()
        {
            birdScene1();
        }
        public static void birdScene1()
        {
            WriteLine("You now have been reincarnated as a bird");
            menu("1", "2", "3", "4");
            if (D1 == true)
            {
                variable += 0;
                 flyish += 0;
                 berd += 0; 
            }
            if (D2 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;

            }
            if (D3 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D4 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            WriteLine("q2");
            menu("1", "2", "3","4");
            if (D1 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D2 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D3 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D4 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            WriteLine("q3");
            menu("1", "2", "3", "4");
            if (D1 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D2 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D3 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D4 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            WriteLine("q4");
            menu("1", "2", "3", "4");
            if (D1 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D2 == true)
            {   
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D3 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            if (D4 == true)
            {
                variable += 0;
                flyish += 0;
                berd += 0;
            }
            Write("your score now is ");
            WriteLine($"{variable}");
            WriteLine("");
            Write("your selfishness now is ");
            WriteLine($"{flyish}");
            WriteLine("");
            Write("your stupidity now is ");
            WriteLine($"{berd}");
            WriteLine("");
        }   

    }
}
