using PracticeYieldInCsharp.Models;
using System.Collections.Generic;

namespace PracticeYieldInCsharp.DataAccess
{
    public interface IDataAccess
    {
        IEnumerable<Person> GetPeople();
    }
}