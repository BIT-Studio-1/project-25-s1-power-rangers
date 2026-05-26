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
            CursorVisible = false;
            dolphinlife1();
            dolphinlife2();
            dolphinTotal();
            return;

        }


        public static void dolphinlife1()
        {
            Clear();

            Write("You are a dolphin. \nA Delphinus Delphis to be exact, known as a common dolphin "); ReadLine(); Write("Being a dolphin is pretty difficult"); ReadLine();
            WriteLine("But hey! At least you’re smart :) "); ReadLine(); Clear();
            WriteLine("Whilst swimming around your normal route, you found a pufferfish close to some corals. What will you do?");
            switch (menu("Approach it", "Leave it alone", "Tell your dolphin friends", "", 3))
            {
                case 'A':
                    AbusePoint += 5; okaybeep(); Clear();
                    Write("You approach the pufferfish"); ReadLine();
                    Write("The pufferfish looks quite scared, "); ReadLine();
                    Write("which does make sense as the next action you take is to chew on the pufferfish"); ReadLine();
                    Write("\nYou are "); ForegroundColor = ConsoleColor.Green; Write("successfully high"); ResetColor(); ReadLine();
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
                    Write("You and your dolphin bruvs are "); ForegroundColor = ConsoleColor.Green; Write("successfully high"); ResetColor(); ReadLine();
                    break;
            }
            return;
        }

        static void dolphinlife2()
        {

            int fishHP = 20, DolphinHP = 25;
            Clear();
            WriteLine("After a long day’s work, you’re ready to go to sleep"); ReadLine();
            WriteLine("You closed one eye, leaving the other one to watch out for danger"); ReadLine();
            WriteLine("The ocean is full of surprises!"); ReadLine();
            Write("Just like....\n"); ReadLine();
            Read(); Write("Oh, my bad,"); ReadLine(); Write(" It’s just a really old looking fish\n"); ReadLine();
            Read(); Write("Wait, I’m not that sleepy,"); ReadLine(); Write(" maybe I should play with it\n"); ReadLine();
            switch (menu("Man, I’m WAYY too sleepy for this", "Bob needs to see this", "Hit it with my fin", "", 3))
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
                    OkayEnough += 5; okaybeep(); Clear();
                    WereAllInThisTogether += 5;
                    WriteLine("You nudge your dolphin friend Bob, pointing at the really old fish "); ReadLine();
                    WriteLine("Ya’ll watch it like it was a TV program starring Jim Carrey "); ReadLine();
                    WriteLine("After a bit, you felt sleepier, so you hit the corals this time. "); ReadLine();
                    break;
                case 'C':
                    AbusePoint += 10; badbeep(); Clear();
                    fishHP -= 10;
                    WriteLine("Swimming to the really old fish, you used dolphin slap on it! "); ReadLine();
                    WriteLine("It was quite effective!"); ForegroundColor = ConsoleColor.Red; Write("   - 10 fish HP "); ResetColor(); ReadLine(); Clear();
                    WriteLine("You asked yourself,"); ReadLine();
                    WriteLine(" “How much fish HP does a really old fish have?!” "); ReadLine();
                    WriteLine("It’s 20. The really old fish has 20, but because you hit em’, it’s down by 10 fish HP "); ReadLine();
                    WriteLine("Do you want to hit it again ?"); ReadLine();
                    switch (menu("dolphin heaven YES", "dolphin heaven nahhhhh", "", "", 2))
                    {
                        case 'A':
                            AbusePoint += 10; badbeep(); Clear();
                            Random rand = new Random();
                            int ark = rand.Next(1,6);
                            int fih = rand.Next(6);
                            switch (ark)
                            {
                                case 5:
                                    fishHP -= 10;
                                    break;
                                case 4:
                                    fishHP -= 5;
                                    break;
                                case 3:
                                    fishHP -= 2;
                                    break;
                                default:
                                    WriteLine("You missed so badly that I should cry");
                                    break;
                            }
                            
                            if (fishHP>0)
                            {
                                switch (fih)
                                {
                                    case 5:
                                        break;
                                    case 4:
                                        break;
                                    case 3:
                                        break;
                                    default:
                                        break;
                                }
                            }

                            WriteLine(""); ReadLine();
                            break;
                        case 'B':
                            OkayEnough += 5; okaybeep(); Clear();
                            WriteLine(""); ReadLine();

                            break;

                    }
                    break;
            }
        }
        public static void dolphinTotal() 
        {
            ForegroundColor = ConsoleColor.Green; Clear();
            WriteLine("Dolphin Life"); Thread.Sleep(300);
            WriteLine($"How abusive you were: {AbusePoint}" +
                $"\nHow abnormal of a dolphin you were: {OkayEnough}" +
                $"\nHow good you were at bringin' your friends: {WereAllInThisTogether}"); ResetColor(); ReadLine();
        }
}
}
