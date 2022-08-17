
// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
var miEscuela = new Escuela();
miEscuela.nombre = "Platzi Academy";
miEscuela.direccion = "Cr 9 calle 72";
miEscuela.anoFundacion = 2012;
Console.WriteLine("Timbre");
miEscuela.Timbrar();

class Escuela{
   public string nombre;
   public string direccion;
   public int anoFundacion;
   public string ceo;

   public void Timbrar()
   {
        Console.Beep(2000,3000);
   } 
}