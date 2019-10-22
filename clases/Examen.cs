
public class Materia
{
   
    public string  NombreMateria = string.Empty;
    public string  Horario = string.Empty;
    public bool  Estado;
    public string  NombreProfesor = string.Empty;

    public Materia()
    {
    }

    public void AgregarMateria(string NombreMateria, string Horario, bool Estado, string NombreProfesor)
    {
        
    }

    public void EliminarMateria(string NombreMateria, string Horario, bool Estado, string NombreProfesor)
    {
        
    }

    public void ModificarMateria(string NombreMateria, string Horario, bool Estado, string NombreProfesor)
    {
        
    }

    public int MyAutoImplementedProperty { get; set; }

    private int myPropertyVar;
    
    public int MyProperty
    {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
    } 
}