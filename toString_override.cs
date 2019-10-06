using System;

namespace CSharp{
    public class Employee{

        string firstName;

        public string FirstName{
            get { return firstName; }
            set { firstName = value; }
        }

        string lastName;
        public string LastName{

            get { return lastName; }
            set { lastName = value; }
        }
        int age;
        public int Age{

            get { return age; }
            set { age = value; }
        }

         //Overriding ToString() method
        public override string ToString(){

            string s = "First Name: " + firstName + "\n" + "Last Name: " + 
lastName + "\n" +"Age: " + age;
            return s;

        }
    }

    class Program{

        static void Main(string[] args){

            Employee emp1 = new Employee();
            emp1.FirstName = "Regina";
            emp1.LastName = "Berges";
            emp1.Age = 20;

            string s = emp1.ToString();
            Console.WriteLine(s);

        }
    }
}

