using System.Collections.Generic;
using System.Linq;

namespace Test.ExpressionBodiedMembers
{
    public class PersonController
    {
        
        List<Person> db = new List<Person>()
        {
            new Person() { Name = "Caio", Age = 25, Gender = "M" },
            new Person() { Name = "Satania", Age = 16, Gender = "F" },
            new Person() { Name = "Brendinha", Age = 17, Gender = "F" },
            new Person() { Name = "Julião", Age = 1, Gender = "M" }
        };

        public IEnumerable<Person> GetMen() => db.Where(x => x.Gender.Equals("M"));

        public IEnumerable<Person> GetMinors() => db.Where(x => x.Age < 18);

        public IEnumerable<Person> GetMenMinors() => db.Where(x => x.Age < 18 && x.Gender.Equals("M"));
        
    }
}
