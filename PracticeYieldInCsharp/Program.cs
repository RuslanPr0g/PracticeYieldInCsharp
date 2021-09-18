using System;
using System.Linq;
using PracticeYieldInCsharp.DataAccess;

namespace PracticeYieldInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the app");

            IDataAccess dataAccess = new YieldDataAccess();
            IPrimeGenerator primeGenerator = new YieldDataAccess();

            var numbers = primeGenerator.GetPrimeGaps().Take(10);

            foreach (var n in numbers)
            {
                Console.WriteLine($"{n}");
            }

            Console.WriteLine("End of the app");
        }
    }
}
