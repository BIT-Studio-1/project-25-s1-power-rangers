using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using static CodeCode.SoundUtils;
using static CodeCode.Fish;
using static System.Console;
using static System.ConsoleKey;
using static CodeCode.Starfish;
using static CodeCode.dolphin;
using static CodeCode.GameTitle;
using static CodeCode.plant;
using static CodeCode.bird;
using static CodeCode.Human;
using static CodeCode.Sasquatch;
using static CodeCode.worm;
using System.ComponentModel.Design;
using static CodeCode.Program;

namespace CodeCode
{
    internal class Amoeba
    {
        public static void amoebaLife()
        {
            amoebaScene1();
        }
        static void amoebaScene1()
        {
            int selfishness = 50;
            int stupidity = 50;
            int bravery = 0;
            Clear();
            WriteLine("You've spawned in as an Amoeba");
            WriteLine("This is the beginning");
            WriteLine("You have no eyes to see, no nose to smell, no tongue to taste");
            WriteLine("Senses are very minimal");
            WriteLine("Life as an Amoeba is very 'Slide about'");

            switch (menu("Try to see", "try to smell", "Try to taste", "Slide about", 4))
            {
                case 'A': stupidity += 10; badbeep(); break;
                case 'B': stupidity += 10; badbeep(); break;
                case 'C': stupidity += 10; badbeep(); break;
                case 'D': stupidity -= 10; goodbeep(); break;
            }

            Clear();
            WriteLine("Amoeba life is slow");
            WriteLine("Amoeba");


            // add more questions
            Write("Ameba life is so slow that life turns into death and Ameoba dies     (press enter)"); ReadLine();
            return;
        }

    }
}
