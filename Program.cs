using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using System;
using CoreEscuela.Util;
using System.Linq;

AppDomain.CurrentDomain.ProcessExit += AccionDelEvento;
AppDomain.CurrentDomain.ProcessExit += (o, s)=>Printer.Beep(100,1000,1);
void AccionDelEvento(object? sender, EventArgs e)
{
    Printer.WriteTitle("Saliendo");
    Printer.Beep(3000,1000,2);
    Printer.WriteTitle("Salio");
}

var engine = new EscuelaEngine();
engine.Inicializar();
Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
//Printer.Beep(10000, cantidad:10);
//imprimirCursosEscuela(engine.Escuela);

Dictionary<int, string> diccionario = new Dictionary<int, string>();

diccionario.Add(10, "JuanK");
diccionario.Add(23, "Lorem Ipsum");

foreach (var keyValPair in diccionario)
{
    Console.WriteLine($"key: {keyValPair.Key} valor {keyValPair.Value}");
}

var dictmp = engine.GetDiccionarioObjetos();

engine.ImprimirDiccionario(dictmp,true);







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












