using System;

namespace Proyecto
{
    //Clase Singleton
    public class Logger
    {
        //Instancia única del singleton
        private static Logger instancia = null;
        //static int contador = 0;  
        //Constructor privado para degar la creación de una instancia de esta clase afuera
        private Logger() {
            //Para comprobar la cantidad de instancias que se pueden crear (1)
            //contador++;  
            //Console.WriteLine("Instancia " + contador); 
        }
        
        //Para crear una única instancia
        public static Logger Instanciar() 
        {
            if (instancia == null) {
                instancia = new Logger();
            }
            return instancia;
        }
        
        public void Log(string mensaje){   
            
            Console.WriteLine($"[{DateTime.Now}]: {mensaje }");
        }
    }
    
    
}

