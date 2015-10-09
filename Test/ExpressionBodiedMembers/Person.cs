
namespace Test.ExpressionBodiedMembers
{
    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }  // enum, mas to com pregs

        public override string ToString() => $"{Name} tem {Age} {(Age > 1 ? "anos" : "ano")} e é {(Gender.Equals("M") ? "homem" : "mulher")}";

    }
}
