using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            Write("You are recarnated as a  "); Thread.Sleep(4000);
                WriteLine("PLANT");
                WriteLine("YOURE A SUNFLOWER IN THE VALLEYS OF DUNEDIN IN MR. 沃恩·马尔金'S GARDEN. I HAVE SPENT MOST OF MY LIFE LISTENING TO HIM ABOUT MAKING SQL DATABASES."); Thread.Sleep(2000);
                WriteLine(" ");
                WriteLine("IT IS NOW THE TIME TO DECIDE YOUR DESTINY: ");
                WriteLine("Your over all global score will be declared on the basis of the options you choose in each question ");
                WriteLine(" ");
                WriteLine(" ");

                Write(" ");wait();
                WriteLine("GAME OF HONEY"); Thread.Sleep(2000);
                WriteLine("In this level, you will be asked a few questions when a bee tries to extract honey from which is a bad  thing for you"); Thread.Sleep(3000);


                WriteLine(" ");
                menu("LET BEE EXTRACT HONEY, oh yeah she gonna steal it from you. i don't think its very wise to let it happen", "KILL THE BEE INSTEAD, are you a killer? psychopath? hell nah bro", "FIGHT BACK, be a hero here the dragons are coming after bees ", "NONE OF THESE, sybau i know you wont click it");

                if (D1 == true)
                {
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("why you so so stupid bro, you gave up for nothing :( "); Thread.Sleep(2000);

                    plint += 0;
                    stupidity += 8;
                    selfishness += 3;

                }
                if (D2 == true)
                {
                Play(@"sfx/Suspensesfx.wav");
                Clear();
                ForegroundColor = ConsoleColor.Red;

                WriteLine("gawd damnit you a killer?????? an innocent bee bro she was innocent bee "); Thread.Sleep(2000);

                plint += 10;



                    selfishness += 8;

                    stupidity += 6;
                }
                if (D3 == true)
                {
                Play(@"sfx/epicsfx.wav");
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("oh yeah that was a wise move but you're just plant bro, the bee queen is laughing at you"); Thread.Sleep(2000);
                plint += 3;
                    selfishness += 9;
                    stupidity += 3;
                }
                if (D4 == true)
                {
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("okay yeah do nothing? why in the world did you choose this?"); Thread.Sleep(2000);
                plint += 3;
                plint += 0;
                    selfishness += 8;
                    stupidity += 4;


                }
               
          
        

            Clear();
               

                ForegroundColor = ConsoleColor.Red;
                WriteLine("oh myyyyyyyyyyy Gawdddddddddddd what you just did..........?");
                WriteLine(" ");
                WriteLine("IDKKKKKK you shouldn't have done that (i don't really care what u did bro -_-)");

                WriteLine(" ");
            WriteLine("Hang tight dude"); Thread.Sleep(3000);
            WriteLine(" ");
            WriteLine("USA VS VENEZUELA OIL EXTRACTION, we all know about hostilities that was done by USA just for the oil of Venezuela. maybe oil maybe just the love of game"); Thread.Sleep(2000);
            WriteLine(" ");
            WriteLine("we never know btw, LETSSSSSS GOOO "); Thread.Sleep(1000);
            WriteLine("In this , a human will try to extract oil from you same as USA tried to extract oil from the Venezuela by capturing its President "); Thread.Sleep(1000);

                WriteLine(" ");
                menu("KILL THE EXTRACTOR, what i mean by that is literal killing. Isn't it bad enough? haha ", "LET IT HAPPEN, shut up what you gonna do? huh what?", "SUICIDE, ummm yeah nah maybe but killing yourself is not gonna be a really good option bro", "NONE OF THESE, choose nothing and feel shamefull i know you wont choose this, will you? cmon now ");
                if (D1 == true)
                {
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("yeah youre a killer bro, i get it but  it wasnt even valid here"); Thread.Sleep(3000);

                 
                    selfishness += 9;

                    stupidity += 10;
                    plint += 4;
                }
                if (D2 == true)
                {
                Play(@"sfx/Dramasfx.wav");
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("giving up is never a good option, have you ever watched JOHN CENA in WWE?"); Thread.Sleep(4000);
                    selfishness += 2;
                    stupidity += 10;
                    plint += 8;
                }
                if (D3 == true)
                {
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("cmon bro you shouldn't have done this you're a plant, you cannot kill yourself by your own hahaha"); Thread.Sleep(3000);
                
                    selfishness += 0;
                    stupidity += 10;
                    plint += 0;
                }
                if (D4 == true)
                {
                goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Eat five star and do nothing type shi, but you must do something if this happens in real life"); Thread.Sleep(3000);

                    selfishness += 7;
                    stupidity += 5;


                    plint += 10;
                }
         


            Clear();
               
                ForegroundColor = ConsoleColor.Red;
             
                WriteLine("sybau bro, you aint the player here, lets see what you got in here. does this feel good? really? choose those options was an act of immense shame btw -_- "); Thread.Sleep(2000);

                WriteLine(" ");
                WriteLine("DOG AND HIS POOP, even i dont know why this is part of game. try harder and dont be stupid now"); Thread.Sleep(2000);
            WriteLine(" ");
            Write("okay calm down now, i know what you are thinking. its not that tuff bro but here we are"); wait();
            WriteLine("In this a dog will try to poop on you, so try your best bro ikr this is an absurd idea :( ");
            WriteLine(" ");
            Write("yeah yeah ik but it is a real thing, dogs do poop on plants. its my bad if you havent seen one doing thus  "); wait();
            Write(" just choose a gawddamn option now "); wait();
            menu("LET HIM DO IT, i know you let it happen i know ", "KILL HIM, you killer? please dont do it bro", "DO NOTHING, this doesnt mean doing nothing it does mean actually doing nothing ", "SMILE AT HIM, smiles can change the world, keep smiling bro you are in the presence of great MR.沃恩·马尔金");
                if (D1 == true)
                {
                badbeep();
                Clear();
                ForegroundColor= ConsoleColor.Red;
                WriteLine("did you let it happen are you crazy? i think so okay whatever now GO CLEAAANNNNNNN YOURRRSELFFFFFF........"); Thread.Sleep(3000);
                    selfishness += 1;

                    stupidity += 12;
                    plint += 2;

                }
                if (D2 == true)
                {
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("You attempted to kill him, but you are just a mere fool plant, so it didn't amount to anything."); Thread.Sleep(2000);
                    selfishness += 5;
                    stupidity += 4;
                    plint += 8;

                }
                if (D3 == true)
                {
                 goodbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine(" you did nothing means you let that happen, GOOOO AND CLEANNNN YOURSELFFFFFF");
                Thread.Sleep(2000);
                selfishness += 3;
                    stupidity += 12;
                    plint += 4;




                }
                if (D4 == true)
                {
                badbeep();
                Clear();

                ForegroundColor = ConsoleColor.Red;
                WriteLine(" yeah that was smart move but he still pooped on you"); Thread.Sleep(2000);
                Write("LMAOOOOOOOOOO"); wait(1000);



                selfishness += 2;
                    stupidity += 12;
                    plint += 3;
                    

                }
          

            Clear();
                 ForegroundColor = ConsoleColor.Red;

                  Write("sybau bro"); wait(); 
                

                WriteLine(" ");

                WriteLine("you have made really absurd choices till now but here we are again "); Thread.Sleep(2000);
                WriteLine("GAME OF WINDS, we all know wind is a really strong force? is it visible? nah, right? try standing on the top of a mountain and answer this you fool."); Thread.Sleep(2000);
                WriteLine(" ");
            Write("okay calm down i didnt mean that, but yeah i did. wind is such a strong force that even the plants are scared of it."); wait();
            WriteLine(" ");
            Write("as we see MR.. 沃恩·马尔金's sunflower crying now, let him cry but atleast choose something appropriate now, will you? please "); wait();
            WriteLine(" ");
            WriteLine("no cheats here, use your brian to the fullest, yeah use it. ");





            menu("FIGHT BACK, fight back here means actually punching in the air LoL", "HOLD YOUR ROOTS HARDER, this one makes sense ngl ", "DIE PEACEFULLY, yeah the calmest thing we all gonna die so why not the plant", "卧槽，这是什么鬼？是中文的？, neither of us chinese bro");
            if (D1 == true)
            {
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                Write("What????????????"); wait();
                Write(" ");
                WriteLine("cmon bud youre just a plant, FIGHTING BACK? with what?"); Thread.Sleep(2000);


                selfishness += 1;

                stupidity += 12;
                plint += 2;
            }
            
            if (D2 == true)
            {
                Play(@"sfx/Unnervingsfx.wav");
                ForegroundColor = ConsoleColor.Red;
                Clear();
                ForegroundColor = ConsoleColor.Red;
                Write("You held your roots harder"); wait();
                Write(" ");
                WriteLine("you are strong bro but the wind is wind"); Thread.Sleep(2000);
                Write(" ");
                Clear();
                Play(@"sfx/marioMeowsfx.wav");
                Write("WIND: ts wasnt me bro ");
                selfishness += 5;
                stupidity += 4;
                plint += 8;

            }
            if (D3 == true)
            {
                badbeep();
                ForegroundColor = ConsoleColor.Red;
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("i knew you little plant would do that"); Thread.Sleep(2000);


                selfishness += 3;
                stupidity += 12;
                plint += 4;




            }
            if (D4 == true)
            {
                badbeep();
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("as ive said before, i dont know chinese either "); Thread.Sleep(4000);

                selfishness += 2;
                stupidity += 12;
                plint += 3;





            }
            ForegroundColor = ConsoleColor.Red;
                Write("SO YOUR STUPIDNESS BEING A PLANT IS " + stupidity); wait();
            WriteLine(" ");
            Write("SO YOUR SELFISHNESS BEING A PLANT IS " + selfishness); wait();
            WriteLine(" ");
            Write("SO YOUR GLOBAL SCORE AFTER BEING A PLANT IS " + plint); wait();
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
