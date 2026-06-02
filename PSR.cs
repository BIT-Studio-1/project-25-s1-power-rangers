using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CodeCode.Program;
using static CodeCode.Sasquatch;
namespace CodeCode
{
    internal class PSR
    {
        private static void wait(int time = 500)
        {
            CursorVisible = false;
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".\n");
            Thread.Sleep(time);
            CursorVisible = true;

        }
        private static void compute()
        {
            Console.Write("rock....."); Thread.Sleep(500);
            Write("paper....."); Thread.Sleep(500);
            Write("scissors....."); Thread.Sleep(500);



            //Console.WriteLine(computer);
            Random rand = new Random();
            int count = 0;
            while (count <= 18)
            {
                //Console.Beep();
                Console.Beep((int)rand.Next(500, 1000), 80);

                count += 1;

            }
        }
        public static bool PSRgame()
        {
            Clear();
            WriteLine("You challenged the homeless guy to rock paper scissors");
            WriteLine("The format is first to 3");

            int playerScore = 0;
            int computerScore = 0;

            
            do
            {
                Clear();
                WriteLine($"Your current score: \u001b[1m{playerScore}\u001b[0m        Homeless guy's current score: \u001b[1m{computerScore}\u001b[0m");
                //Write("Do you use Rock 'R', Paper 'P', or Scissors 'S'\n: ");
                

                char player = ' ';
                bool keepGoingBruh = false;
                do {
                    Write("Do you use Rock 'R', Paper 'P', or Scissors 'S'\n: ");
                    string usertemp = ReadLine().ToUpper();
                    if (usertemp == "R" ||
                        usertemp == "S" ||
                        usertemp == "P"
                        )
                    {
                        player = char.Parse(usertemp);
                        keepGoingBruh = true;
                    }
                    else
                    {
                        WriteLine("Invalid input.");
                    }
                } while (!keepGoingBruh);

                    Random rand = new Random();
                int computertemp = rand.Next(3);
                char computer;

                compute();


                switch (computertemp)
                {
                    case 0:
                        computer = 'R';
                        WriteLine(" Homeless guy used Rock"); Thread.Sleep(700);
                        break;

                    case 1:
                        computer = 'P';
                        WriteLine(" Homeless guy used Paper"); Thread.Sleep(700);
                        break;

                    default:
                        computer = 'S';
                        WriteLine(" Homeless guy used Scissors"); Thread.Sleep(700);
                        break;



                }

                if (player == computer)
                {
                    Write("This round is a draw");
                }

                else
                {
                    if (
                        (player == 'R' && computer == 'S') ||
                        (player == 'P' && computer == 'R') ||
                        (player == 'S' && computer == 'P'))
                    {
                        Write("You won this round");
                        playerScore++;
                    }
                    else
                    {
                        Write("You lost this round");
                        computerScore++;

                    }
                }
                Write(" (press enter)");
                ReadLine();
            } while (playerScore < 3 && computerScore < 3);

            Clear();
            WriteLine($"Your final score: \u001b[1m{playerScore}\u001b[0m      Homeless guy's final score: \u001b[1m{computerScore}\u001b[0m");
            if (playerScore == 3)
            {
                Write("You won the game of paper scissors rock"); wait();
                return true;
            }
            else { 
                Write("You lost the game of paper scissors rock"); wait();
                Write("Homeless guy: 'If you win, I'll give you my english dictionary'"); wait();

                return false;

            }
        }
    }
}
