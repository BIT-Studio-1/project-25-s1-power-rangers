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
    internal class GameTitle
    {
        private static int start = 0;
        private static int end = 0;
        public static int start1
        {
            get { return start; }
        }

        public static void Wait()
        {
            CursorVisible = false;
            Thread.Sleep(500); Write(".");
            Thread.Sleep(500); Write(".");
            Thread.Sleep(500); Write(".");
            Thread.Sleep(500);
            CursorVisible = true;

        }

        public static int end1
        {
            get { return end; }
        }

        public static void TitleScreen()
        {
            CursorVisible = false;

            Clear();
            while (start == 0 && end == 0)
            {
                ForegroundColor = ConsoleColor.Red;

                Write(":::::::..  .,::::::  ::::::.    :::.  .,-:::::   :::.    :::::::..   "); Thread.Sleep(50);
                Write("\r\n;;;;``;;;; ;;;;''''  ;;;`;;;;,  `;;;,;;;'````'   ;;`;;   ;;;;``;;;;  "); Thread.Sleep(50);
                Write("\r\n [[[,/[[['  [[cccc   [[[  [[[[[. '[[[[[         ,[[ '[[,  [[[,/[[['  " ); Thread.Sleep(50);
                Write("\r\n $$$$$$c    $$\"\"\"\"   $$$  $$$ \"Y$c$$$$$        c$$$cc$$$c $$$$$$c    "); Thread.Sleep(50);
                Write("\r\n 888b \"88bo,888oo,__ 888  888    Y88`88bo,__,o, 888   888,888b \"88bo,"); Thread.Sleep(50);
                Write("\r\n MMMM   \"W\" \"\"\"\"YUMMMMMM  MMM     YM  \"YUMMMMMP\"YMM   \"\"` MMMM   \"W\" "); Thread.Sleep(50);
                Write("\r\n\r\n:::.    :::.  :::. :::::::::::::::    ...   :::.    :::."); Thread.Sleep(50);
                Write("\r\n`;;;;,  `;;;  ;;`;;;;;;;;;;'''';;; .;;;;;;;.`;;;;,  `;;;"); Thread.Sleep(50);
                Write("\r\n  [[[[[. '[[ ,[[ '[[,   [[     [[[,[[     \\[[,[[[[[. '[["); Thread.Sleep(50);
                Write("\r\n  $$$ \"Y$c$$c$$$cc$$$c  $$     $$$$$$,     $$$$$$ \"Y$c$$"); Thread.Sleep(50);
                Write("\r\n  888    Y88 888   888, 88,    888\"888,_ _,88P888    Y88"); Thread.Sleep(50);
                Write("\r\n  MMM     YM YMM   \"\"`  MMM    MMM  \"YMMMMMP\" MMM     YM"); Thread.Sleep(50);
                ForegroundColor = ConsoleColor.Yellow;
                Write("\r\n\r\n ▄████   ▄▄▄  ▄▄   ▄▄ ▄▄▄▄▄ "); Thread.Sleep(20);
                Write("\r\n██  ▄▄▄ ██▀██ ██▀▄▀██ ██▄▄  "); Thread.Sleep(20);
                Write("\r\n ▀███▀  ██▀██ ██   ██ ██▄▄▄\r\n\n"); Thread.Sleep(20);
                ResetColor();
                switch (menu("Start", "Credits", "Exit", "", 3))
                {
                    case 'A':
                        CursorVisible = false;
                        Clear();
                        start = 1;
                        Write("Welcome to the "); ForegroundColor = ConsoleColor.Red; Write("Reincarnation Game"); ResetColor(); Write("!"); ReadLine();
                        WriteLine("In this game, you will be reincarnated as a random animal and will have to make choices that will affect your life as that animal."); ReadLine();
                        Write("If there are "); ForegroundColor = ConsoleColor.Yellow; Wait(); ResetColor(); Write(" at the end of a sentence, please "); ForegroundColor = ConsoleColor.Yellow; Write("wait"); ResetColor(); Write(" for the text to end."); ReadLine(); 
                        Write("If not, please press the "); ForegroundColor = ConsoleColor.Yellow; Write("ENTER"); ResetColor(); Write(" key to continue."); ReadLine();
                        Write("\nHopefully you can remember that"); ReadLine();
                        Write("\nNow"); Wait(); ForegroundColor = ConsoleColor.Red; Write("let's get started!"); ReadLine();

                        Clear(); Thread.Sleep(300);
                        break;
                    case 'B':
                        CursorVisible = false;
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        Write("\n  ,ad8888ba,                                    88  88                      \r"); Thread.Sleep(50); 
                        Write("\n d8\"'    `\"8b                                   88  \"\"    ,d                \r"); Thread.Sleep(50);
                        Write("\nd8'                                             88        88                \r"); Thread.Sleep(50); 
                        Write("\n88             8b,dPPYba,   ,adPPYba,   ,adPPYb,88  88  MM88MMM  ,adPPYba,  \r"); Thread.Sleep(50);
                        Write("\n88             88P'   \"Y8  a8P_____88  a8\"    `Y88  88    88     I8[    \"\"  \r"); Thread.Sleep(50); 
                        Write("\nY8,            88          8PP\"\"\"\"\"\"\"  8b       88  88    88      `\"Y8ba,   \r"); Thread.Sleep(50);
                        Write("\n Y8a.    .a8P  88          \"8b,   ,aa  \"8a,   ,d88  88    88,    aa    ]8I  \r"); Thread.Sleep(50); 
                        Write("\n  `\"Y8888Y\"'   88           `\"Ybbd8\"'   `\"8bbdP\"Y8  88    \"Y888  `\"YbbdP\"'  \r\n\n"); Thread.Sleep(50); ForegroundColor = ConsoleColor.Yellow;
                        Write("Developed by: The Power Rangers\n\n"); Thread.Sleep(500); ForegroundColor = ConsoleColor.White;
                        Write("Benjamin Roberts\n"); Thread.Sleep(500);
                        Write("Nishachyjit Nishachyjit\n"); Thread.Sleep(500);
                        Write("Dania Piatov\n"); Thread.Sleep(500);
                        Write("David Knauf\n"); Thread.Sleep(500);
                        Write("Nathalie Chang"); Thread.Sleep(500);
                        ResetColor();
                        Write("\n\n\nPress "); ForegroundColor = ConsoleColor.Yellow; Write("ENTER"); ResetColor(); Write(" to return to the title screen...");
                        ReadLine();
                        Clear();
                        break;
                    case 'C':
                        CursorVisible = false;
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
