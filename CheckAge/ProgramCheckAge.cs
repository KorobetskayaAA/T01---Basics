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
            if (TryParseAge(input, out age))
            {
                string adult = AdultToString(IsAdult(age));
                string category = GetCategory(age);
                bool hasAnniversary = HasAnniversary(age);

                Console.WriteLine(GetResult(adult, category, hasAnniversary));
            }
            else
            {
                Console.WriteLine("Введенное значение не может быть интерпретировано как возраст.");
            }
        }

        static bool IsAdult(int age)
        {
            return age >= 18;
        }

        static string AdultToString(bool adult)
        {
            return adult ? "совершеннолетний" : "несовершеннолетний";
        }

        static string GetCategory(int age)
        {
            if (age < 7)
                return "дошкольник";
            if (age <= 18)
                return "школьник";
            if (age >= 60)
                return "пенсионер";
            return "трудящийся";
        }

        static bool HasAnniversary(int age)
        {
            return age % 10 == 0 || age > 50 && age % 5 == 0;
        }

        static string GetResult(string adult, string category, bool hasAnniversary)
        {
            return "Статус: " + adult + " " + category + (hasAnniversary ? ", юбиляр" : "") + ".";
        }

        static bool TryParseAge(string stringAge, out int age)
        {
            return int.TryParse(stringAge, out age) && age >= 0 && age <= 150;
        }
    }
}
