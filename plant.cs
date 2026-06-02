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
    internal class plant
    {

        private static int selfishness = 20;
        private static int stupidity  = 20;
        private static int plint = 20;

        public static int Selfishness
        {
            get { return selfishness; }
        }
        public static int Stupidity
        {
            get { return stupidity; }
        }
        public static int Plant
        {
            get { return plint; }
        }
        public static void plantScene1()
            {
                Clear();
               
            /*
            WriteLine("LEVEL 1");
            WriteLine("GAME OF HONEY");
            */
            ForegroundColor = ConsoleColor.Red;
            Write("You are recarnated as a  ");
                WriteLine("PLANT");
                WriteLine("I AM A SUNFLOWER IN THE VALLEYS OF DUNEDIN IN MR. 沃恩·马尔金'S GARDEN. I HAVE SPENT MOST OF MY LIFE LISTENING TO HIM ABOUT MAKING SQL DATABASES.");
                WriteLine(" ");
                WriteLine("IT IS NOW THE TIME TO DECIDE YOUR DESTINY: ");
                WriteLine("Your over all global score will be declared on the basis of the options you choose in each question ");
                WriteLine("LEVEL 1");
                WriteLine(" ");

                WriteLine(" ");
                WriteLine("GAME OF HONEY");
                WriteLine("In this level, you will be asked a few questions when a bee tries to extract honey from which is a bad  thing for you");


                WriteLine(" ");
                menu("LET BEE EXTRACT HONEY", "KILL THE BEE INSTEAD", "FIGHT BACK", "NONE OF THESE");

                if (D1 == true)
                {

                    plint += 0;
                    stupidity += 8;
                    selfishness += 3;

                }
                if (D2 == true)
                {

                    plint += 10;



                    selfishness += 8;

                    stupidity += 6;
                }
                if (D3 == true)
                {

                    plint += 3;
                    selfishness += 9;
                    stupidity += 3;
                }
                if (D4 == true)
                {
                    plint += 0;
                    selfishness += 8;
                    stupidity += 4;


                }
               
          
        

            Clear();
               

                ForegroundColor = ConsoleColor.Red;
                WriteLine("oh myyyyyyyyyyy Gawdddddddddddd what you just did..........?");
                WriteLine(" ");
                WriteLine("IDKKKKKK you shouldnt have done that (i dont really care what u did bro -_-");

                WriteLine(" ");
                WriteLine("USA VS VENEZUELA OIL EXTRACTION");
                WriteLine("In this level, a human will try to extract oil from you same as USA tried to extract oil from the Venezuela by capturing its President ");

                WriteLine(" ");
                menu("KILL THE EXTRACTOR", "LET IT HAPPEN", "SUICIDE", "NONE OF THESE");
                if (D1 == true)
                {

                    selfishness += 9;

                    stupidity += 10;
                    plint += 4;
                }
                if (D2 == true)
                {

                    selfishness += 2;
                    stupidity += 10;
                    plint += 8;
                }
                if (D3 == true)
                {
                    selfishness += 0;
                    stupidity += 10;
                    plint += 0;
                }
                if (D4 == true)
                {
                    selfishness += 7;
                    stupidity += 5;


                    plint += 10;
                }
         


            Clear();
               
                ForegroundColor = ConsoleColor.Red;
                WriteLine("LEVEL 3");
                WriteLine(" ");

                WriteLine(" ");
                WriteLine("DOG AND HIS POOP");
                WriteLine("In this level a dog will try to poop on you, so try your best bro ikr this is an absurd idea :( ");

                WriteLine(" ");
                menu("LET HIM DO IT", "KILL HIM", "DO NOTHING", "SMILE AT HIM");
                if (D1 == true)
                {
                    selfishness += 1;

                    stupidity += 12;
                    plint += 2;

                }
                if (D2 == true)
                {
                    selfishness += 5;
                    stupidity += 4;
                    plint += 8;

                }
                if (D3 == true)
                {

                    selfishness += 3;
                    stupidity += 12;
                    plint += 4;




                }
                if (D4 == true)
                {

                    selfishness += 2;
                    stupidity += 12;
                    plint += 3;
                    

                }
          

            Clear();
                 ForegroundColor = ConsoleColor.Red;

                  WriteLine("DEATH LEVEL");
                

                WriteLine(" ");

                WriteLine(" ");
                WriteLine("GAME OF WINDS");
                WriteLine(" ");
                WriteLine(" ");

                menu("FIGHT BACK", "HOLD YOUR ROOTS HARDER", "DIE PEACEFULLY", "卧槽，这是什么鬼？是中文的？");
                WriteLine(" "); if (D1 == true)
            {
                selfishness += 1;

                stupidity += 12;
                plint += 2;

            }
            if (D2 == true)
            {
                selfishness += 5;
                stupidity += 4;
                plint += 8;

            }
            if (D3 == true)
            {

                selfishness += 3;
                stupidity += 12;
                plint += 4;




            }
            if (D4 == true)
            {

                selfishness += 2;
                stupidity += 12;
                plint += 3;





            }
            ForegroundColor = ConsoleColor.Red;
                WriteLine("SO YOUR STUPIDNESS BEING A PLANT IS " + stupidity);
                WriteLine("SO YOUR SELFISHNESS BEING A PLANT IS " + selfishness);
                WriteLine("SO YOUR GLOBAL SCORE AFTER BEING A PLANT IS" + plint);
                WriteLine(" ");
                WriteLine(" ");
                WriteLine("PLEASE PRESS ENTER TO CONTINUE");
                ReadLine();

                Console.ResetColor();

                return;
            }


        public static void plantLife()
        {


            plantScene1();
            return;
        }


    }
}
