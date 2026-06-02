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
    internal class PSR
    {

        private static void compute()
        {
            Console.Write("rocks....."); Thread.Sleep(500);
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
        public static void PSRgame()
        {
            WriteLine("You challenged the homeless guy to rock paper scissors");
            Write("The format is first to 3");

            int playerScore = 0;
            int computerScore = 0;


            do
            {
                WriteLine($"Your current score: {playerScore} Homeless guy's current score: {computerScore}");
                Write("Do you use Rock 'R', Paper 'P', or Scissors 'S'\n: ");
                string usertemp = ReadLine().ToUpper();
                char player = char.Parse(usertemp);

                Random rand = new Random();
                int computertemp = rand.Next(3);
                char computer;

                compute();


                switch (computertemp)
                {
                    case 0:
                        computer = 'R';
                        WriteLine("Homeless guy used Rock");
                        break;

                    case 1:
                        computer = 'P';
                        WriteLine("Homeless guy used Paper");
                        break;

                    default:
                        computer = 'S';
                        WriteLine("Homeless guy used Scissors");
                        break;



                }

                if (player == computer)
                {
                    WriteLine("It is a draw");
                }

                else
                {
                    if (
                        (player == 'R' && computer == 'S') ||
                        (player == 'P' && computer == 'R') ||
                        (player == 'S' && computer == 'P'))
                    {
                        WriteLine("You won this round");
                    }
                    else
                    {
                        WriteLine("You lost this round");
                    }
                }

                ReadLine();
            } while (playerScore < 3 && computerScore < 3);

            Clear();

            if (playerScore == 3)
            {
                Write("You won the game of paper scissors rock"); 
            }
            else { 
                Write("You lost the game of paper scissors rock");

            }
        }
    }
}
