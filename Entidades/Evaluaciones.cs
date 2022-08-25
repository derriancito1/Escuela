using System;
namespace CoreEscuela.Entidades
{
    public class Evaluaciones 
    {
        public string uniqueId {get; private set;}
        public string nombre { get; set;}
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura{get;set;}
        public float Nota { get; set; }
        public Evaluaciones()=> uniqueId = Guid.NewGuid().ToString();
    }
}