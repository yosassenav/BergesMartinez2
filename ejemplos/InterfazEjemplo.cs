

using System;


public interface IAve
 {
  void Volar();
  void Comer();
 }



 public class AvePropiedades:IAve
 {
  public int Patas=2;
  public int Alas=2;
  public int Cola=1;
  public string Nombre{ get; private set;}
  public AvePropiedades(string NAve)
  {
   this.Nombre = NAve;
  }
  public void Volar()
  {
   Console.WriteLine ("Volar");
  }
  public void Comer()
  {
   Console.WriteLine ("Comer");
  }
 }


 public class Ave:AvePropiedades
 {
  public Ave(string Nombre):base(Nombre)
  {
  }
 }


  class MainClass
 {
  public static void Main (string[] args)
  {
   //Instanciamos dos clases del tipo ave pasando de parametro el nombre del ave
   Ave canario = new Ave ("Canario");
   Ave cuervo = new Ave ("Cuervo");
   //Creamos una instancia de nuestra clase principal para llamar el metodo imprimir()
   MainClass main = new MainClass ();
   main.imprimir (canario);
   main.imprimir (cuervo);
   Console.ReadKey ();
  }
  /// 

  /// Imprimir the specified ave.
  /// Este metodo imprimira las propiedades de una clase ave.
  /// 

  /// Ave.
  public void imprimir(Ave ave)
  {
   //Imprimimos el nombre del ave, el numero de patas y el numero de colas
   Console.WriteLine ("Soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
   //Llamamos a nuestros dos metodos de la interface Comer() y Volar()
   Console.WriteLine ("Puedo ");
   ave.Comer ();
   Console.WriteLine ("y tambien puedo ");
   ave.Volar ();
  }
 }


 // https://alejandroruizvarela.blogspot.com/2014/04/c-interface-ejemplo-sencillo.html