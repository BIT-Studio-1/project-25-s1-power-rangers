using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeCode.Program;
using static CodeCode.SoundUtils;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
namespace CodeCode
{
    internal class Human
    {
        private static int SitOnCouch = 0;
        private static int Sure = 0;
        private static int Meow = 0;
        private static int money = 67;
        private static string name;

        public static int SitOnCouch1
        {
            get { return SitOnCouch; }
        }

        public static int Sure1
        {
            get { return Sure; }
        }

        public static int Meow1
        {
            get { return Meow; }
        }


        public static void HumanLife()
        {
            CursorVisible = false;
            HumanLife1();

            HumanTotal();
            return;

        }

        private static void humanWait(int time = 500)
        {
            CursorVisible = false;
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".\n");
            Thread.Sleep(time);

        }
        private static void humanWait1(int time = 500)
        {
            CursorVisible = false;
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time); Write(".");
            Thread.Sleep(time);

        }



        public static void HumanLife1()
        {
            CursorVisible = false;
            Clear();
            Write("You are a homo sapien sapien"); ReadLine();
            Write("A human who loves to sit on a couch\n"); ReadLine();
            Write("Would you like to name the human?\n"); 
            CursorVisible = true;
            name = ReadLine();
            CursorVisible = false;
            Write("\nOh"); humanWait1(); Write("Sorry, I think you forgot that your name is already Hugh Mann"); humanWait1(); Write(" Hue for short"); ReadLine();
            Clear();
            Write("your pet cat, Alfredo Chicken is looking at you");  humanWait1(); Meow(); humanWait();
            Write("I think he's hungry\n"); ReadLine(); 
            WriteLine("Feed him?");
            switch (menu("Feed my son", "Don't feed em'", "meow back", "", 3))
            {
                case 'A':
                    Clear();
                    CursorVisible = true;
                    Meow();
                    Meow += 5;
                    SitOnCouch += 2;
                    Sure += 3;
                    Write("Alfredo Chicken is calling for you"); humanWait(); Write("You must feed him"); ReadLine();
                    Write("You teleported to the kitchen couch and got Alfredo Chicken's favourite food, deluxe tuna from the pacific ocean that was caught yesterday");  humanWait();
                    Write("specifically for Alfredo Chicken, as your cat lives in luxury"); ReadLine();
                    Write("Alfredo Chicken meows happily as he eats like a cat"); Meow(); ReadLine();
                    Write("Which he is a cat, "); ForegroundColor = ConsoleColor.Green; Write("hopefully"); ReadLine(); ResetColor();
                    break;
                    Meow();
                case 'B':
                    Clear();
                    CursorVisible = false;
                    Meow();
                    SitOnCouch += 3;
                    Meow -= 2;
                    Write("You think to yourself, your cat needs to learn how to survive the wilderness"); humanWait();
                    Write("So you teleport your cat to the porch couch"); ReadLine();
                    Write("Alfredo Chicken is in distraught from the sudden change of environment"); Meow(); ReadLine();
                    Write("Don't you hear his meow of sorrow? Of fear?? Of betrayal???"); Meow(); ReadLine();
                    break;
                case 'C':
                    Clear();
                    CursorVisible = false;
                    Meow += 7;
                    SitOnCouch += 1;
                    Sure += 1;
                    HumanMeow();
                    Write("Your meow was so powerful, your cat is agape with fear"); ReadLine();
                    Write("Alfredo Chicken sees you as the big gato now and meows back (gato is spanish for cat)"); Meow(); ReadLine(); 
                    Write("So, you meow back again"); HumanMeow(); ReadLine();
                    Write("What an eventful conversation with Alfredo Chicken"); ReadLine();
                    break;
            }
            Clear();
            Write("Yawn, yawn, yawn. It seems you have grown tired"); ReadLine(); 
            Write("Teleporting to the bedroom couch, you took "); ForegroundColor = ConsoleColor.Yellow; Write("BIG. MASSIVE."); ResetColor(); Write(" steps to your bed"); ReadLine();
            Write("You tucked yourself into bed and honk shooed, mimimi"); ReadLine();
        }
        public static void HumanLife2()
        {
            Clear();
            Write("Next Day"); humanWait();
            Clear();
            Write("Just waking up, you feel groggy and certainly want something to eat"); ReadLine();
            Write("You teleported to the kitchen couch and just like clockwork, you hear a knock at the front door"); ReadLine();
            ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(", your bfffff in the world has come to visit you"); ReadLine();
            Write("In "); ForegroundColor = ConsoleColor.Blue; Write("Man Man's"); ResetColor(); Write(" hands, he has a caramel cheesecake and a cooler full of tropical juice"); ReadLine();
            Write("Do you like the food?"); 
            switch (menu("No :[", "Yes :D", "Maybe", "", 3))
            {
                case 'A':
                    Clear();
                    CursorVisible = false;
                    SitOnCouch += 5; Sure -= 1;
                    Write("'"); ForegroundColor = ConsoleColor.Blue;Write("Man Man"); ResetColor(); Write(", I'm sorry..I don't like caramel chezcakez no moer nd alzo t3peecall joos'\n"); ReadLine();
                    ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(" produced a single tear"); ReadLine();
                    Write("'It's okay, "); ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor();  
                    Write(" was just thinking of how much we bonded together while we shared a whole caramel cheesecake with some tropical juice for years now"); humanWait1(); Write("'"); ReadLine();
                    Write("'I just wanted to make you happy'"); humanWait1(); ForegroundColor = ConsoleColor.Blue; Write(" Man Man"); ResetColor(); Write(" looked at you with teary eyes\n"); ReadLine();
                    Write("As you think back to all the memories you somehow forgot, you realised how much you cared for "); ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write("."); ReadLine();
                    Write("\nBut"); humanWait1(); Write(" you realised to late."); ReadLine();
                    ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(" was so heartbroken that he teleported away and never came back"); ReadLine(); Clear();
                    Write("You sat there, wishing he'd come back"); ReadLine(); Write("Wishing that you hadn't hurt him so bad"); ReadLine(); 
                    Write("Wishing that you could take back what you said"); ReadLine(); Write("Wishing that you could just have one more caramel cheesecake and tropical juice with him"); ReadLine();
                    Write("But it was too late."); ReadLine();
                    Clear();
                    Write("You blacked out somehow and found yourself in a casino"); ReadLine();
                    Write("Bright lights filled your vision as you sway left and right to a "); humanWait1();
                    Random rand = new Random(); int gamba = rand.Next(5); string quit = "no";
                    switch (gamba)
                    {
                        case 5:
                            int balls = 0;
                            Write("pachinko machine."); ReadLine(); Clear();
                            do
                            {
                                Write($"you have ${money} to your name"); ReadLine(); Clear(); 
                                Write("you bought pack of "); ReadLine(); Clear();
                                Write("_+===Pachinko Machine===+_"); ReadLine();
                                Write("1"); ReadLine();
                                Write("1"); ReadLine();
                                Write("1"); ReadLine();
                                Write("Do you wanna quit?\n(yes or no)"); 
                                CursorVisible = true;
                                quit = ReadLine();
                                CursorVisible = false;
                            } while (money > 0 && quit != "yes");


                            break;
                        case 4:
                            Write("slot machine."); ReadLine();
                            Write("1"); ReadLine();
                            Write("1"); ReadLine();

                            break;
                        case 3:
                            Write("roulette table."); ReadLine();
                            Write("1"); ReadLine();
                            Write("1"); ReadLine();
                            Write("1"); ReadLine();

                            break;
                        default:
                            Write("mario kart 8 deluxe game"); ReadLine();
                            Write("1"); ReadLine();
                            Write("1"); ReadLine();

                            break;
                    }


                    break;
                case 'B':
                    Clear();
                    CursorVisible = false;
                    SitOnCouch -= 5; Sure += 10;
                    Write("I love them"); ReadLine();
                    ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(", I am so happy you are my friend Man Man"); ReadLine();

                    break;
                case 'C':
                    Clear();
                    CursorVisible = false;
                    HumanMeow();
                    Write("meow"); ReadLine();

                    break;
            }
            Write(""); ReadLine();
        }
        public static void HumanTotal()
        {
            CursorVisible = false;

            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine($"{name}'s Life"); Thread.Sleep(300);  Clear(); WriteLine($"Hughs's Life"); Thread.Sleep(300);
            WriteLine($"How couch you were: {SitOnCouch}" +
                $"\nHow Okay of a human you were: {Sure}" +
                $"\nHow happy your cat was: {Meow}"); ResetColor(); Write("\npress enter");
            SitOnCouch = SitOnCouch - Sure;

            /*
            if (SitOnCouch <= 0)
            {
            }
            if (SitOnCouch > 0)
            {
                if (SitOnCouch > 30)
                {
                }

                else
                {
                }
            } 
            
            */
            ReadLine();
            Clear();
        }
    }
}
