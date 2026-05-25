using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeCode.MenuTest;
using static CodeCode.SoundUtils;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
namespace CodeCode
{
    internal class dolphin
    {
        private static int AbusePoint = 0;
        private static int OkayEnough = 0;
        private static int WereAllInThisTogether = 0;
        public static int AbusePoint1
        {
            get { return AbusePoint; }
        }

        public static int OkayEnough1
        {
            get { return OkayEnough; }
        }

        public static int WereAllInThisTogether1
        {
            get { return WereAllInThisTogether; }
        }
        public static void dolphinlife()
        {


            dolphinlife1();
            dolphinlife2();
            return;

        }


        public static void dolphinlife1()
        {
            Clear();

            Write("You are a dolphin. \r\nA Delphinus Delphis to be exact, known as a common dolphin "); ReadLine(); Write("Being a dolphin is pretty difficult"); ReadLine();
            WriteLine("But hey! At least you’re smart :) "); ReadLine(); Clear();
            WriteLine("Whilst swimming around your normal route, you found a pufferfish close to some corals. What will you do?");
            switch (menu("Approach it", "Leave it alone", "Tell your dolphin friends", "", 3))
            {
                case 'A':
                    AbusePoint += 5; okaybeep(); Clear();
                    Write("You approach the pufferfish"); ReadLine();
                    Write("The pufferfish looks quite scared, "); ReadLine();
                    Write("which does make sense as the next action you take is to chew on the pufferfish"); ReadLine();
                    WriteLine("You are "); ReadLine(); ForegroundColor = ConsoleColor.Green; Write("successfully high"); ResetColor(); ReadLine(); 
                    break;
                case 'B':
                    OkayEnough += 10; goodbeep(); Clear();
                    WriteLine("No need to bother the little poisonous guy;"); ReadLine(); Write(" we shall venture our route without fail, I dare say."); ReadLine();
                    break;
                case 'C':
                    AbusePoint += 10; badbeep(); Clear();
                    WereAllInThisTogether += 5;
                    WriteLine("You swim back to your buddies to tell them about your discovery, and they cheer"); ReadLine();
                    WriteLine("When you get back to the pufferfish, you all take a hit"); ReadLine();
                    Write("You and your dolphin bruvs are "); ReadLine(); ForegroundColor = ConsoleColor.Green; Write("successfully high"); ResetColor(); ReadLine();
                    break;
            }
            return;
        }

        static void dolphinlife2()
        {
            Clear();
            Write("After a long day’s work, you’re ready to go to sleep\r\n"); ReadLine();
            Write("You closed one eye, leaving the other one to watch out for danger\n"); ReadLine();
            Write("The ocean is full of surprises!\n"); ReadLine();
            Write("Just like....\n"); ReadLine();
            Write("Oh,"); ReadLine();  Write("my bad,"); ReadLine(); Write(" It’s just a really old looking fish\n"); ReadLine();
            Write("Wait,"); ReadLine();  Write(" I’m not that sleepy,"); ReadLine(); Write(" maybe I should play with it\n"); ReadLine();
            switch (menu("Man, I’m WAYY too sleepy for this", "A little play session doesn’t hurt", "Bob needs to see this", "Hit it with my fin", 4))
            {
                case 'A':
                    OkayEnough += 10; goodbeep(); Clear();
                    WriteLine("You go to sleep"); ReadLine();
                    Write("Honk shoo,"); ReadLine(); Write(" honk shoo\n"); ReadLine();
                    Write("You dream of a fun day of getting high on pufferfish while you eat fish to your dolphin hearts content\n"); ReadLine();
                    Write("ark ark ark ark\n"); ReadLine();
                    Write("(This is supposed to be Dolphin noises, idk what they sound like)"); ReadLine();
                    break;
                case 'B':
                    AbusePoint += 5; okaybeep(); Clear();
                    WriteLine("You ate it "); ReadLine();
                    WriteLine("Nom nom nom nom "); ReadLine();
                    WriteLine("Time to go back to sleep "); ReadLine();    
                    break;
                case 'C':
                    AbusePoint += 10; badbeep(); Clear();
                    WriteLine("");
                    break;
                case 'D':
                    AbusePoint += 10; badbeep(); Clear();
                    WriteLine("");
                    break;
            }
        }
    }
}
