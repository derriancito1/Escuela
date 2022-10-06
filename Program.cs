using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using System;
using CoreEscuela.Util;
using System.Linq;
using CoreEscuela.App;

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

var reporteador = new Reporteador(engine.GetDiccionarioObjetos());
reporteador.GetListaEvaluaciones();








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












