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
            variable = 20;
            flyish = 20;
            berd = 20;
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
            Write("You now have been reincarnated as a "); wait();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("BIRD"); Thread.Sleep(1000);
            ResetColor();
            WriteLine(" ");
            Write("So now that you're bird, What do you think you can do?"); wait();
            WriteLine(" ");
            Write("Fly bro, what else?"); wait();
            WriteLine("\n");
            WriteLine("CHIR CHIR CHIR");
            WriteLine(" ");
            ForegroundColor = ConsoleColor.DarkGreen;
            Write("OKAY YOURE THIRSTY NOW andddddddddddd........ Your lover bird is thirsty too"); wait();
            Write("Oh a pot is there, go fly and try drinking from it"); wait();
            WriteLine("Yeah I know the water level is to low, Thus here are some options what about what you can do");
            switch (menu("Fill it with rocks so the water level rises, Smart hah?", "Find a straw nearby, Generational aura thing :( ", "Don't attempt drinking it, But you're thirsty bro", "Start yapping, Yapping birdyyy"))
            {
                case 'A':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    Write("That's a cool thing do to bud"); wait();
                    variable += 3;
                    flyish -= 2;
                    berd += 5;
                    break;
                case 'B':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    Write("You're smart bird, but nah why do you think you will find a straw nearby huh? "); wait();
                    variable += 3;
                    flyish += 3;
                    berd += 2;
                    break;
                case 'C':
                    goodbeep();
                    Clear();
                    HellYeah();
                    ForegroundColor = ConsoleColor.Blue;
                    Write("Yeah that wasn't very wise but here we go again"); wait();
                    variable += 1;
                    flyish += 5;
                    berd -= 2;
                    break;
                case 'D':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    HellYeah();
                    Write("Yeah yapper, You're more thirsty now. Cope with it"); wait();
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
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Holy moly are you heart broke");
            Write("In Texan accent BTW"); wait();
            WriteLine(" ");
            Write("So what you gonna do now?"); wait();
            ResetColor();
            ForegroundColor = ConsoleColor.DarkGray;
            Write("Please be a little smart");

            switch (menu("Making a nest for her, could be smart move ", "Giving her the water, coz she was thirsty ", "Yelling at her, not smart move BTW ", "Do nothing and fly away"))
            {
                case 'A':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    Suspense2SFX();
                    Write("Oh that was a smart move, She did patch up with you"); wait();
                    variable -= 3;
                    flyish -= 2;
                    berd += 5;
                    break;
                case 'B':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    DramaSFX();
                    Write("That was a smart thinking but you failed to find water, So she flew away from you"); wait();
                    variable += 0;
                    flyish += 0;
                    berd += 5;
                    break;
                case 'C':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    eagleSFX();
                    Write("That wasn't smart move, You loved her bro"); wait();
                    variable += 3;
                    flyish += 4;
                    berd -= 2;
                    break;
                case 'D':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    Suspense2SFX();
                    Write("You loved her bro, You broke her heart birdyy"); wait();
                    variable += 5;
                    flyish += 5;
                    berd += 5;
                    break;
            }
            Clear();
            ResetColor();
            Write("Look whats up there"); wait();
            WriteLine(" ");
            Write("Is that a bird"); wait();
            SuspenseSFX();
            ForegroundColor = ConsoleColor.DarkRed;
            Write("NO.........."); wait();
            DramaSFX();
            ResetColor();
            ForegroundColor = ConsoleColor.Magenta;
            Write("kleek kik ik ik ik"); wait();
            eagleSFX();
            Write("That's an eagle"); wait();
            WriteLine(" ");
            Write("Your loving bird is scared"); wait();
            WriteLine(" ");
            WriteLine("Lets see what you got in here");
            switch (menu("Fight the eagle... not a smart move", "Fly away, Could save your life", "Save your lover bird, That's what a man would do", "Do not do anything, Sit there and be a coward "))
            {
                case 'A':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    Write("You tried really hard"); wait();
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
                    Write("Glad you saved her bro, You guys have patched up now"); wait();
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
            ResetColor();
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            Write("Wait is that a cute humming bird"); wait();
            DramaSFX();
            WriteLine(" ");
            Write("Wait is that coming towards you??????????");
            WriteLine(" ");
            EpicSFX();
            WriteLine("Does she like you?????");
            eagleSFX();
            ForegroundColor = ConsoleColor.DarkMagenta;
            Write("Ohh yeahh she likes you"); wait();
            WriteLine("What you gonna do now bro?");
            Suspense2SFX();
            switch (menu("Try approaching her, shes cute bro", "Let her approach you, you are such a sigma bro", "Pass her and fly away, not a wise move BTW", "Pretend to be a pigeon, I mean pigeon"))

            {
                case 'A':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    eagleSFX();
                    Write("You so fool, it was a eagle and you got killed"); wait();
                    variable += 3;
                    flyish += 2;
                    berd += 0;
                    break;

                case 'B':
                    DramaSFX();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    eagleSFX();
                    Write("You so fool, it was a eagle and you got killed"); wait();
                    variable += 2;
                    flyish += 2;
                    berd += 0;
                    break;
                case 'C':
                    DramaSFX();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    eagleSFX();
                    Write("You so fool, it was a eagle and you got killed"); wait();
                    variable += 3;
                    flyish += 3;
                    berd += 0;
                    break;
                case 'D':
                    Suspense2SFX();
                    Clear();
                    ForegroundColor = ConsoleColor.Blue;
                    eagleSFX();
                    Write("You so fool, it was a eagle and you got killed"); wait();
                    variable += 3;
                    flyish += 3;
                    berd += 0;
                    break;
            }
            Clear();
            BirdTotal();
        }
        public static void BirdTotal()
        {
            globalScore = berd + variable - flyish;
            ForegroundColor = ConsoleColor.Blue;
            Write("Your Stupidity is " + variable); wait();
            WriteLine(" ");
            Write("Your Selfishness is " + flyish); wait();
            WriteLine(" ");
            Write("Your Birdness is " + berd); wait();
            ResetColor();
            WriteLine(" ");
            WriteLine(" ");
            WriteLine("Press enter to continue"); ReadLine();
        }

    }
}
