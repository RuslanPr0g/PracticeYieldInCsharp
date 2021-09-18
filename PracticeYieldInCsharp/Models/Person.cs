namespace PracticeYieldInCsharp.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            System.Console.WriteLine($"Initialized user: { FirstName } { LastName }");
        }
    }
}
