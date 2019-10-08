

using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;


Employee emp1 = new Employee();

emp1.FirstName = "Amr";

emp1.LastName = "Ashush";

emp1.Age = 23;

emp1.EmployeeID = "125";

 

Employee emp2 = new Employee();

emp2.FirstName = "Amr";

emp2.LastName = "Ashush";

emp2.Age = 23;

emp2.EmployeeID = "125";

           

Console.WriteLine("emp 1 hash code: {0}", emp1.GetHashCode());

Console.WriteLine("emp 2 hash code: {0}", emp2.GetHashCode());

 

Employee emp1 = new Employee();

emp1.FirstName = "Amr";

emp1.LastName = "Ashush";

emp1.Age = 23;

emp1.EmployeeID = "125";

 

Employee emp2 = emp1;

 

Console.WriteLine("emp 1 hash code: {0}", emp1.GetHashCode());

Console.WriteLine("emp 2 hash code: {0}", emp2.GetHashCode());

 

the result will be:

 

emp 1 hash code: 45653674

emp 2 hash code: 45653674

 


//Overriding the GetHashCode method

public override int GetHashCode()

{

    return ToString().GetHashCode();

}

 

Employee emp1 = new Employee();

emp1.FirstName = "Amr";

emp1.LastName = "Ashush";

emp1.Age = 23;

emp1.EmployeeID = "125";

 

Employee emp2 = new Employee();

emp2.FirstName = "Amr";

emp2.LastName = "Ashush";

emp2.Age = 23;

emp2.EmployeeID = "125";

           

Console.WriteLine("emp 1 hash code: {0}", emp1.GetHashCode());

Console.WriteLine("emp 2 hash code: {0}", emp2.GetHashCode());

 

//Overriding the GetHashCode method

public override int GetHashCode()

{

    return EmployeeID.GetHashCode();

}