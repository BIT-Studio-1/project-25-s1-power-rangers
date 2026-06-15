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
            HumanLife2();
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
            CursorVisible = true; ForegroundColor = ConsoleColor.Green;
            name = ReadLine(); ResetColor();
            CursorVisible = false;
            Write("\nOh"); humanWait1(); Write("Sorry, I think you forgot that your name is already"); ForegroundColor = ConsoleColor.DarkGreen; Write(" Hugh Mann"); ResetColor(); 
            humanWait1(); ForegroundColor = ConsoleColor.DarkGreen; Write(" Hue"); ResetColor(); Write(" for short"); ReadLine();
            Clear();
            Write("your pet cat,"); ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write(" is looking at you");  humanWait1(); Meow(); humanWait();
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
                    ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write(" is calling for you"); humanWait(); Write("You must feed him"); ReadLine();
                    Write("You teleported to the kitchen couch and got "); ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write("'s favourite food, deluxe tuna from the pacific ocean that was caught yesterday");  humanWait();
                    Write("specifically for "); ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write(", as your cat lives in luxury"); ReadLine();
                    ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write(" meows happily as he eats like a cat"); Meow(); ReadLine();
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
                    ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write(" is in distraught from the sudden change of environment"); Meow(); ReadLine();
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
                    ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write(" sees you as the big gato now and meows back (gato is spanish for cat)"); Meow(); ReadLine(); 
                    Write("So, you meow back again"); HumanMeow(); ReadLine();
                    Write("What an eventful conversation with "); ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); ReadLine();
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
            Write("In "); ForegroundColor = ConsoleColor.Blue; Write("Man Man's"); ResetColor(); Write(" hands, he has a "); 
            ForegroundColor = ConsoleColor.Magenta; Write("caramel cheesecake"); ResetColor(); Write(" and a cooler full of"); 
            ForegroundColor = ConsoleColor.Magenta; Write(" tropical juice"); ReadLine(); ResetColor();
            Write("Do you like the food?"); 
            switch (menu("No :[", "Yes :D", "Maybe", "", 3))
            {
                case 'A':
                    Clear();
                    CursorVisible = false;
                    SitOnCouch += 5; Sure -= 1;
                    Write("'"); ForegroundColor = ConsoleColor.Blue;Write("Man Man"); ResetColor(); Write(", I'm sorry..I don't like"); 
                    ForegroundColor = ConsoleColor.Magenta; Write(" caramel chezcakez"); ResetColor(); Write(" no moer nd alzo"); ForegroundColor = ConsoleColor.Magenta; Write(" t3peecall joos"); ResetColor(); Write("'\n"); ReadLine();
                    ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(" produced a single tear"); ReadLine();
                    Write("'It's okay, "); ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor();  
                    Write(" was just thinking of how much we bonded together while we shared a whole "); 
                    ForegroundColor = ConsoleColor.Magenta; Write("caramel cheesecake"); ResetColor(); 
                    Write(" with some "); ForegroundColor = ConsoleColor.Magenta; Write("tropical juice "); ResetColor(); Write("for years now"); humanWait1(); Write("'"); ReadLine();
                    Write("'I just wanted to make you happy'"); humanWait1(); ForegroundColor = ConsoleColor.Blue; Write(" Man Man"); ResetColor(); Write(" looked at you with teary eyes\n"); ReadLine();
                    Write("As you think back to all the memories you somehow forgot, you realised how much you cared for "); ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write("."); ReadLine();
                    Write("\nBut"); humanWait1(); Write(" you realised to late."); ReadLine();
                    ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(" was so heartbroken that he teleported away and never came back"); ReadLine(); Clear();
                    Write("You sat there, wishing he'd come back"); ReadLine(); Write("Wishing that you hadn't hurt him so bad"); ReadLine(); 
                    Write("Wishing that you could take back what you said"); ReadLine(); Write("Wishing that you could just have one more ");
                    ForegroundColor = ConsoleColor.Magenta; Write("caramel cheesecake"); ResetColor(); Write(" and"); ForegroundColor = ConsoleColor.Magenta; Write(" tropical juice"); ResetColor(); Write(" with him"); ReadLine();
                    Write("But it was too late."); ReadLine();
                    Clear();
                    Write("You blacked out somehow and found yourself in a casino"); ReadLine();
                    Write("Bright lights filled your vision as you sway left and right to a "); humanWait1();
                    Random rand = new Random(); int gamba = rand.Next(5); string quit = "no";
                    switch (gamba)
                    {
                        case 5:
                            int balls = 0;
                            Write("online horse racing section."); ReadLine(); Clear();
                            Write($"you have no money and no patients to your name, so you left neighing and neighing"); ReadLine(); Clear(); 
                            break;
                        case 4:
                            Write("slot machine."); ReadLine();
                            Write($"you have no money and luck to your name, so you left while making slot machine hand gestures, kaching, kaching, kaching"); ReadLine(); Clear();
                            break;
                        case 3:
                            Write("a rhythm game."); ReadLine();
                            Write($"you have no money and skillz to your name, so you left wwaving your hands to the beat of the casino lobby music"); ReadLine(); Clear();
                            break;
                        default:
                            Write("mario kart 8 deluxe game"); ReadLine();
                            Write($"you have no money to your name and also no friend to play with, so you left"); humanWait1(); Write(" mama mia"); ReadLine(); Clear();
                            break;
                    }
                    Write($"while on the streets of New hampshire, you saw "); ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(" with a familiar face"); humanWait(); 
                    ForegroundColor = ConsoleColor.Green; Write(name); ResetColor(); ReadLine();
                    Write("The scene blinded you, jumping into the road"); ReadLine();
                    Write("When you finally regained your sight, you felt like a deer in the headlights"); ReadLine();
                    Write("You were hit by a car and died"); ReadLine();
                    break;
                case 'B':
                    Clear();
                    CursorVisible = false;
                    SitOnCouch -= 5; Sure += 10;
                    Write("'I love them'"); ReadLine();
                    Write("'"); ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(", I am so happy you are my friend"); ForegroundColor = ConsoleColor.Blue; Write(" Man Man"); ResetColor(); Write("'"); ReadLine();
                    Write("You guys watched all the Cars movies"); ReadLine(); Clear();
                    ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(" became your best man for your wedding, he took the first photo of you and your kid together"); ReadLine();
                    ForegroundColor = ConsoleColor.Blue; Write("Man Man"); ResetColor(); Write(" was there for you when "); ForegroundColor = ConsoleColor.Yellow; Write("Alfredo Chicken"); ResetColor(); Write("combusted"); ReadLine();
                    Write("Truly"); humanWait1(); Write("  your best friend"); ReadLine();
                    Write("You died of old age"); ReadLine();

                    break;
                case 'C':
                    Clear();
                    SitOnCouch = 100000000; Sure = 2; 
                    CursorVisible = false;
                    HumanMeow();
                    Write("meow"); ReadLine();
                    Write("You combusted into a ball of flames"); ReadLine(); humanWait(); Write("You died"); ReadLine();

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
