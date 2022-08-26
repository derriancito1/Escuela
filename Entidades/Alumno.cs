using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Alumno 
    {
        public string uniqueId {get; private set;}
        public string nombre { get; set;}
        
        public List<Evaluacion> Evaluacion { get; set; }

        

        public Alumno()
        {
            this.uniqueId = Guid.NewGuid().ToString();

            this.Evaluacion = new List<Evaluacion>(){};

        }
    }
}