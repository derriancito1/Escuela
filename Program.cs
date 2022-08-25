using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using System;

var escuela = new Escuela("Platzi Academy", 2012, "Colombia", "Bogota");
var escuela2 = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, ciudad: "Bogota");
escuela.tipoEscuela = TiposEscuela.Primaria;

/*escuela.Cursos = new Curso[] {
    new Curso() { nombre = "101" },
    new Curso() { nombre = "201" },
    new Curso() { nombre = "301" }
};*/



//arregloCursos[0] = new Curso() { nombre = "101" };
//arregloCursos[1] = new Curso() { nombre = "201" };
//arregloCursos[2] = new Curso() { nombre = "301" };

escuela.Cursos = new List<Curso>()
{
    new Curso() { nombre = "101", jornada=TiposJornada.Mañana},
    new Curso() { nombre = "201", jornada=TiposJornada.Mañana},
    new Curso() { nombre = "301", jornada=TiposJornada.Mañana}
};

escuela.Cursos.Add(new Curso{nombre="102", jornada=TiposJornada.Tarde});
escuela.Cursos.Add(new Curso(){nombre="202", jornada=TiposJornada.Tarde});

var otraColeccion = new List<Curso>()
{
    new Curso() { nombre = "401", jornada=TiposJornada.Mañana},
    new Curso() { nombre = "501", jornada=TiposJornada.Mañana},
    new Curso() { nombre = "502", jornada=TiposJornada.Mañana}
};

//Remover miembros de la coleccion 
otraColeccion.Clear();

escuela.Cursos.AddRange(otraColeccion);


imprimirCursosEscuela(escuela);

static void imprimirCursosEscuela(Escuela escuela)
{
    WriteLine("=======================");
    Console.WriteLine("Lista de Cursos escuela");
    Console.WriteLine("=======================");

    if (escuela?.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            Console.WriteLine($"Nombre {curso.nombre}, id {curso.uniqueId}");
        }
    }
}

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



