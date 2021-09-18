using System;
using PracticeYieldInCsharp.DataAccess;

namespace PracticeYieldInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the app");

            IDataAccess dataAccess = new YieldDataAccess();

            var people = dataAccess.GetPeople();

            foreach (var person in people)
            {
                Console.WriteLine($"Read: {person.FirstName} {person.LastName}");
            }

            Console.WriteLine("End of the app");
        }
    }
}
