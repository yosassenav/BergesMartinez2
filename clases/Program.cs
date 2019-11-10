using System.IO;
using System.Text;
using System;
using Proyecto;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Prueba de Logger con Singleton
            //var obj1 = Logger.GetMyInstance();
            //var obj2 = Logger.GetMyInstance();
            //TextWriter texto = null;
            //obj1.Log("Creación de recordatorio", texto);


            Logger logger = Logger.GetMyInstance();
            logger.LogInfo("LOG INFORMATION");
            logger.LogWarn("LOG WARNING");
            logger.LogError("LOG ERROR");



            DataBase db = DataBase.GetMyInstance();
            db.DBOpenConnection();

            TxtManager manager = TxtManager.GetMyInstance();
            var lines = manager.ReadFromFile();

            foreach (var line in lines)
            {
                db.DBInsert(line);
            }

            db.DBExecReadCommand("SELECT * FROM log");
            db.DBCloseConnection();

            Console.ReadKey();


            /*Recordatorio rec = new Recordatorio();
            rec.Tipo = "Tarea";
            rec.Titulo = "Investigación";
            rec.Materia = "Problemas del Mundo Contemporáneo";
            rec.Descripcion = "Realizar investigación sobre movimientos sociales de los años '60";
            rec.Estado = "Pendiente";
            rec.Prioridad = 2;
            //rec.Fecha = "21/10/2019";
            rec.Fecha = Convert.ToDateTime("2019-01-10");
            rec.Hora = "7:00";


            Console.WriteLine(rec.ToString());*/
        }
    }
}
