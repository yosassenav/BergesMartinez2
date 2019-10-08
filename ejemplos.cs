
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    
    class Comida
    {
        public void Comer(int cant)
        {
            Console.WriteLine("Tienes " + cant + " comidas");
            
        }
        
        public void Comer(int cant,string momento)
        {
            Console.WriteLine("Tienes "+ cant + " comidas en la "+ momento);
        }
        
    }
    
    class Calc
    {
        public void Multiplicar(int a)
        {
            Console.WriteLine("\n Resultado de la multiplicacion "+a*a);
        }
        
        public void Multiplicar(int a,int b)
        {
           Console.WriteLine("\n Resultado de la multiplicacion "+a*b);
        }
        
        public void Area(int lado)
        {
            int cuadrado;
            cuadrado = lado*lado;
            Console.WriteLine("\n Area del cuadrado "+cuadrado);
        }
        
        public void Area(int baser,int altura)
        {
            int rectangulo;
            rectangulo = baser*altura;
            Console.WriteLine("\n Area del rectangulo "+rectangulo);
        }
        
    }
    
    class Personaje
    {
        string name;
        public Personaje()
        {
            Console.WriteLine("\n Personaje creado");
            
        }
        
        public Personaje(string name)
        {
            this.name = name;
            Console.WriteLine("\n El personaje llamado " + name +" ha sido creado");
            
        }
        
    }
    
    
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Comida x = new Comida();
            Calc y = new Calc();
            Personaje p1,p2;
            
            x.Comer(2);
            x.Comer(2,"Noche");
            
            y.Multiplicar(2);
            y.Multiplicar(2,4);
            
            y.Area(2);
            y.Area(2,6);
            

            
            p1 = new Personaje();
            
            p2 = new Personaje("Vanessa");
        }
    }
}