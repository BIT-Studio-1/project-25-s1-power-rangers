using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CodeCode.MenuTest;
using static CodeCode.SoundUtils;

namespace CodeCode
{
    internal class plant
    {
        
            public static void plantScene1()
            {
                Clear();
                int selfishness = 0;
                int stupidity = 0;
                int plant = 0;
                /*
                WriteLine("LEVEL 1");
                WriteLine("GAME OF HONEY");
                */
                WriteLine("I AM A SUNFLOWER IN THE VALLEYS OF DUNEDIN IN MR. 沃恩·马尔金'S GARDEN. I HAVE SPENT MOST OF MY LIFE LISTENING TO HIM ABOUT MAKING SQL DATABASES.");
                WriteLine(" ");
                WriteLine("IT IS NOW THE TIME TO DECIDE YOUR DESTINY: ");
                WriteLine(" ");
                WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎LEVEL 1");
                WriteLine(" ");

                WriteLine(" ");
                WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎GAME OF HONEY");
                WriteLine(" ");

                WriteLine(" ");
                menu("LET BEE EXTRACT HONEY", "KILL  THE BEE INSTEAD", "FIGHT BACK", "NONE OF THESE");

                if (D1 == true)
                {

                    plant += 100;
                    stupidity += 100;
                    selfishness += 0;

                }
                if (D2 == true)
                {

                    plant += 10;



                    selfishness += 500;

                    stupidity += 200;
                }
                if (D3 == true)
                {

                    plant += 200;
                    selfishness += 100;
                    stupidity += 50;
                }
                if (D4 == true)
                {
                    plant += 0;
                    selfishness += 100;
                    stupidity += 200;


                }
                if (D4 == true)
                {
                    plant += 0;
                    selfishness += 100;
                    stupidity += 200;

                }



                Clear();
                WriteLine("LEVEL 2");
                WriteLine("USA VS VENEZUELA OIL EXTRACTION");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎LEVEL 2");
                WriteLine(" ");

                WriteLine(" ");
                WriteLine("‎‎‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎ ‎‎‎ ‎ ‎ ‎USA VS VENEZUELA OIL EXTRACTION");
                WriteLine(" ");

                WriteLine(" ");
                menu("KILL THE EXTRACTOR", "LET IT HAPPEN", "SUICIDE", "NONE OF THESE");
                if (D1 == true)
                {

                    selfishness += 0;

                    stupidity += 0;
                    plant += 0;
                }
                if (D2 == true)
                {

                    selfishness += 0;
                    stupidity += 0;
                    plant += 0;
                }
                if (D3 == true)
                {
                    selfishness += 0;
                    stupidity += 0;
                    plant += 0;
                }
                if (D4 == true)
                {
                    selfishness += 0;
                    stupidity += 0;


                    plant += 0;
                }
                if (D3 == true)
                {
                    selfishness += 0;
                    stupidity += 0;
                    plant += 0;
                }
                if (D4 == true)
                {
                    selfishness += 0;
                    stupidity += 0;

                    plant += 0;
                }

                Clear();
                WriteLine("LEVEL 3");
                WriteLine("DOG AND HIS POOP");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎LEVEL 3");
                WriteLine(" ");

                WriteLine(" ");
                WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎ ‎‎‎ ‎‎‎ ‎‎‎ ‎‎‎DOG AND HIS POOP");
                WriteLine(" ");

                WriteLine(" ");
                menu("LET HIM DO IT", "KILL HIM", "DO NOTHING", "SMILE AT HIM");
                if (D1 == true)
                {
                    selfishness += 0;



                    stupidity += 0;
                    plant += 0;

                }
                if (D2 == true)
                {
                    selfishness += 0;
                    stupidity += 0;
                    plant += 0;

                }
                if (D3 == true)
                {

                    selfishness += 0;
                    stupidity += 0;
                    plant += 0;




                }
                if (D4 == true)
                {

                    selfishness += 0;
                    stupidity += 0;
                    plant += 0;
                    selfishness = 0;
                    stupidity = 0;
                    plant = 0;




                }
                Clear();
                WriteLine("DEATH LEVEL");
                WriteLine("GAME OF WINDS");

                menu("FIGHT BACK", "HOLD YOUR ROOTS HARDER", "DIE PEACEFULLY", "卧槽，这是什么鬼？是中文的？");
                WriteLine("so your stupidness being a plant is ", stupidity);
                WriteLine("so your selfishness being a plant is ", selfishness);
                WriteLine("so your global score after being a plant is", plant);

                ForegroundColor = ConsoleColor.Red;
                string Level4 = ("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎DEATH LEVEL");

                WriteLine(" ");

                WriteLine(" ");
                WriteLine("‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎‎ ‎ ‎ ‎‎  ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎ ‎‎GAME OF WINDS");
                WriteLine(" ");
                WriteLine(" ");

                menu("FIGHT BACK", "HOLD YOUR ROOTS HARDER", "DIE PEACEFULLY", "卧槽，这是什么鬼？是中文的？");
                WriteLine(" ");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("SO YOUR STUPIDNESS BEING A PLANT IS ", stupidity);
                WriteLine("SO YOUR SELFISHNESS BEING A PLANT IS ", selfishness);
                WriteLine("SO YOUR GLOBAL SCORE AFTER BEING A PLANT IS", plant);
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
