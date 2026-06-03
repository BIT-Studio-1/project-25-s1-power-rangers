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
        private static int charisma = 20;

        public static int Peacefulness
        {
            get { return peacefulness; }
        }
        public static int Human
        {
            get { return human; }
        }
        public static int Charisma
        {
            get { return charisma; }
        }
        public static void sasquatchLife()
        {
            Clear();
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
            //PSRgame();
            Write("You have been reincaranated as a Sasquatch in the dense forests of the Appalachian mountains"); wait();
            Write("These mountains haven't changed in years, and you're a bit bored of them"); wait();
            Write("You have big dreams of climbing the ranks of corporate America, but you're a Sasquatch so it may be a little difficult"); wait();
            Write("As you can't speak English you may have to read the dictionary, though you don't have one on you"); wait();

            bool dictionaryRead = false;
            bool leaveBus = false;
            bool keepGoing = false;
            bool won = false;

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
                        Write("There was"); wait(700); Write("a river"); wait();
                        WriteLine("Follow the river?");
                        switch(menu("Follow the river", "Go back", "", "", 2))
                        {
                            case 'A':
                                Write("Not far away from you, you see the vast land of Corporate America City"); wait();
                                Write("In Corporate America City, people only speak english so you need to have read the dictionary"); wait();

                                if (dictionaryRead == true)
                                {

                                    keepGoing = true;
                                }
                                else
                                {
                                    Write("Try exploring around more to find it"); wait();
                                }
                                    break;
                            default:
                                break;
                        }

                        // To go to the corporate america city, you need to have read the dictionary
                        break;
                    case 'B':
                        Clear();
                        Write("The derelict battle bus sits alone in the forest"); wait();
                        switch (menu("Go inside", "Go back", "", "", 2))
                        {
                            case 'A':
                                leaveBus = false;
                                do
                                {
                                    WriteLine("There's a homeless guy in the battle bus");
                                    Write("He is homeless and he is also a guy"); wait();

                                    switch (menu("Challenge him to a game of paper scissors rock",
                                        "Give him a hug",
                                        "Insult him",
                                        "Leave the bus"))
                                    {
                                        case 'A':
                                            Clear();
                                            Write("You make a paper-scissors-rock gesture and he nods very very enthusiastically"); wait();
                                            Write("He starts frowning when he realises that you mean you want to play paper scissors rock"); wait();
                                            Write("Homeless guy: 'Well okay then'  (press enter)"); Thread.Sleep(1000); ReadLine();  WriteLine();
                                            if (PSRgame() == true)
                                            {
                                                won = true;
                                                Write("Your reward for winning is my fine english dictionary"); wait();

                                                Write("You read the entire dictionary in one sitting"); wait(); WriteLine();
                                                Console.WriteLine("      __...--~~~~~-._   _.-~~~~~--...__");
                                                Console.WriteLine("    //               `V'               \\\\");
                                                Console.WriteLine("   //                 |                 \\\\");
                                                Console.WriteLine("  //__...--~~~~~~-._  |  _.-~~~~~~--...__\\\\");
                                                Console.WriteLine(" //__.....----~~~~._\\ | /_.~~~~----.....__\\\\");
                                                Console.WriteLine("====================\\\\|//====================");
                                                Console.WriteLine("                    `---`"   );
                                                Console.Write("                             ^   the dictionary     (press enter)");
                                                ReadLine();
;                                                

                                                Clear();
                                                for (int i = 0; i < 200; i++)
                                                {
                                                    Write("the whole dictionary"); Thread.Sleep(1);
                                                }
                                                Clear();


                                            }
                                            else
                                            {
                                                Write("Homeless Guy: 'You're the hairiest person I've every met'"); Thread.Sleep(1000); WriteLine();
                                            }
                                            break;
                                        case 'B':
                                            Clear();
                                            SuspenseSFX();
                                            Write("Homeless guy: 'AAAAAAAAAAAAAGHH HELP!!!'"); Thread.Sleep(1200); WriteLine();
                                            break;
                                        case 'C':
                                            Clear();
                                            SuspenseSFX();
                                            Write("Sasquatch: 'Yo mama Gaughrou goj herjub, jue paugh '"); Thread.Sleep(1300); WriteLine();
                                            WriteLine("Homeless guy: 'AAAAAAAAAAAAAGHH HELP!!!'"); Thread.Sleep(1400);
                                            break;
                                        default:
                                            Clear();
                                            leaveBus = true;
                                            break;
                                    }
                                } while (leaveBus == false);
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
            WriteLine("While walking on the street people ask to take photos with you as they think that you are ");
            Write("dressed up as some sort of character"); wait();
            switch(menu("Do the worm", "Hit the whip nae nae", "Scream at them", "", 3)){
                case 'A':
                    peacefulness += 4;
                    charisma += 6;
                    DramaSFX();
                    CursorVisible = false;
                    Clear();
                    WriteLine("You hit the worm");
                    WriteLine("\n\n\t\t");
                    Write(@"      \");
                    WriteLine("\t\t");
                    Write("      /");
                    Thread.Sleep(400);
                    Clear();
                    WriteLine("\n\n\t\t");
                    Write(@"      /");
                    WriteLine("\t\t");
                    Write(@"      \");
                    Thread.Sleep(400);
                    Clear();
                    WriteLine("\n\n\t\t");
                    Write(@"      \");
                    WriteLine("\t\t");
                    WriteLine("      /");
                    Thread.Sleep(400);
                    Clear();
                    WriteLine("\n\n\t\t");
                    Write("      /");
                    WriteLine("\t\t");
                    Write(@"      \");
                    Thread.Sleep(400);
                    Clear();
                    WriteLine("\n\n\t\t");
                    Write(@"      \");
                    WriteLine("\t\t");
                    WriteLine("      /");
                    Thread.Sleep(400);
                    Clear();
                    CursorVisible = true;
                    Write("The people: 'wow so impressive'"); wait();
                    break;
                case 'B':
                    Clear();
                    peacefulness += 4;
                    charisma += 7;

                    DramaSFX();
                    Write("You hit the whip nae nae"); wait();
                    Write("*whip nae nae*"); Thread.Sleep(1000); WriteLine();
                    Write("The people: 'wow so impressive'"); wait();


                    break;

                default:
                    Clear();
                    peacefulness -= 4;
                    charisma += 7;
                    Write("The people: 'wow so impressive'"); Thread.Sleep(1000); WriteLine();
                    HumanMeow();
                    break;
                
            }


            Write("You see a job listing on a lampost"); wait();
            WriteLine("What do you do?");
            switch (menu("Give it a sniff", "Read it", "Freak the hell out", "", 3))
            {
                case 'A':
                    Write("You give the job listing a sniff"); wait();
                    WriteLine("Your sense of smell is very good so you smell the ink to such a detail that");
                    Write("you can read it through smelling it"); wait();
                    WriteLine("It reads 'FUM Incorporated: Assistant Manager wanted'"); wait();
                    break;
                case 'B':
                    Write("You read the job listing"); wait();
                    WriteLine("It reads 'FUM Incorporated: Assistant Manager wanted'"); wait();
                    break;
                case 'C':
                    Write("You freak the hell out"); wait();
                    WriteLine("You start rioting all over Corporate America City and you get arrested");
                    Write("They sentence you to the death penalty and are set to be executed tommorow"); wait();
                    switch (menu("Say sorry", "Doubly freak the hell out", "Freak the absolute hell out", "", 3)) {
                        case 'A':
                            Write("You: 'sorry broskis"); Thread.Sleep(1000); WriteLine();
                            WriteLine("Police: 'You're free to go sir'");
                            break;
                        case 'B':
                            break;
                        default:

                            break;
                    }
                    break;
            }



        }
        public static void sasquatchTotal()
        {
            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Sasquatch Life"); Thread.Sleep(300);
            WriteLine($"How peaceful you were: {peacefulness}" +
            $"\nHow humanistic you were: {human}" +
            $"\nHow charismatic you were: {charisma}"); ResetColor(); Write("Press enter to reincarnate to your next life");
            ReadLine();
            return;
        }
    }
}
