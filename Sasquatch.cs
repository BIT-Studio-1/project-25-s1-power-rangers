using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeCode.Program;
using static CodeCode.PSR;
using static CodeCode.SoundUtils;
using static System.Console;
namespace CodeCode
{
    public class Sasquatch
    {
        private static int peacefulness = 25;
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
            sasquatchScene2();

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
            bool goneMountains = false;

            while (keepGoing == false) {
                WriteLine("You're in the mountains");
                WriteLine("To the \u001b[1meast\u001b[0m, you hear a river");
                WriteLine("To the \u001b[1mwest\u001b[0m, you see the fortnite battle bus");
                WriteLine("To the \u001b[1mnorth\u001b[0m, towards some snowy mountains and the smell of food");
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
                        Clear();

                        Write("You trudge towards the snowy mountains"); wait();
                        Write("It is very cold"); wait();
                        Write("Your nips could cut diamonds"); wait();
                        if (goneMountains == false) { 
                            goneMountains = true;
                            Write("At the top of a ridge you find a lonely mountain climber"); wait();

                            switch (menu("Wave at him", "Steal his burger", "", "", 2))
                            {
                                case 'A':
                                    peacefulness += 4;
                                    charisma += 2;
                                    human += 2;
                                    Clear();
                                    Write("He waves back enthusiastically"); wait();
                                    Write("Mountain climber: 'Corporate America City is down by the river if you're looking for civilisation'"); wait();

                                    switch (menu("Ask for advice", "Ask for food", "", "", 2))
                                    {
                                        case 'A':
                                            human += 2;
                                            peacefulness += 7;
                                            goodbeep();
                                            Write("Mountain climber: 'If you wanna get a job, might wanna learn English first'"); wait();
                                            Write("You nod wisely despite not knowing what he said"); wait();
                                            break;

                                        default:
                                            charisma -= 1;
                                            goodbeep();
                                            Write("He gives you half an apricot meusli  bar"); wait();
                                            Write("It tastes like stubbing your toe"); wait();
                                            Write(""); wait();
                                            break;
                                    }
                                    break;

                                default:
                                    Clear();
                                    human -= 2;
                                    peacefulness -= 5;
                                    okaybeep();
                                    Write("You steal his burger and begin running"); wait();
                                    Write("The mountain climber turns out to be surprisingly athletic"); wait();
                                    Write("You barely escape"); wait();
                                    break;
                            }
                        }
                        else
                        {
                            Clear();
                            Write("The climber is no longer here    (press enter to go back)"); ReadLine(); 
                        }
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
                    HumanMeow();
                    Write("The people: 'wow so impressive'"); Thread.Sleep(1000); WriteLine();
                    break;
                
            }


            Write("You see a job listing on a lampost"); wait();
            WriteLine("What do you do?");
            switch (menu("Give it a sniff", "Read it", "Freak the hell out", "", 3))
            {
                case 'A':
                    goodbeep();
                    Clear();
                    Write("You give the job listing a sniff"); wait();
                    WriteLine("Your sense of smell is very good so you smell the ink to such a detail that");
                    Write("you can read it through smelling it"); wait();
                    WriteLine("It reads 'FUM Incorporated: Assistant Manager wanted'"); wait();
                    break;
                case 'B':
                    goodbeep();
                    Clear();
                    Write("You read the job listing"); wait();
                    WriteLine("It reads 'FUM Incorporated: Assistant Manager wanted'"); wait();
                    break;
                case 'C':
                    okaybeep();
                    Clear();
                    Write("You freak the hell out"); wait();
                    WriteLine("You start rioting all over Corporate America City and you get arrested");
                    Write("They sentence you to the death penalty and are set to be executed tommorow"); wait();
                    switch (menu("Say sorry", "Doubly freak the hell out", "Freak the absolute hell out", "", 3)) {
                        case 'A':
                            goodbeep();
                            charisma += 5;
                            human += 3;
                            Write("You: 'sorry broskis"); Thread.Sleep(1000); WriteLine();
                            Write("Police: 'You're free to go sir'     (press enter)"); ReadLine();
                            
                            break;
                        case 'B':
                            human -= 3;
                            Write("You freak out so hard that you escape them"); wait();
                            WriteLine("You're now free     (press enter)"); ReadLine();

                            break;
                        default:
                            human -= 5;
                            Write("You freak out so hard that you escape them"); wait();
                            WriteLine("You're now free      (press enter)"); ReadLine();

                            break;
                    }
                    Clear();
                    Write("Out in the street, one of the guys from before thinks that you would be nice for a job"); Thread.Sleep(800); WriteLine();
                    Write("The job is an assistant manager at FUM Incorporated"); wait();

                    break;
            }


