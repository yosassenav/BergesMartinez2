using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto
{
    //Clase Singleton
    public class Logger
    {
        //Instancia única del singleton
        private static Logger myloginstance = null;
        //private static string Ruta = @"C:\Users\monap\Desktop";


        //static int contador = 0;  
        //Constructor privado para dejar la creación de una instancia de esta clase afuera
        private Logger()
        {
            //Para comprobar la cantidad de instancias que se pueden crear (1)
            //contador++;  
            //Console.WriteLine("Instancia " + contador); 
        }

        private TxtManager manager = TxtManager.GetMyInstance();

        //Para crear una única instancia
        public static Logger GetMyInstance()
        {
            //string logMessage;

            if (myloginstance == null)
            {
                myloginstance = new Logger();
            }

            return myloginstance;
        }


        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            manager.WriteInFile($"[INFO] - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogWarn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            manager.WriteInFile($"[WARNING] - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            manager.WriteInFile($"[ERROR] - {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }


}

