using System.Collections.Generic;

namespace PracticeYieldInCsharp.DataAccess
{
    public interface IPrimeGenerator
    {
        /// <summary>
        /// Prints gaps between each prime number
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> GetPrimeGaps();
    }
}