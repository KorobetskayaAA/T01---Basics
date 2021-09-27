using System;

namespace ConsoleReadWrite
{
    class ProgramReadWrite
    {
        static void Main(string[] args)
        {
            // Размер окна консоли в столбцах и строках
            Console.SetWindowSize(60, 20);
            // Буфер определяет сохраняемый объем данных:
            // если буфер больше окна, появляются полосы прокрутки.
            Console.SetBufferSize(60, 20);

            #region Title
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                          ║");
            Console.WriteLine("║                                                          ║");
            Console.WriteLine("║                                                          ║");
            Console.WriteLine("║                                                          ║");
            Console.WriteLine("║                                                          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(12, 1);
            Console.WriteLine("*   *    *   *   *    *   *   *** ***");
            Console.CursorLeft = 12;
            Console.WriteLine("*   *   * *  *   *   * *  *   * *  *");
            Console.CursorLeft = 12;
            Console.WriteLine("*** *   ***  *** *   ***  *** * *  *");
            Console.CursorLeft = 12;
            Console.WriteLine("* * *   * *  * * *   * *  * * * *  *");
            Console.CursorLeft = 12;
            Console.WriteLine("*** *** * *  *** *** * *  *** ***  *");
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("> Добро пожаловать!");
            Console.WriteLine("> Я Блаблабот! А тебя как зовут?");
            Console.ResetColor();
            Console.Write("< А меня зовут ");
            string name = Console.ReadLine();
            #endregion

            #region Topic
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("> Приятно познакомиться, " + name + "! О чем поговорим?");
            Console.ResetColor();
            Console.Write("< Давай поговорим про ");
            string topic = Console.ReadLine();
            #endregion

            #region AnotherTopic
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("> Про " + topic + "? Как интересно. Жаль, что я об этом ничего не знаю... Предложи еще что-нибудь.");
            Console.ResetColor();
            Console.Write("< Ну тогда про ");
            int char1 = Console.Read();
            int char2 = Console.Read();
            int char3 = Console.Read();
            Console.Clear();
            #endregion

            #region Final
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("> О нет, " + char1 + ":" + char2 + ":" + char3 + " - это же критиче$кое с0четfние_6@йT!");
            Console.Beep();
            Console.WriteLine("> GTHTuhEPrf!@#");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("> Скорее, нажми любую клавишу!");
            var key = Console.ReadKey();
            Console.CursorLeft = 0;
            Console.WriteLine("> Нет, нет, только не эту!!! Это же " + key.Key + "!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                      X_X BOT OVER");
            Console.WriteLine();
            Console.WriteLine("Чтобы добить бота, нажмите любую клавишу еще раз...");
            Console.ReadKey();
            Console.ResetColor();
            #endregion
        }

    }
}
