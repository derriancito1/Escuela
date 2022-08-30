using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using System;
using CoreEscuela.Util;

var engine = new EscuelaEngine();
engine.Inicializar();
Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
//Printer.Beep(10000, cantidad:10);
imprimirCursosEscuela(engine.Escuela);

Printer.DrawLine(20);
Printer.DrawLine(20);
Printer.DrawLine(20);
Printer.WriteTitle("Pruebas de polimorfismo");

var alumnoTest = new Alumno{nombre="Claire UnderWood"};
ObjetoEscuelaBase ob = alumnoTest;

Printer.WriteTitle("Alumno");
Console.WriteLine($"Alumno: {alumnoTest.nombre}");
Console.WriteLine($"Alumno: {alumnoTest.uniqueId}");
Console.WriteLine($"Alumno: {alumnoTest.GetType()}");


Printer.WriteTitle("ObjetoEscuela");
Console.WriteLine($"Alumno: {ob.nombre}");
Console.WriteLine($"Alumno: {ob.uniqueId}");
Console.WriteLine($"Alumno: {ob.GetType()}");

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












