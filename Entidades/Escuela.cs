using System.Collections.Generic;
using CoreEscuela.Util;

namespace CoreEscuela.Entidades
{
    public class Escuela : ObjetoEscuelaBase,ILugar
    {
        public string Nombre
        {
            get { return "Copia "+ nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int anoDeCreacion
        {
            get; set;
        }

        public string pais { get; set; }

        public string ciudad { get; set; }

        public string direccion { get; set; }

        public TiposEscuela tipoEscuela { get; set; }

        public List<Curso> Cursos {get; set;}

        public Escuela(string nombre, int anoDeCreacion, string pais, string ciudad)
        {
            this.nombre = nombre;
            this.anoDeCreacion = anoDeCreacion;
            this.pais = pais;
            this.ciudad = ciudad;
        }

        public Escuela(string nombre, int anoDeCreacion, TiposEscuela tiposEscuela, string pais="", string ciudad="")
        {
            this.nombre = nombre;
            this.anoDeCreacion = anoDeCreacion;
            this.pais = pais;
            this.ciudad = ciudad;
            this.tipoEscuela = tipoEscuela;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Tipo: {tipoEscuela} Pais: {pais}, Ciudad: {ciudad} {System.Environment.NewLine}";
        }


        public void limpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando Escuela...");
            foreach (var curso in Cursos)
            {
                curso.limpiarLugar();
            }
            Console.WriteLine($"Escuela {nombre} Limpio");
        }



    }
}