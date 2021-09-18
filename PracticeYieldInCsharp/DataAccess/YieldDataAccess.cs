using PracticeYieldInCsharp.Models;
using System.Collections.Generic;

namespace PracticeYieldInCsharp.DataAccess
{
    public class YieldDataAccess : IDataAccess, IPrimeGenerator
    {
        public IEnumerable<Person> GetPeople()
        {
            yield return new Person("John", "Gen");
            yield return new Person("Sue", "Storm");
            yield return new Person("Jane", "Jet");
        }

        public IEnumerable<int> GetPrimeGaps()
        {
            int currentNumber = 1;
            int lastPrime = 1;

            while (true)
            {
                if (IsPrime(currentNumber))
                {
                    yield return currentNumber - lastPrime;
                    lastPrime = currentNumber;
                }

                currentNumber++;
            }
        }

        private bool IsPrime(int value)
        {
            for (int i = 2; i < value / 2; i++)
            {
                if (value % i == 0)
                    return false;
            }

            return true;
        }
    }
}
