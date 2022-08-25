using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using System;

var engine = new EscuelaEngine();
engine.Inicializar();
imprimirCursosEscuela(engine.Escuela);

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












