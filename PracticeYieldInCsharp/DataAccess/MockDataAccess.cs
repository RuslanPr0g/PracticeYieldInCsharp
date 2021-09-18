using PracticeYieldInCsharp.Models;
using System.Collections;
using System.Collections.Generic;

namespace PracticeYieldInCsharp.DataAccess
{
    public class MockDataAccess : IDataAccess
    {
        public IEnumerable<Person> GetPeople()
        {
            List<Person> people = new();

            people.Add(new Person("John", "Gen"));
            people.Add(new Person("Sue", "Storm"));
            people.Add(new Person("Jane", "Jet"));

            return people;
        }
    }
}
