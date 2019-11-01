

using System;

class MainClass {
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");

    string Materia;
    string Profesor;

    Console.Write("Nombre de la materia: ");
  	Materia = Console.ReadLine(); 
  	Console.Write("Nombre del profesor: ");
  	Profesor = Console.ReadLine(); 
  
        // string converted to lower case 
    string NombreMateria = Materia.ToLower(); 
    string NombreProfesor = Profesor.ToLower();
  
    Console.WriteLine(NombreMateria); 
    Console.WriteLine(NombreProfesor);


	int MateriaTam = Materia.Length;
	int ProfesorTam = Profesor.Length;

	if (MateriaTam > 20)
	{
       Console.WriteLine("El nombre " + Materia + "es muy largo");
	}
	else
	{
		Console.WriteLine("nombre valido");
	}


	if (ProfesorTam > 20)
	{
       Console.WriteLine("El nombre " + Profesor + "es muy largo");
	}
	else
	{
		Console.WriteLine("nombre valido");
	}



    }
}



