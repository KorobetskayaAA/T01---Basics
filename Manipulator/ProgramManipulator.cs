using System;

namespace Manipulator
{
    class ProgramManipulator
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            int width = Console.WindowWidth,
                height = Console.WindowHeight;
            int x = width / 2,
                y = height / 2;
            while (true)
            {
                Console.ResetColor();
                Console.SetCursorPosition(x, y);
                Console.Write("☻");
                // чтобы на экране не было видно нажатую клавишу
                Console.ForegroundColor = Console.BackgroundColor;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W: y--; break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S: y++; break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D: x++; break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: x--; break;

                    case ConsoleKey.Escape: return;

                    default: Console.Beep(); break;
                }
                Console.Clear();
                x += width;
                x %= width;
                y += height;
                y %= height;
            }
        }
    }
}
