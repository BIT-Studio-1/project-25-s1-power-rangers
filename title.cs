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
    internal class GameTitle
    {
        private static int start = 0;
        private static int end = 0;
        private static int WereAllInThisTogether = 0;
        public static int start1
        {
            get { return start; }
        }

        public static int end1
        {
            get { return end; }
        }

        public static void TitleScreen()
        {
            Clear();
            while (start == 0 && end == 0)
            {
                Write("Reincarnation Game\n\n");
                switch (menu("Start", "Credits", "Exit", "", 3))
                {
                    case 'A':
                        Clear();
                        start = 1;

                        break;
                    case 'B':
                        Clear();
                        Write("\n  ,ad8888ba,                                    88  88                      \r"); Thread.Sleep(400); 
                        Write("\n d8\"'    `\"8b                                   88  \"\"    ,d                \r"); Thread.Sleep(400);
                        Write("\nd8'                                             88        88                \r"); Thread.Sleep(400); 
                        Write("\n88             8b,dPPYba,   ,adPPYba,   ,adPPYb,88  88  MM88MMM  ,adPPYba,  \r"); Thread.Sleep(400);
                        Write("\n88             88P'   \"Y8  a8P_____88  a8\"    `Y88  88    88     I8[    \"\"  \r"); Thread.Sleep(400); 
                        Write("\nY8,            88          8PP\"\"\"\"\"\"\"  8b       88  88    88      `\"Y8ba,   \r"); Thread.Sleep(400);
                        Write("\n Y8a.    .a8P  88          \"8b,   ,aa  \"8a,   ,d88  88    88,    aa    ]8I  \r"); Thread.Sleep(400); 
                        Write("\n  `\"Y8888Y\"'   88           `\"Ybbd8\"'   `\"8bbdP\"Y8  88    \"Y888  `\"YbbdP\"'  \r\n\n"); Thread.Sleep(400);
                        Write("Developed by: The Power Rangers\n\n"); Thread.Sleep(500);
                        Write("Benjamin Roberts\n"); Thread.Sleep(500);
                        Write("Nishachyjit Nishachyjit\n"); Thread.Sleep(500);
                        Write("Daniil Piatov\n"); Thread.Sleep(500);
                        Write("David Knauf\n"); Thread.Sleep(500);
                        Write("Nathalie Chang"); Thread.Sleep(500);
                        Write("\n\n\nPress any key to return to the title screen...");
                        ReadLine();
                        Clear();
                        break;
                    case 'C':
                        Clear();
                        end = 1;
                        WriteLine("Please come back soon! :'(");
                        break;
                }
            }

            return;
        }
    }


    
}
