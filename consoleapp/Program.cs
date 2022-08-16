using Humanizer;

Console.WriteLine("Por favor ingresa un nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cargo");
var cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre} mi cargo es {cargo} y tengo {edad.ToWords(new System.Globalization.CultureInfo("en"))} años");