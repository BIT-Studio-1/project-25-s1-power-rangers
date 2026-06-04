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

        public static void HumanLife1()
        {
            CursorVisible = false;
            Clear();
            Write("You are a homo sapien sapien"); ReadLine();
            Write("A human who loves to sit on a couch"); ReadLine();
            Write("Would you like to name the human?"); humanWait(); Write("Nahhhh, you don't get a choice, your name is Hugh Mann. Hue for short"); ReadLine();
            Clear();
            WriteLine("your pet cat, Alfredo Chicken is looking at you"); ReadLine();
            Write("I think he's hungry"); ReadLine();
            WriteLine("Feed him?");
            Meow();
            switch (menu("Feed my son", "Don't feed em'", "meow back", "", 3))
            {
                case 'A':
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
            Write("Alright, that was enough coding for human scene 1 -- I mean ehem."); ReadLine();
            Write("Lemme just clean that up ehem."); ReadLine(); Clear();
            Write("Now where was I?"); ReadLine();
            Write("Oh! Yes, that was enough participation for one day"); ReadLine();
            Write("I'm quite the tired Hue, I dare say to my internal monoloque."); ReadLine(); 
            Write("I teleported to the bedroom couch and took "); ForegroundColor = ConsoleColor.Yellow; Write("BIG. MASSIVE."); ResetColor(); Write(" steps to my bed"); ReadLine();
            Write("I tucked myself into bed and honk shooed, mimimi"); ReadLine();

        }
        public static void HumanLife2()
        {
            Clear();
            Write("Man Man, your bfffff in the world has come to visit you"); ReadLine();
            Write("In Man Man's hands, he has a caramel cheesecake and a cooler full of tropical juice"); ReadLine();
            Write("Do you like the food?"); ReadLine();
            switch (menu("No :[", "Yes :D", "Maybe", "", 3))
            {
                case 'A':
                    CursorVisible = false;
                    Write("'Man Man, I'm sorry..I don't like caramel chezcakez no moer nd alzo t3peecall joos'"); ReadLine();
                    Write("Man Man produced a single tear"); ReadLine();

                    break;
                case 'B':
                    CursorVisible= false;
                    Write(""); ReadLine();

                    break;
                case 'C':
                    CursorVisible= false;
                    Write(""); ReadLine();

                    break;
            }
            Write(""); ReadLine();
        }
        public static void HumanTotal()
        {
            CursorVisible = false;

            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Human Life"); Thread.Sleep(300);
            WriteLine($"How crazy you were: {SitOnCouch}" +
                $"\nHow Okay of a human you were: {Sure}" +
                $"\nHow good you were at being social: {Meow}"); ResetColor(); Write("\npress enter");
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
