using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
        private static void wait(int time = 500)
        {
            CursorVisible = false;
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".\n");
            Thread.Sleep(time);
            CursorVisible = true;

        }
        public static void birdScene1()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            Write("You now have been reincarnated as a ");  wait();
            WriteLine("BIRD"); Thread.Sleep(1000);
            WriteLine(" ");
            WriteLine("So now that you're bird, What do you think you can do?"); wait();
            WriteLine(" ");
            Write("Fly bro, what else?");  wait();
            WriteLine("\n");
            WriteLine("CHIR CHIR CHIR");
            WriteLine(" ");
            Write("OKAY YOURE THIRSTY NOW andddddddddddd........ your lover bird is thirsty too");  wait();
            WriteLine("Oh a pot is there, go fly and try drinking from it"); wait();
            WriteLine("Yeah i know the water level is to low, Thus here are some options what about what you can do");

            switch (menu("fill it with rocks so the water level rises, smart hah?", "Find a straw nearby, Generational aura thing :( ", "Don't attempt drinking it, But you're thirsty bro", "Start yapping, Yapping birdyyy"))
            {
                case 'A':
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("That's a cool thing do to bud"); Thread.Sleep(2000);
                variable += 3;
                flyish -= 2;
                berd += 5;
                break;
                case 'B':
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("You're smart bird, but nah why do you think you will find a straw nearby huh? "); Thread.Sleep(2000);
                variable += 3;
                flyish += 3;
                berd += 2;
                    break;
                case 'C':
                goodbeep();
                Clear();
                HellYeah();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("Yeah that wasn't very wise but here we go again"); Thread.Sleep(2000);
                variable += 1;
                flyish += 5;
                berd -= 2;
                    break;
                case 'D':
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                HellYeah();
                WriteLine("Yeah yapper, You're more thirsty now. cope with it"); Thread.Sleep(2000);
                variable += 5;
                flyish += 5;
                berd -= 2;
                    break;
            }
        
            Clear();
            Write("So because of the choices you made before"); wait(1400);
            WriteLine(" ");
            Write("Your lover bird"); wait();
            Write("Just broke up with you"); wait();
            WriteLine(" ");
            WriteLine("Holy moly are you heart broke");
            Write("In Texan accent BTW"); wait();
            WriteLine(" ");
            Write("So what you gonna do now?"); wait();
            Write("Please be a little smart");

            switch (menu("Making a nest for her, could be smart move ", "Giving her the water, coz she was thirsty ", "Yelling at her, not smart move BTW ","Do nothing and fly away"))
            {
                case 'A':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    Suspense2SFX();
                    WriteLine("Oh that was a smart move, She did patch up with you"); Thread.Sleep(2000);
                    variable -= 3;
                    flyish -= 2;
                    berd += 5;
                    break;
                case 'B':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    DramaSFX();
                    WriteLine("That was a smart thinking but you failed to find water, So she flew away from you"); Thread.Sleep(1000);
                    variable += 0;
                    flyish += 0;
                    berd += 5;
                    break;
                case 'C':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    eagleSFX();
                    WriteLine("That wasn't smart move, You loved her bro"); Thread.Sleep(2000);
                    variable += 3;
                    flyish += 4;
                    berd -= 2;
                    break;
                case 'D':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    Suspense2SFX();
                    WriteLine("You loved her bro, You broke her heart birdyy"); Thread.Sleep(2000);
                    variable += 5;
                    flyish += 5;
                    berd += 5;
                    break;
            }
            Clear();
            Write("Look whats up there"); wait();
            WriteLine(" ");
            Write("Is that a bird"); wait();
            SuspenseSFX();
            Write("NO.........."); wait();
            DramaSFX();
            Write("kleek kik ik ik ik"); wait();
            eagleSFX();
            Write("That's an eagle"); wait();
            WriteLine(" ");
            Write("Your loving bird is scared"); wait();
            WriteLine(" ");
            WriteLine("Lets see what you got in here");


           switch( menu("Fight the eagle... not a smart move", "Fly away, Could save your life", "Save your lover bird, That's what a man would do", "Do not do anything, Sit there and be a coward "))
            {


                case 'A':
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                Write("You tried really hard... "); wait();
                eagleSFX();
                Write("You killed the eagle"); wait();
                variable -= 2;
                flyish -= 2;
                berd += 5;
                    break;

                case 'B':
            
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                Write("That was really a coward move, It has killed your lover"); wait();
                SuspenseSFX();


                variable += 3;
                flyish += 3;
                berd -= 1;
                    break;
                case 'C':
                DramaSFX();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                Write("Glad you saved her bro, You guys have patched up now");
                variable += 1;
                flyish += 1;
                berd += 3;
                    break;
                case 'D':
                eagleSFX();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                Write("Ohhh gawddddd."); wait();
              Suspense2SFX();
                Write("It has killed your lover bird");

                variable += 3;
                flyish += 3;
                berd -= 2;
                    break;
            }
            Clear();
            Write("Wait is that a cute humming bird"); wait();
            DramaSFX();
            WriteLine(" ");
            Write("Wait is that coming towards you?????????????????"); wait();
            WriteLine(" ");
            EpicSFX();
            Write("Does she likes you?????"); wait();
            eagleSFX();
            Write("Ohh yeahh she likes you"); wait () ;
            WriteLine("What you gonna do now bro? "); wait ();
            Suspense2SFX ();
            switch (menu("Try approaching her, shes cute bro", "Let her approach you, you are such a sigma bro", "Pass her and fly away, not a wise move BTW", "Pretend to be a pigeon, i mean pigeon"))
          
            {
                case 'A':
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                eagleSFX ();
                Write("You so fool, it was a eagle and you got killed");
                variable += 3;
                flyish += 2;
                berd += 0;
                    break;

                case 'B':
               DramaSFX ();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                eagleSFX();
                Write("You so fool, it was a eagle and you got killed");

                variable += 2;
                flyish += 2;
                berd += 0;
                    break;
                case 'C':
                DramaSFX();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                eagleSFX();
                Write("You so fool, it was a eagle and you got killed");
                variable += 3;
                flyish += 3;
                berd += 0;
                    break;
                case 'D':
                Suspense2SFX();
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                eagleSFX();
                Write("You so fool, it was a eagle and you got killed");
                variable += 3;
                flyish += 3;
                berd += 0;
                    break;
            }
            Clear();
            BIRDTOTAL();
        }   
        public static void BIRDTOTAL()
        {
            globalScore = berd + variable - flyish;
            ForegroundColor = ConsoleColor.Blue;
            Write("Your stupidity is ");
            WriteLine($"{variable}");
            WriteLine(" ");
            Write("Your selfishness is ");
            WriteLine($"{flyish}");
            WriteLine(" ");
            Write("Your score is ");
            WriteLine($"{berd}");
            WriteLine("(Press enter to continue)"); ReadLine();
        }

    }
}
