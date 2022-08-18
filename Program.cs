using CoreEscuela.Entidades;

var escuela = new Escuela("Platzi Academy", 2012, "Colombia", "Bogota");
var escuela2 = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, ciudad:"Bogota");
escuela.tipoEscuela = TiposEscuela.Primaria;
Console.WriteLine(escuela +""+ escuela2);