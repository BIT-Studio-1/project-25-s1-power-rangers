using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeCode.Program;
using static CodeCode.SoundUtils;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
namespace CodeCode
{
    internal class Human
    {
        private static int SitOnCouch = 0;
        private static int Sure = 0;
        private static int Meow = 0;
        public static int SitOnCouch1
        {
            get { return SitOnCouch; }
        }

        public static int Sure1
        {
            get { return Sure; }
        }

        public static int Meow1
        {
            get { return Meow; }
        }
        public static void HumanLife()
        {
            CursorVisible = false;
            HumanLife1();
            HumanLife2();
            HumanTotal();
            return;

        }

        private static void humanWait(int time = 500)
        {
            CursorVisible = false;
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".\n");
            Thread.Sleep(time);
        }

        public static void HumanLife1()
        {
            CursorVisible = false;
            Clear();
            WriteLine("You are a homo sapien sapien"); ReadLine();
            WriteLine("A human who loves to sit on a couch"); ReadLine();
            Write("Would you like to name the human?"); humanWait(); Write("Nahhhh, you don't get a choice, your name is Hugh Mann. Hue for short"); ReadLine();
            Clear();
            WriteLine("your pet cat, Alfredo Chicken is looking at you"); ReadLine();
            Write("I think he's hungry"); ReadLine();
            WriteLine("Feed him?");
            Meow();
            switch (menu("Feed my son", "Don't feed em'", "meow back", "", 3))
            {
                case 'A':
                    Meow();
                    Meow += 5;
                    SitOnCouch += 2;
                    Write("Alfredo Chicken is calling for you"); humanWait(); Write("You must feed him"); ReadLine();
                    Write("You teleported to the kitchen couch and got Alfredo Chicken's favourite food, deluxe tuna from the pacific ocean that was caught yesterday");  humanWait();
                    Write("specifically for Alfredo Chicken, as your cat lives in luxury");
                    break;
                    Meow();
                case 'B':
                    Meow();
                    SitOnCouch += 3;
                    Meow -= 2;
                    Write("You think to yourself, your cat needs to learn how to survive the wilderness"); humanWait();
                    Write("so you teleport your cat to the porch couch");
                    break;
                case 'C':
                    HumanMeow();
                    Write("so you teleport your cat to the porch couch");


                    break;

            }
        }
        public static void HumanLife2()
        {
            Clear();
        }
        public static void HumanTotal()
        {
            CursorVisible = false;

            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Human Life"); Thread.Sleep(300);
            WriteLine($"How crazy you were: {SitOnCouch}" +
                $"\nHow Okay of a human you were: {Sure}" +
                $"\nHow good you were at being social: {Meow}"); ResetColor();
            SitOnCouch = SitOnCouch - Sure;

            if (SitOnCouch <= 0)
            {
            }
            if (SitOnCouch > 0)
            {
                if (SitOnCouch > 30)
                {
                }

                else
                {
                }
            } ReadLine();
            Clear();
        }
    }
}
