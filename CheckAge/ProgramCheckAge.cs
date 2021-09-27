using System;

namespace CheckAge
{
    class ProgramCheckAge
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите возраст (полных лет)");
            string input = Console.ReadLine();
            int age;
            Console.Write("Статус: ");
            if (int.TryParse(input, out age) && age > 0 && age <= 150)
            {
                string adult = (age >= 18) ? "совершеннолетний" : "несовершеннолетний";

                string category = "";
                if (age < 7)
                    category = "дошкольник";
                else if (age <= 18)
                    category = "школьник";
                else if (age >= 60)
                    category = "пенсионер";
                else
                    category = "трудящийся";

                bool hasAnniversary = age % 10 == 0 || age > 50 && age % 5 == 0;

                Console.Write(adult + " " + category);
                if (hasAnniversary)
                {
                    Console.Write(", юбиляр");
                }
                Console.WriteLine(".");
            }
            else
            {
                Console.WriteLine("Введенное значение не может быть интерпретировано как возраст.");
            }
        }
    }
}
