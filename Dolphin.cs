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

            WriteLine("You are a dolphin. \r\nA Delphinus Delphis to be exact, known as a common dolphin \r\n\r\nBeing a dolphin is pretty difficult."); ReadLine();
            WriteLine("But hey! At least you’re smart :) "); ReadLine(); Clear();
            WriteLine("Whilst swimming around your normal route, you found a pufferfish close to some corals. What will you do?");
            switch (menu("Approach it", "Leave it alone", "Tell your dolphin friends", "", 3))
            {
                case 'A':
                    AbusePoint += 5; okaybeep(); Clear();
                    WriteLine("You approach the pufferfish \r\n\r\n" +
                        "The pufferfish looks quite scared, " +
                        "which does make sense as the next action you take is to chew on the pufferfish."); Thread.Sleep(100);
                    WriteLine("You are successfully high");
                    break;
                case 'B':
                    OkayEnough += 10; goodbeep(); Clear();
                    WriteLine("No need to bother the little poisonous guy; we shall venture our route without fail, I dare say.");
                    break;
                case 'C':
                    AbusePoint += 10; badbeep(); Clear();
                    WereAllInThisTogether += 5;
                    WriteLine("You swim back to your buddies to tell them about your discovery, and they cheer."); Thread.Sleep(100);
                    WriteLine("When you get back to the pufferfish, you all take a hit"); Thread.Sleep(100);
                    WriteLine("You and your dolphin bruvs are successfully high");
                    break;
            }
            return;
        }

        static void dolphinlife2()
        {
            Clear();
            WriteLine("After a long day of swimming around, you and your dolphin friends are chilling on the surface, enjoying the sun. \r\n\r\n" +
                "You see a boat coming towards you, and it looks like it’s going to pass by you. What do you do?"); ReadLine();
            switch (menu("Swim away", "Wave at the boat", "Jump out of the water and do a flip", "", 3))
            {
                case 'A':
                    OkayEnough += 10; goodbeep(); Clear();
                    WriteLine("You swim away from the boat, not wanting to cause any trouble. The boat passes by without incident.");
                    break;
                case 'B':
                    AbusePoint += 5; okaybeep(); Clear();
                    WriteLine("You wave at the boat, hoping to get some attention. The people on the boat wave back, but they don’t seem to notice you.");
                    break;
                case 'C':
                    AbusePoint += 10; badbeep(); Clear();
                    WriteLine("You jump out of the water and do a flip, trying to impress the people on the boat. They cheer and take pictures of you.");
                    break;
            }
        }
    }
}
