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
        private static void wait(int time = 500)
        {
            CursorVisible = false;
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".\n");
            Thread.Sleep(time);
            CursorVisible = true;

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
                WriteLine(" ");
                WriteLine(" ");

                WriteLine(" ");
                WriteLine("GAME OF HONEY");
                WriteLine("In this level, you will be asked a few questions when a bee tries to extract honey from which is a bad  thing for you");


                WriteLine(" ");
                menu("LET BEE EXTRACT HONEY, oh yeah she gonna steal it from you. i dont think its very wise to let it happen", "KILL THE BEE INSTEAD, are you a killer? psychopath? hell nah bro", "FIGHT BACK, be a hero here the dragons are coming after bees ", "NONE OF THESE, sybau i know you wont click it");

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
                WriteLine("IDKKKKKK you shouldnt have done that (i dont really care what u did bro -_-)");

                WriteLine(" ");
            WriteLine("Hang tight dude");
            WriteLine(" ");
            WriteLine("USA VS VENEZUELA OIL EXTRACTION, we all know about this shitty that was done by USA just for the oil of Venezuela. maybe oil maybe just the love of game");
            WriteLine(" ");
            WriteLine("we never know btw, LETSSSSSS GOOO "); Thread.Sleep(1000);
            WriteLine("In this , a human will try to extract oil from you same as USA tried to extract oil from the Venezuela by capturing its President ");

                WriteLine(" ");
                menu("KILL THE EXTRACTOR, what i mean by that is literal killing. Isnt it bad enough? haha ", "LET IT HAPPEN, shut up what you gonna do? huh what?", "SUICIDE, ummm yeah nah maybe but killing yourself is not gonna be a really good option bro", "NONE OF THESE, choose nothing and feel shamefull i know you wont choose this, will you? cmon now ");
                if (D1 == true)
                {
                okaybeep();
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
             
                WriteLine("sybau bro, you aint the player here, lets see what you got in here. does this feel good? really? choose those options was an act of immense shame btw -_- ");

                WriteLine(" ");
                WriteLine("DOG AND HIS POOP, even i dont know why this is part of game. try harder and dont be stupid now");
            WriteLine(" ");
            Write("okay calm down now, i know what you are thinking. its not that tuff bro but here we are"); wait();
            WriteLine("In this a dog will try to poop on you, so try your best bro ikr this is an absurd idea :( ");
            WriteLine(" ");
            WriteLine("yeah yeah ik but it is a real thing, dogs do poop on plants. its my bad if you havent seen one doing thus  ");
            WriteLine(" "); 
            WriteLine(" just choose a gawddamn option now ");
            menu("LET HIM DO IT, i know you let it happen i know ", "KILL HIM, you killer? please dont do it bro", "DO NOTHING, this doesnt mean doing nothing it does mean actually doing nothing ", "SMILE AT HIM, smiles can change the world, keep smiling bro you are in the presence of great MR.沃恩·马尔金");
                if (D1 == true)
                {
                    selfishness += 1;

                    stupidity += 12;
                    plint += 2;

                }
                if (D2 == true)
                {
                Write("You attempted to kill him, but you are just a mere fool plant, so it didn't amount to anything."); wait();
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

                  WriteLine("sybau bro");
                

                WriteLine(" ");

                WriteLine("you have made really absurd choices till now but here we are again ");
                WriteLine("GAME OF WINDS, we all know wind is a really strong force? is it visible? nah, right? try standing on the top of a mountain and answer this you fool.");
                WriteLine(" ");
            Write("okay calm down i didnt mean that, but yeah i did. wind is such a strong force that even the plants are scared of it."); wait();
            WriteLine(" ");
            WriteLine("as we see MR.. 沃恩·马尔金's sunflower crying now, let him cry but atleast choose something appropriate now, will you? please ");
            WriteLine(" ");
            WriteLine("no cheats here, use your brian to the fullest, yeah use it. ");





            menu("FIGHT BACK, fight back here means actually punching in the air LoL", "HOLD YOUR ROOTS HARDER, this one makes sense ngl ", "DIE PEACEFULLY, yeah the calmest thing we all gonna die so why not the plant", "卧槽，这是什么鬼？是中文的？, neither of us chinese bro");
                WriteLine(" "); if (D1 == true)
            {
                selfishness += 1;

                stupidity += 12;
                plint += 2;

            }
            if (D2 == true)
            {
                Clear();
                Write("You held your roots harder"); wait();
                selfishness += 5;
                stupidity += 4;
                plint += 8;

            }
            if (D3 == true)
            {
                Clear();
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
                WriteLine("SO YOUR GLOBAL SCORE AFTER BEING A PLANT IS " + plint);
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
