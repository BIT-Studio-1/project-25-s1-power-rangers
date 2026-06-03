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
            ForegroundColor = ConsoleColor.Blue;
            Write("You now have been reincarnated as a "); Thread.Sleep(1000);
            WriteLine("bird"); Thread.Sleep(1000);
            WriteLine(" ");
            WriteLine("so now that youre bird, what do you think you can do?"); Thread.Sleep(3000);
            WriteLine(" ");
            WriteLine(" Fly bro, what else?"); Thread.Sleep(500);
            WriteLine("\n");
            WriteLine("chir chir chir");
            WriteLine(" ");
            WriteLine("OKAY YOURE THIRSTY NOW andddddddddddd........ your lover bird is thirsty tooo"); Thread.Sleep(500);
            WriteLine("oh a pot is there, go fly and try drinking from it"); Thread.Sleep(500);
            WriteLine("\n");
            WriteLine("yeah i know the water level is to low, thus here are some options what about what you can do");

            menu("fill it with rocks so the water level rises, smart hah?", "find a straw nearby, generational aura thing :( ", "dont attempt drinking it, but youre thirsty bro", "start yapping, yapping birdyyy");
            if (D1 == true)
            {
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("ahan thats a cool thing do to bud"); Thread.Sleep(2000);
                variable += 3;
                 flyish -= 2;
                 berd += 5; 
            }
            if (D2 == true)
            {
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("youre smart bird, but nah why do you think you will find a straw nearby huh? "); Thread.Sleep(2000);
                variable += 3;
                flyish += 3;
                berd += 2;

            }
            if (D3 == true)
            {
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("yeah that wasnt very wise but here we go again"); Thread.Sleep(2000);
                variable += 1;
                flyish += 5;
                berd -= 2;
            }
            if (D4 == true)
            { 
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine(" yeah yapper, youre more thirsty now. cope with it"); Thread.Sleep(2000);
                variable += 5;
                flyish += 5;
                berd -=2 ;
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
