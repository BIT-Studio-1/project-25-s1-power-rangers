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
        public static void AmoebaLife()
        {
            AmoebaScene1();
        }
        static void AmoebaScene1()
        {
            
            Clear();
            WriteLine("You've spawned in as an Amoeba");
            WriteLine("This is the beginning");
            WriteLine("You have no eyes to see, no nose to smell, no tongue to taste");
            WriteLine("Senses are very minimal");
            WriteLine("Life as an Amoeba is very 'Slide about'");

            switch (menu("Try to see", "try to smell", "Try to taste", "Slide about", 4))
            {
                case 'A': badbeep(); break;
                case 'B': badbeep(); break;
                case 'C': badbeep(); break;
                case 'D': goodbeep(); break;
            }
            
            Clear();
            WriteLine("Amoeba life is slow but not completely frozen");
            WriteLine("As a unicellular eukaryotic organism you don't have many choices");
            WriteLine("What would you like to try next?");

            switch (menu("Contract Vacuoles","Granulise endoplasm","Binary fission","Just survive", 4))
            {
                case 'A': badbeep(); break;
                case 'B': badbeep(); break;
                case 'C': goodbeep(); break;
                case 'D': badbeep(); break;
            }

            Clear();
            WriteLine("Congratulations! Your time as an Amoeba was short but sweet, it's time to move onto the next life!");
            WriteLine("Please press enter to continue");
            ReadLine();

            return;
        }

    }
}
