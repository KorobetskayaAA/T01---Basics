using System;

namespace Conditions
{
    class ProgramConditions
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            #region Четность
            string nEven = (n % 2 == 0) ? "Четное" : "Нечетное";
            Console.WriteLine(nEven);
            #endregion
        }
    }
}
