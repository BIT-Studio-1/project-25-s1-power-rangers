using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Media;

namespace CodeCode
{
    public class SoundUtils
    {
        static SoundPlayer player;

        public static void Play(string filePath)
        {
            player = new SoundPlayer(filePath);
            player.Play(); // non-blocking

        }
        public static void Stop()
        {
            player?.Stop();
        }


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
        public static void SuspenseSFX()
        {
            Play(@"sfx/SuspenseSFX.wav");
        }
        public static void Suspense2SFX()
        {
            Play(@"sfx/Suspense2SFX.wav");
        }
        public static void Unnerving2SFX()
        {
            Play(@"sfx/UnnervingSFX.wav");
        }
        public static void DramaSFX()
        {
            Play(@"sfx/DramaSFX.wav");
        }
        public static void EpicSFX()
        {
            Play(@"sfx/epicsfx.wav");
        }
        public static void HellYeah()
        {
            Play(@"sfx/HellYeah.wav");
        }
        public static void Meow()
        {
            Play(@"sfx/marioMeowh.wav");
        }
    }
}