            Write("You go to the interview");

            Write("The interviewer looks up from his paperwork"); wait();
            Write("He looks at you"); wait();
            Write("Then he looks back down at his paperwork"); wait();
            Write("Then he looks back at you"); wait();

            WriteLine("\nInterviewer: 'So what exactly happened to you?'");

            switch (menu("I have werewolf syndrome", "I'm like hairy mclairy from donaldson's dairy", "Freak the hell out and eat the office cat", "", 3))
            {
                case 'A':
                    goodbeep();
                    Clear();
                    charisma += 6;
                    human += 4;
                    WriteLine("You tell the interviewer you have werewolf syndrome");
                    Write("Interviewer: 'Ah. That explains it.'"); wait();
                    Write("He writes something down on his clipboard"); wait();
                    Write("You look at the clipboard and its a drawing of you"); wait();
                    break;

                case 'B':
                    Clear();

                    okaybeep();
                    charisma += 3;
                    WriteLine("You tell the interviewer you're like hairy mclairy from donaldson's dairy");

                    Write("Interviewer: 'That doesn't explain that foul stench coming from you'"); wait();
                    Write("You stare seductively into the interviewers eyes"); wait();
                    break;

                default:
                    Clear();
                    badbeep();
                    charisma -= 4;
                    human -= 3;
                    peacefulness -= 1;

                    Write("The office cat puts up a brave fight"); wait();
                    Write("The interviewer seems concerned for some reason"); wait();
                    break;
            }

            WriteLine("\nInterviewer: 'Where do you see yourself in five years?'");

            switch (menu("Assistant manager", "Your boss", "", "", 2))
            {
                case 'A':
                    goodbeep();
                    Clear();
                    charisma += 4;
                    WriteLine("You: 'Assistant manager'"); Thread.Sleep(500);
                    Write("Interviewer: 'A sensible answer. Rare around here.'"); wait();
                    break;

                case 'B':
                    Clear();
                    goodbeep();
                    charisma += 8;
                    WriteLine("You: 'Your boss'"); Thread.Sleep(500);

                    Write("Interviewer: 'I like your ambition'"); wait();
                    break;

                default:
                    Clear();
                    okaybeep();
                    peacefulness += 4;

                    Write("You freak the hell out and eat the office cat"); wait();
                    Write("The interviewer nods thoughtfully"); wait();
                    break;
            }

            Write("The interviewer folds his hands"); wait();
            Write("He seems deep in thought"); wait();
            Write("Mostly because he's fallen asleep"); wait();

            goodbeep();
            Write("You got the job"); Thread.Sleep(1300);
            for (int i = 0; i <=4; i++)
            {
                Write("*working*     "); Thread.Sleep(1000);
            }
            Write("The working conditions at FUM are very dangerous"); wait();
            Write("The office water fountain explodes and you die a horrible death"); ReadLine();


        }
        public static void sasquatchTotal()
        {
            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Sasquatch Life"); Thread.Sleep(300);
            WriteLine($"How peaceful you were: {peacefulness}" +
            $"\nHow humanistic you were: {human}" +
            $"\nHow charismatic you were: {charisma}"); ResetColor(); Write("Press enter to finish game");
            ReadLine();
            return;
        }
    }
}
