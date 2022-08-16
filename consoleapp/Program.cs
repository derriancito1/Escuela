Console.WriteLine("Por favor ingresa un nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cargo");
string cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre} mi cargo es {cargo} y tengo {edad}");