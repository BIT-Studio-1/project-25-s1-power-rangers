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
    public class Sasquatch
    {
        private static int peacefulness = 20;
        private static int human = 20;
        private static int gay = 20;

        public static int Peacefulness
        {
            get { return peacefulness; }
        }
        public static int Human
        {
            get { return human; }
        }
        public static int Gay
        {
            get { return gay; }
        }
        public static void sasquatchLife()
        {
            sasquatchScene1();
            sasquatchTotal();
        }
        private static void wait(int time = 500) {
            CursorVisible = false;
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".\n");
            Thread.Sleep(time);
            CursorVisible = true;

        }
        public static void sasquatchScene1()
        {
            Write("You have been reincaranated as a sasquatch"); wait();
            WriteLine("omg");
            


        }
        public static void sasquatchTotal()
        {
            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Fish Life"); Thread.Sleep(300);
            WriteLine($"How peaceful you were: {peacefulness}" +
            $"\nHow humanistic you were: {human}" +
            $"\nHow gay you were: {gay}"); ResetColor(); Write("Press enter to reincarnate to your next life");
            ReadLine();
            return;
        }
    }
}
