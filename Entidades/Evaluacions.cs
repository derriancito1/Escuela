using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Evaluacion 
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura{get;set;}
        public string nombre { get; set;}
        public float Nota { get; set; }
        
        public override string ToString()
        {
            return $"{Nota}, {Alumno.nombre}, {Asignatura.nombre}";
        }
    }
}