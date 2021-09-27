using System;

namespace Deposit
{
    class ProgramDeposit
    {
        static decimal GetSumAfter(decimal startSum, int years, double interest)
        {
            double interestMonth = interest / 12;
            decimal currentSum = startSum;
            for (int month = 0; month < years * 12; month++)
            {
                currentSum *= 1 + (decimal)interestMonth;
                currentSum = Math.Round(currentSum, 2);
            }
            return currentSum;
        }

        static int WhenGetSum(decimal startSum, decimal finalSum, double interest)
        {
            double interestMonth = interest / 12;
            decimal currentSum = startSum;
            int month = 0;
            while (currentSum < finalSum)
            {
                currentSum *= 1 + (decimal)interestMonth;
                currentSum = Math.Round(currentSum, 2);
                month++;
            }
            return (int)Math.Ceiling(month / 12m);
        }
        
        static void Main()
        {
            decimal startSum, finalSum;
            int years;
            double interestYear;

            startSum = 10_000.00m;
            finalSum = 12_833.59m;
            years = 5;
            interestYear = 0.05;
            TestCase("1: GetSumAfter", GetSumAfter(startSum, years, interestYear) == finalSum);
            TestCase("1: WhenGetSum", WhenGetSum(startSum, finalSum, interestYear) == years);

            startSum = 10_000.00m;
            finalSum = 16_470.09m;
            years = 10;
            interestYear = 0.05;
            TestCase("2: GetSumAfter", GetSumAfter(startSum, years, interestYear) == finalSum);
            TestCase("2: WhenGetSum", WhenGetSum(startSum, finalSum, interestYear) == years);

            startSum = 10_000.00m;
            finalSum = 12_833.59m;
            years = 5;
            interestYear = 0.05;
            TestCase("1: GetSumAfter", GetSumAfter(startSum, years, interestYear) == finalSum);
            TestCase("1: WhenGetSum", WhenGetSum(startSum, finalSum, interestYear) == years);

        }

        static void TestCase(string title, bool passed)
        {
            if (passed)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test case " + title + (passed ? " passed" : " failed"));
            Console.ResetColor();
        }
    }
}
