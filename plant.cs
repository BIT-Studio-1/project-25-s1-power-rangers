using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
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
        private static int stupidity = 20;
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
          
            Write("You are reincarnated as a"); wait(700);
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("     PLANT");
            ResetColor();
            Write("YOURE A SUNFLOWER IN THE VALLEYS OF DUNEDIN IN MR. 沃恩·马尔金'S GARDEN. I HAVE SPENT MOST OF MY LIFE LISTENING TO HIM ABOUT MAKING SQL DATABASES."); wait();
            Write("IT IS NOW THE TIME TO DECIDE YOUR DESTINY"); wait();
            Write("You're just chilling in the garden"); wait(700);
            ForegroundColor = ConsoleColor.Red;
            Write("When a bee tries to extract pollen from you (which is a bad thing for you)"); wait(700);
            switch (menu("LET BEE EXTRACT HONEY, oh yeah she gonna steal it from you. I don't think its very wise to let it happen", "KILL THE BEE INSTEAD, Are you a killer? psychopath? hell nah bro", "FIGHT BACK, Be a hero here the dragons are coming after bees ", "NONE OF THESE, Sybau I know you wont click it"))
            {
                case 'A':
                    badbeep();
                    Clear();                   
                    Write("Why you so stupid bro, you gave up for nothing"); wait();
                    plint += 0;
                    stupidity += 8;
                    selfishness -= 3;
                    break;
                case 'B':
                    Play(@"sfx/Suspensesfx.wav");
                    Clear();                  
                    Write("Gawd DAMN you a killer?????? an innocent bee bro she was innocent bee"); wait();
                    plint -= 3;
                    selfishness += 8;
                    stupidity += 6;
                    break;
                case 'c':
                    Play(@"sfx/epicsfx.wav");
                    Clear();                   
                    Write("Oh yeah that was a wise move but you're just plant bro, the bee queen is laughing at you"); wait();
                    plint += 3;
                    selfishness += 9;
                    stupidity += 3;
                    break;
                case 'D':
                    goodbeep();
                    Clear();                  
                    Write("Okay yeah do nothing? why in the world did you choose this?"); wait();
                    plint += 3;
                    selfishness += 8;
                    stupidity += 4;
                    break;
            }
            Clear();
            WriteLine("Oh myyyyyyyyyyy Gawdddddddddddd what you just did..........?");
            WriteLine(" ");
            WriteLine("IDKKKKKK you shouldn't have done that (i don't really care what u did bro -_-)");
            WriteLine(" ");
            Write("Hang tight dude"); wait(700);
            ForegroundColor = ConsoleColor.Red;
            Write("USA VS VENEZUELA OIL EXTRACTION, we all know about hostilities that was done by USA just for the oil of Venezuela. maybe oil maybe just the love of game"); wait(700);
            Write("We never know btw, LETSSSSSS GOOO"); wait();
            Write("A human is trying to extract oil from you same as USA tried to extract oil from the Venezuela by capturing its President"); wait(); 

            switch (menu("KILL THE EXTRACTOR, what i mean by that is literal killing. Isn't it bad enough? haha ", "LET IT HAPPEN, shut up what you gonna do? huh what?", "SUICIDE, ummm yeah nah maybe but killing yourself is not gonna be a really good option bro", "NONE OF THESE, choose nothing and feel shameful i know you wont choose this, will you? c'mon now "))
            {
                case 'A':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    Write("Yeah you're a killer bro, i get it but  it wasn't even valid here"); wait();
                    selfishness += 9;
                    stupidity += 10;
                    plint -= 2;
                    break;

                case 'B':
                    Play(@"sfx/Dramasfx.wav");
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    Write("Giving up is never a good option, have you ever watched JOHN CENA in WWE?"); wait();
                    selfishness += 2;
                    stupidity += 10;
                    plint += 8;
                    break;
                case 'C':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    Write("C'mon bro you shouldn't have done this you're a plant, you cannot kill yourself by your own hahaha"); wait();
                    selfishness += 0;
                    stupidity += 10;
                    plint -= 1;
                    break;
                case 'D':
                    goodbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    Write("Eat five star and do nothing type shi, but you must do something if this happens in real life"); wait();
                    selfishness += 7;
                    stupidity += 5;
                    plint += 10;
                    break;
            }
            ResetColor();
            Clear();
            Write("DOG AND HIS POOP, even i don't know why this is part of the game. Try harder and don't be stupid now"); wait();
            Write("Okay calm down now, I know what you are thinking. its not that tuff bro but here we are"); wait();
            Write("A dog is attempting to poop on you, so try your best bro                      Ikr this is an absurd idea"); wait();
            ForegroundColor = ConsoleColor.Red;
            Write("Yeah Yeah, IK but it is a real thing, dogs do poop on plants. It's my bad if you haven't seen one doing this"); wait();
            Write("What do you do?"); wait();
            ResetColor();
            switch (menu("LET HIM DO IT, i know you let it happen i know ", "KILL HIM, you killer? please don't do it bro", "DO NOTHING, this doesn't mean doing nothing it does mean actually doing nothing ", "SMILE AT HIM, smiles can change the world, keep smiling bro you are in the presence of great MR.沃恩·马尔金"))
            {

                case 'A':
                    badbeep();
                    Clear();
                    EpicSFX();
                    ForegroundColor = ConsoleColor.Red;
                    Write("Did you let it happen are you crazy? i think so okay whatever now GO CLEAAANNNNNNN YOURRRSELFFFFFF"); wait();
                    selfishness -= 5;
                    stupidity += 12;
                    plint += 2;
                    break;

                case 'B':
                    badbeep();
                    Clear();
                    Suspense2SFX();
                    ForegroundColor = ConsoleColor.Red;
                    Write("You attempted to kill him, but you are just a mere fool plant, so it didn't amount to anything."); wait();
                    selfishness += 1;
                    stupidity += 10;
                    plint -= 8;
                    break;

                case 'C':
                    goodbeep();
                    Clear();
                    SuspenseSFX();
                    ForegroundColor = ConsoleColor.Red;
                    Write("You did nothing means you let that happen, GOOOO AND CLEANNNN YOURSELFFFFFF"); wait(900);
                    selfishness -= 5;
                    stupidity += 10;
                    plint -= 3;
                    break;
                case 'D':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    DramaSFX();
                    Write("Yeah that was smart move but he still pooped on you"); wait();
                    Write("LMAOOOOOOOOOO"); wait(1000);
                    selfishness -= 3;
                    stupidity += 12;
                    plint += 3;
                    break;
            }
            ResetColor();
            Clear();
            HellYeah();
            Write("Man that dog sure has no manners"); wait();
            WriteLine(" ");
            Write("You have made really absurd choices till now but here we are again"); wait();
            Write("GAME OF WINDS, we all know wind is a really strong force? is it visible? nah, right? try standing on the top of a mountain and answer this you fool."); wait();
            WriteLine(" ");
            ForegroundColor = ConsoleColor.Red;
            Write("Okay calm down I didn't mean that, but yeah I did. Wind is such a strong force that even the plants are scared of it."); wait();
            WriteLine(" ");
            Write("As we see MR.. 沃恩·马尔金's sunflower crying now, let him cry but at least choose something appropriate now, will you? please "); wait();
            WriteLine(" ");
            WriteLine("No cheats here, use your brain to the fullest, yeah use it. ");
            switch (menu("FIGHT BACK, fight back here means actually punching in the air LoL", "HOLD YOUR ROOTS HARDER, this one makes sense ngl ", "DIE PEACEFULLY, yeah the calmest thing we all gonna die so why not the plant", "卧槽，这是什么鬼？是中文的？, neither of us Chinese bro"))
            {

                case 'A':
                    badbeep();
                    Clear();
                    HellYeah();
                    ForegroundColor = ConsoleColor.Red;
                    Write("What????????????"); wait();
                    Write(" ");
                    Write("C'mon bud you're just a plant, FIGHTING BACK? with what?"); wait();
                    selfishness += 1;
                    stupidity += 12;
                    plint -= 2;
                    break;
                case 'B':
                    Unnerving2SFX();
                    ForegroundColor = ConsoleColor.Red;
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    Write("You held your roots harder"); wait();
                    WriteLine("You are strong bro but the wind is wind"); wait(700);
                    Clear();
                    goodbeep();
                    Write("WIND: ts wasn't me bro"); wait();
                    selfishness += 5;
                    stupidity -= 4;
                    plint += 15;
                    break;
                case 'C':
                    badbeep();
                    ForegroundColor = ConsoleColor.Red;
                    Clear();
                    eagleSFX();
                    ForegroundColor = ConsoleColor.Red;
                    Write("I knew you little plant would do that"); wait();
                    selfishness -= 3;
                    stupidity += 12;
                    plint += 4;
                    break;
                case 'D':
                    badbeep();
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    Write("As i have said before, i don't know Chinese either "); wait();
                    selfishness += 2;
                    stupidity += 12;
                    plint -= 3;
                    break;
            }
            ForegroundColor = ConsoleColor.Red;
            Suspense2SFX();
            PlantTotal();
            Console.ResetColor();
            return;
        }
       public static void  PlantTotal()
        {
            //globalScore += plint - stupidity - selfishness;
            Clear();
            ForegroundColor = ConsoleColor.Red;
            Write("SO YOUR STUPIDNESS BEING A PLANT IS " + stupidity); wait();
            WriteLine(" ");
            Suspense2SFX();
            ResetColor();
            ForegroundColor = ConsoleColor.DarkRed;
            Write("SO YOUR SELFISHNESS BEING A PLANT IS " + selfishness); wait();
            WriteLine(" ");
            ResetColor  ();
            ForegroundColor = ConsoleColor.Green;
            Write("SO YOUR PLANTNESS BEING ONE IS " + plint); wait();
            WriteLine(" ");
            Suspense2SFX();
            ResetColor  ();
            WriteLine("PLEASE PRESS ENTER TO CONTINUE");
            ReadLine();
        }
        public static void plantLife()
        {
            plint = 20;
            selfishness = 20;
            stupidity = 20;
            plantScene1();
            return;
        }
    }
}
