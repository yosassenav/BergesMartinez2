using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prueba de Logger con Singleton
            var obj1 = Logger.Instanciar();
            var obj2 = Logger.Instanciar();
            obj1.Log("Creación de recordatorio");

            Recordatorio rec = new Recordatorio();
            rec.Tipo = "Tarea";
            rec.Titulo = "Investigación";
            rec.Materia = "Problemas del Mundo Contemporáneo";
            rec.Descripcion = "Realizar investigación sobre movimientos sociales de los años '60";
            rec.Estado = "Pendiente";
            rec.Prioridad = 2;
            //rec.Fecha = "21/10/2019";
            rec.Fecha = Convert.ToDateTime("2019-01-10");
            rec.Hora = "7:00";

            
            Console.WriteLine(rec.ToString());
        }
    }
}

