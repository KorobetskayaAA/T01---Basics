using System;

/* Часы со стрелками
 * Чтобы нарисовать стрелку на экране, необходимо определить координаты (x, y) ее кончика.
 * Для простоты центр часов в координатах (0, 0).
 * Написать метод, который определит положение часовой и минутной стрелок
 * по заданному времени (ч и мин в 24-часовом формате),
 * а также длинам часовой и минутной стрелки.
 */


namespace Clock
{
    class ProgramClock
    {
        static void AngleToCoordinates(double angle, double length, out double x, out double y)
        {
            x = length * Math.Sin(angle);
            y = -length * Math.Cos(angle);
        }

        static double HourToAngle(int h, int m)
        {
            double h12 = h % 12 + m / 60.0;
            return 2 * Math.PI / 12 * h12;
        }

        static double MinuteToAngle(int m)
        {
            return 2 * Math.PI / 60 * m;
        }

        static void GetClockCoordinates(int h, int m, int lengthHour, int lengthMinute,
            out double xHour, out double yHour, out double xMinute, out double yMinute)
        {
            double angleHour = HourToAngle(h, m);
            AngleToCoordinates(angleHour, lengthHour, out xHour, out yHour);
            double angleMinute = MinuteToAngle(m);
            AngleToCoordinates(angleMinute, lengthMinute, out xMinute, out yMinute);

        }

        static void PrintClockCoordinates(int h, int m,
            double xHour, double yHour, double xMinute, double yMinute)
        {
            Console.WriteLine("В " + h + "ч " + m + "мин");
            Console.WriteLine("  часовая стрелка в координатах (" + xHour + ", " + yHour + "),");
            Console.WriteLine("  минутная стрелка в координатах (" + xMinute + ", " + yMinute + ").");
        }

        static void Main()
        {
            int h, m, lengthHour = 3, lengthMinute = 5;
            double xH, yH, xM, yM;

            h = 0; m = 0;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 3; m = 0;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 6; m = 0;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 9; m = 0;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 12; m = 15;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 12; m = 30;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 12; m = 45;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 1; m = 0;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );

            h = 7; m = 35;
            GetClockCoordinates(
                h, m, lengthHour, lengthMinute,
                out xH, out yH, out xM, out yM
            );
            PrintClockCoordinates(
                h, m, xH, yH, xM, yM
            );
        }
    }
}