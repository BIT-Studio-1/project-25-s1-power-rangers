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
        private static int AbusePoint = 0;
        private static int OkayEnough = 0;
        private static int WereAllInThisTogether = 0;
        public static int AbusePoint1
        {
            get { return AbusePoint; }
        }

        public static int OkayEnough1
        {
            get { return OkayEnough; }
        }

        public static int WereAllInThisTogether1
        {
            get { return WereAllInThisTogether; }
        }
        public static void HumanLife()
        {
            CursorVisible = false;
            HumanLife1();
            HumanLife2();
            HumanTotal();
            return;

        }


        public static void HumanLife1()
        {
            Clear();
            WriteLine("You are a human"); ReadLine();
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
            WriteLine($"How crazy you were: {AbusePoint}" +
                $"\nHow Okay of a human you were: {OkayEnough}" +
                $"\nHow good you were at being social: {WereAllInThisTogether}"); ResetColor();
            AbusePoint = AbusePoint - OkayEnough;

            if (AbusePoint <= 0)
            {
            }
            if (AbusePoint > 0)
            {
                if (AbusePoint > 30)
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
