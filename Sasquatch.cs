using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CodeCode.Program;
using static CodeCode.SoundUtils;
using static CodeCode.PSR;
namespace CodeCode
{
    public class Sasquatch
    {
        private static int peacefulness = 20;
        private static int human = 20;
        private static int nature = 20;

        public static int Peacefulness
        {
            get { return peacefulness; }
        }
        public static int Human
        {
            get { return human; }
        }
        public static int Nature
        {
            get { return nature; }
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
            Write("You have been reincaranated as a Sasquatch in the dense forests of the Appalachian mountains"); wait();
            Write("These mountains haven't changed in years, and you're a bit bored of them"); wait();
            Write("You have big dreams of climbing the ranks of corporate America, but you're a Sasquatch so it may be a little difficult"); wait();
            Write("As you can't speak English you may have to read the dictionary, though you don't have one on you"); wait();


            bool keepGoing = false;

            while (keepGoing == false) {
                WriteLine("You're in the mountains");
                WriteLine("To the \u001b[1meast\u001b[0m, you hear a river");
                WriteLine("To the \u001b[1mwest\u001b[0m, you see the fortnite battle bus");
                WriteLine("To the \u001b[1mnorth\u001b[0m, you see some snowy mountains");
                WriteLine("Which direction do you wish to go in?");
                switch (menu("Go \u001b[1meast\u001b[0m",
                    "Go \u001b[1mwest\u001b[0m",
                    "Go \u001b[1mnorth\u001b[0m",
                    "", 3))
                {
                    case 'A':
                        Clear();
                        Write("You go towards the flowing sounds of the river"); wait();
                        Write("There was"); wait(700); WriteLine(" a river"); wait();
                        
                        // To go to the corporate america city, you need to have read the dictionary
                        break;
                    case 'B':
                        Clear();
                        Write("The derelict battle bus sits alone in the forest"); wait();
                        switch (menu("Go inside", "Go back", "", "", 2))
                        {
                            case 'A':
                                WriteLine("There's a homeless guy in the battle bus");
                                WriteLine("");
                                WriteLine("");

                                switch(menu("Challenge him to a game paper scissors rock",
                                    "Give him a hug", 
                                    "Insult him", 
                                    ""))
                                {
                                    case 'A':
                                        Clear();
                                        Write("You make a paper-scissors-rock gesture and he nods very very enthusiastically"); wait();
                                        Write("He starts frowning when he realises that you mean you want to play paper scissors rock"); wait();
                                        Write("Homeless guy: 'Well okay then'");
                                        PSRgame();
                                        break;
                                    case 'B':
                                        Clear();
                                        break;
                                    case 'C':
                                        Clear();
                                        Write("Sasquatch: 'Yo mama Gaughrou goj herjub, jue paugh '"); Thread.Sleep(1000);
                                        Write("Homeless guy: 'AAAAAAAAAAAAAGHH HELP!!!'"); Thread.Sleep(1000);
                                        break;
                                    default:
                                        Clear();
                                        Write("Homeless guy: 'AAAAAAAAAAAAAGHH HELP!!!'"); Thread.Sleep(1000);
                                        break;
                                }
                                WriteLine();
                                break;

                            default:
                                WriteLine("");
                                break;
                        }

                        break;
                    default:
                        break;
                }

            }



        }
        public static void sasquatchScene2()
        {
            Write("You make it to Corporate America City"); wait();
            WriteLine("While walking on the street people ask to take photos with you as they");
            Write("think that you are dressed up as some sort of character"); wait();
        }
        public static void sasquatchTotal()
        {
            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Sasquatch Life"); Thread.Sleep(300);
            WriteLine($"How peaceful you were: {peacefulness}" +
            $"\nHow humanistic you were: {human}" +
            $"\nHow one with nature you were: {nature}"); ResetColor(); Write("Press enter to reincarnate to your next life");
            ReadLine();
            return;
        }
    }
}
