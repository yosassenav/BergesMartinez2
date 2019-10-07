

// C# program to show how base keyword  
// specifies the calling of base-class 
// constructor from the derived class 
// when derived class instances are created 
using System; 
  
// base class 
public class clssA { 
      
    int n1, n2; 
  
    // default constructor 
    public clssA() 
    { 
        Console.WriteLine("Default Constructor Invoked"); 
    } 
  
    // parameterized constructor 
    public clssA(int i, int j) 
    { 
          
        // consturct values 
        n1 = i; 
        n2 = j; 
        Console.WriteLine("Parameterized Constructor Invoked"); 
        Console.WriteLine("Invoked Values are: " + n1 + " and " + n2); 
    } 
} 
  
// derived class 
public class DerivedClass : clssA 
{ 
      
    // This constructor will instantiate 
    // 'clssA()' [no argument constructor] 
    // using 'base' keyword 
    public DerivedClass() : base() { } 
  
  
    // This constructor will instantiate 
    // 'clssA(int i, int j)' [parameterized 
    // constructor] using 'base' keyword 
    public DerivedClass(int i, int j) : base(i, j) { } 
  
// Main Method 
static void Main() 
{ 
      
    // invoke no argumanet constructor 
    DerivedClass d1 = new DerivedClass(); 
      
    Console.WriteLine(); 
  
    // invoke parameterized constructor 
    DerivedClass d2 = new DerivedClass(10, 20); 
      
} 
} 
