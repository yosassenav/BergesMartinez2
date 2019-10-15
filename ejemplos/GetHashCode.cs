using System;

namespace ToString{
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

         string employeeID;

        public string EmployeeID{

            get { return employeeID; }
            set { employeeID = value; }

        }
        //Overriding the GetHashCode method

        public override int GetHashCode(){
            return EmployeeID.GetHashCode();
        }
    }

    class Program{

        static void Main(string[] args){

            Employee emp1 = new Employee();
            emp1.FirstName = "Pedro";
            emp1.LastName = "Reyes";
            emp1.Age = 33;
            emp1.EmployeeID = "125";

            Employee emp2 = new Employee();
            emp2.FirstName = "Pedro";
            emp2.LastName = "Reyes";
            emp2.Age = 33;
            emp2.EmployeeID = "125";

            Console.WriteLine("emp 1 hash code: {0}", emp1.GetHashCode());
            Console.WriteLine("emp 2 hash code: {0}", emp2.GetHashCode());
        }
    }
}

