
public class Materia
{
   
    public string  Titulo = string.Empty;
    public string  Descripcion = string.Empty;
    public date  FechaEntrega;
    public bool Estado;

    public Materia()
    {
    }

    public void AgregarTarea(string Titulo, string Descripcion, date FechaEntrega, bool Estado)
    {
        
    }

    public void EliminarTarea(string Titulo, string Descripcion, date FechaEntrega, bool Estado)
    {
        
    }

    public void ModificarTarea(string Titulo, string Descripcion, date FechaEntrega, bool Estado)
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