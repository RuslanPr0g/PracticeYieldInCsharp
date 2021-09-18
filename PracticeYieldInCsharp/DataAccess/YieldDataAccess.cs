using PracticeYieldInCsharp.Models;
using System.Collections.Generic;

namespace PracticeYieldInCsharp.DataAccess
{
    public class YieldDataAccess : IDataAccess
    {
        public IEnumerable<Person> GetPeople()
        {
            yield return new Person("John", "Gen");
            yield return new Person("Sue", "Storm");
            yield return new Person("Jane", "Jet");
        }
    }
}
