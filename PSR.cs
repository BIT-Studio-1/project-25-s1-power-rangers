namespace lab_7
{
    internal class Program
    {

        private static void compute()
        {
            Console.WriteLine("rocks.....  papler.... skcisors....");

            //Console.WriteLine(computer);
            Random rand = new Random();
            int count = 0;
            while (count <= 18)
            {
                //Console.Beep();
                Console.Beep((int)rand.Next(500, 1000), 100);

                count += 1;

            }
        }
        public static void PSR(string[] args)
        {
            Console.WriteLine("Welcome to rock paper scissors 4000 all rights reserved");

            

            Console.Write("Do you use Rock 'R', Paper 'P', or Scissors 'S'\n: ");
            string usertemp = Console.ReadLine().ToUpper();
            char player = char.Parse(usertemp);

            Random rand = new Random();
            int computertemp = rand.Next(3);
            char computer;

            compute();


            switch (computertemp)
            {
                case 0:
                    computer = 'R';
                    Console.WriteLine("Computer used Rock");
                    break;

                case 1:
                    computer = 'P';
                    Console.WriteLine("Computer used Paper");
                    break;

                default:
                    computer = 'S';
                    Console.WriteLine("Computer used Scissors");
                    break;



            }

            if (player == computer) {
                Console.WriteLine("It is a draw");
            }

            else
            {
                if (
                    (player == 'R' && computer == 'S') ||
                    (player == 'P' && computer == 'R') ||
                    (player == 'S' && computer == 'P'))
                {
                    Console.WriteLine("You won lets go");
                }
                else
                {
                    Console.WriteLine("You lost!");
                }
            }

            Console.ReadLine();

        }
    }
}
