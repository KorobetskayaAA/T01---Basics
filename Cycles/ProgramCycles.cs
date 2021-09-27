using System;

namespace Cycles
{
    class ProgramCycles
    {
        static int ReadCount(string message = "Введите целое положительное число: ")
        {
            int number;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                while (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                Console.WriteLine("Неверное значение");
            }
        }

        static double ReadDouble(string message = "Введите число: ")
        {
            double number;
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (!double.TryParse(input, out number));
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("================ ВВОД ИСХОДНЫХ ДАННЫХ ==================");
            int n = ReadCount("Введите количество значений в последовательности: ");

            int countPositive = 0;
            int countNegative = 0;
            int countEven = 0;
            double sum = 0;
            double product = 1;
            double min = double.MaxValue;
            string minIndexes = "";
            double max = double.MinValue;
            string maxIndexes = "";

            for (int i = 0; i < n; i++)
            {
                double value = ReadDouble("Введите значение №" + (i + 1) + ": ");
                if (value > 0)
                {
                    countPositive++;
                }
                else if (value < 0)
                {
                    countNegative++;
                }
                if (value % 2 == 0)
                {
                    countEven++;
                }
                sum += value;
                product *= value;
                if (value <= min)
                {
                    min = value;
                    minIndexes += i + ", ";
                }
                if (value >= max)
                {
                    max = value;
                    maxIndexes += i + ", ";
                }
            }

            Console.WriteLine("================ РЕЗУЛЬТАТЫ РАСЧЕТА ==================");
            Console.WriteLine("Количество положительных значений: " + countPositive);
            Console.WriteLine("Количество отрицательных значений: " + countNegative);
            Console.WriteLine("Количество четных значений: " + countEven);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Среднее: " + sum / n);
            Console.WriteLine("Произведение: " + product);
            Console.WriteLine("Среднее геометрическое: " + Math.Pow(product, 1.0 / n));

            Console.WriteLine("Минимум: " + min);
            Console.WriteLine("Максимум: " + max);
        }
    }
}
