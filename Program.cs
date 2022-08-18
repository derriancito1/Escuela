using CoreEscuela.Entidades;

var escuela = new Escuela("Platzi Academy", 2012, "Colombia", "Bogota");
var escuela2 = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, ciudad: "Bogota");
escuela.tipoEscuela = TiposEscuela.Primaria;

var arregloCursos = new Curso[3];

arregloCursos[0] = new Curso() { nombre = "101" };
arregloCursos[1] = new Curso() { nombre = "201" };
arregloCursos[2] = new Curso() { nombre = "301" };

Console.WriteLine(escuela + "" + escuela2);

System.Console.WriteLine("========While============");
ImprimirCursosWhile(arregloCursos);
System.Console.WriteLine("========Dowhile============");
ImprimirCursosDoWhile(arregloCursos);
System.Console.WriteLine("========For================");
ImprimirCursosFor(arregloCursos);
System.Console.WriteLine("========ForEach============");
ImprimirCursosForeach(arregloCursos);

static void ImprimirCursosWhile(Curso[] arregloCursos)
{
    int contador = 0;
    while (contador < arregloCursos.Length)
    {
        Console.WriteLine($"Nombre {arregloCursos[contador].nombre}, id {arregloCursos[contador].uniqueId}");
        contador++;
    }
}

static void ImprimirCursosDoWhile(Curso[] arregloCursos)
{
    int contador = 0;
    do
    {
        Console.WriteLine($"Nombre {arregloCursos[contador].nombre}, id {arregloCursos[contador].uniqueId}");
        contador++;
    } while (contador < arregloCursos.Length);
}

static void ImprimirCursosFor(Curso[] arregloCursos)
{
    for (int i = 0; i < arregloCursos.Length; i++)
    {
        Console.WriteLine($"Nombre {arregloCursos[i].nombre}, id {arregloCursos[i].uniqueId}");
    }
}



static void ImprimirCursosForeach(Curso[] arregloCursos)
{
    foreach (var i in arregloCursos)
    {
        Console.WriteLine($"Nombre {i.nombre}, id {i.uniqueId}");
    }
}



