using CoreEscuela.Entidades;

var escuela = new Escuela("Platzi Academy", 2012, "Colombia", "Bogota");
escuela.tipoEscuela = TiposEscuela.Primaria;
Console.WriteLine(escuela);