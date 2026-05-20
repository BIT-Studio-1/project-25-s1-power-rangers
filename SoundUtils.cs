using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCode
{
    public class SoundUtils
    {
        public static async Task goodbeep()
        {
            await Task.Run(() =>
            {
                Beep(698, 50);
                Beep(880, 50);
                Beep(1046, 50);
                Beep(1397, 70);
            });
        }
        public static async Task badbeep()
        {
            await Task.Run(() =>
            {
                Beep(1175, 70);
                Beep(988, 50);
                Beep(831, 50);
                Beep(698, 50);
            });
        }
        public static async Task okaybeep()
        {
            await Task.Run(() =>
            {
                Beep(698, 50);
                Beep(784, 50);
                Beep(1046, 50);
                Beep(784, 70);
            });
        }

    }
}
