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
        private static int Worm = 0;
        public static int SitOnCouch1
        {
            get { return SitOnCouch; }
        }

        public static int Sure1
        {
            get { return Sure; }
        }

        public static int Worm1
        {
            get { return Worm; }
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
            WriteLine("You are a human"); ReadLine();
            WriteLine("A human who loves to sit on a couch"); ReadLine();
            WriteLine("Would you like to name the human?"); humanWait(); Write("Nahhhh, you don't get a choice, your name is Hugh Mann. Hue for short"); ReadLine();
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
                $"\nHow good you were at being social: {Worm}"); ResetColor();
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
