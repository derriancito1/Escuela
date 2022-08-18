using CoreEscuela.Entidades;

var escuela = new Escuela("Platzi Academy", 2012, "Colombia", "Bogota");
var escuela2 = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, ciudad:"Bogota");
escuela.tipoEscuela = TiposEscuela.Primaria;

var curso1 = new Curso() {nombre="101"};
var curso2 = new Curso() {nombre="201"};
var curso3 = new Curso() {nombre="301"};

Console.WriteLine(escuela +""+ escuela2);
System.Console.WriteLine("====================");
Console.WriteLine(curso1.nombre + ", " + curso1.uniqueId);
Console.WriteLine($"{curso2.nombre}, {curso2.uniqueId}");
Console.WriteLine(curso3);

