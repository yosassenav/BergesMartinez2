using System;

namespace EqualsExample{
    public class Person{
        public int Id { get; set; }
        public string Name { get; set; }

    //Overriding Equals() method
    public override bool Equals(object obj){
        var person = obj as Person;
        if (person == null)
            return false;
        return person.Id == Id && person.Name == Name;
        }

    }

    class Program{
        static void Main(string[] args){
            var person1 = new Person { Id = 1, Name = "Eric" };
            var person2 = new Person { Id = 1, Name = "Eric" };

            Console.WriteLine($"person1.Equals(person2) = { 
person1.Equals(person2) }");
            
        }
    }
}
