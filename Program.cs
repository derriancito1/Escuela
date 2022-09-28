using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using System;
using CoreEscuela.Util;
using System.Linq;

var engine = new EscuelaEngine();
engine.Inicializar();
Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
//Printer.Beep(10000, cantidad:10);
imprimirCursosEscuela(engine.Escuela);

Dictionary<int, string> diccionario = new Dictionary<int, string>();

diccionario.Add(10, "JuanK");
diccionario.Add(23, "Lorem Ipsum");

foreach (var keyValPair in diccionario)
{
    Console.WriteLine($"key: {keyValPair.Key} valor {keyValPair.Value}");
}

Printer.WriteTitle("Acceso a Diccionario");
diccionario[0] = "Pekerman";
WriteLine(diccionario[0]);
Printer.WriteTitle("Otro Diccionario");

var dic = new Dictionary<string, string>();
dic["luna"] = "Cuerpo celeste que gira alrededor de la tierra";
WriteLine(dic["luna"]);
dic["luna"] = "Protagonista de soy luna";
WriteLine(dic["luna"]);





/*var listaObjetos = engine.GetObjetoEscuela(
    out int conteoEvaluaciones,
    out int conteoCursos,
    out int conteoAsignaturas,
    out int conteoAlumnos
);*/






static void imprimirCursosEscuela(Escuela escuela)
{
    Printer.WriteTitle("Cursos de la Escuela");

    if (escuela?.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            Console.WriteLine($"Nombre {curso.nombre}, id {curso.uniqueId} Alumno {curso.Alumnos}");
        }
    }
}












