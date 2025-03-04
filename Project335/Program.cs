using System.Diagnostics;

namespace Project335
{
    class UIManager
    {
        public void ShowSize()
        {
            Console.Clear();
            // Console.SetWindowSize(21, 15);
            // Console.SetBufferSize(21, 15);
            Console.SetCursorPosition(2, 6);
            System.Console.WriteLine("해상도를 21*15로");
            Console.SetCursorPosition(7, 7);
            System.Console.WriteLine("설정해주세요");
        }
        public void DrawMainMenu(Stopwatch timer)
        {
            string title = "Project 3-3-5"; // 13 characters
            const int TYPING_DELAY = 50;
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            System.Console.WriteLine("♜♝♞♜♝♞♜♝♞♜♝♞♜♝♞♜♝♞♜♝♞");
            System.Console.WriteLine("♜                   ♞");
            System.Console.WriteLine("♝                   ♝");
            System.Console.WriteLine("♞                   ♜");
            System.Console.WriteLine("♞♝♜♞♝♜♞♝♜♞♝♜♞♝♜♞♝♜♞♝♜");
            Console.SetCursorPosition(4,2);
            int index = 0;
            timer.Restart();
            while (index < title.Length)
            {
                if (timer.ElapsedMilliseconds >= TYPING_DELAY)
                {
                    Console.Write(title[index++]);
                    timer.Restart();
                }
            }
            Console.SetCursorPosition(0,5);
            System.Console.WriteLine();
            timer.Restart();
            if (timer.ElapsedMilliseconds >= TYPING_DELAY * 4)
            {
                Console.SetCursorPosition(5, 8);
                System.Console.WriteLine("How to Play");
            }
            timer.Restart();
            if (timer.ElapsedMilliseconds >= TYPING_DELAY * 4)
            {
                Console.SetCursorPosition(8, 11);
                System.Console.WriteLine("Start");
            }
            timer.Stop();
        }
        public void DrawPlayerBoard()
        {
            Console.SetCursorPosition(0, 10);
            System.Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 11);
            System.Console.Write("┃                   ┃");
            Console.SetCursorPosition(0, 12);
            System.Console.Write("┃                   ┃");
            Console.SetCursorPosition(0, 13);
            System.Console.Write("┃                   ┃");
            Console.SetCursorPosition(0, 14);
            System.Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");
        }
        public void DrawEnemyInfo()
        {
            Console.SetCursorPosition(0, 0);
            System.Console.Write("➤➤➤ ");
            Console.SetCursorPosition(0, 1);
            System.Console.Write("➤ ♥︎ ");
            Console.SetCursorPosition(0, 2);
            System.Console.Write("✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎");
        }
    }
    class Slot
    {

    }
    class Player
    {

    }
    class Enemy
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            UIManager uiManager = new UIManager();
            stopwatch.Start();
            uiManager.DrawMainMenu(stopwatch);
        }
    }
}