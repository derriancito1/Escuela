using System;
namespace CoreEscuela.Entidades
{
    public class Asignatura 
    {
        public string uniqueId {get; private set;}
        public string nombre { get; set;}
        public Asignatura()=> uniqueId = Guid.NewGuid().ToString();
    }
}