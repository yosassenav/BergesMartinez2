using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prueba de Logger con Singleton
            var logger = LoggerSingleton.Instanciar();

            //Conexión a BD
            ConexionSingleton db = ConexionSingleton.InstanciarCon();
            db.Conectar();

            logger.EstablecerNivel(3);
            logger.Guardar("Se ha establecido conexión a la base de datos.");

            logger.EstablecerNivel(3);
            logger.Guardar("Creación de recordatorio.");

            Recordatorio r = new Recordatorio();
            r.Tipo = "Tarea";
            r.Titulo = "Investigación";
            r.Materia = "Problemas del Mundo Contemporáneo";
            r.Descripcion = "Realizar investigación sobre movimientos sociales de los años 60";
            r.Estado = "Pendiente";
            r.Prioridad = 2;
            r.Fecha = Convert.ToDateTime("2019-01-10");
            r.Hora = "7:00";
            //Console.WriteLine(r.ToString());

            //Guardar recordatorio en BD
            db.RealizarConsulta($"INSERT INTO recordatorios (Tipo, Titulo, Materia, Descripcion, Estado, Prioridad, Fecha, Hora) VALUES ('{r.ToString()}')");
            logger.EstablecerNivel(3);
            logger.Guardar("Se ha realizado consulta de inserción a la BD.");

            //Desconexión de BD
            db.Desconectar();
            logger.EstablecerNivel(2);
            logger.Guardar("Se ha realizado desconectado de la BD.");
        }
    }
}

