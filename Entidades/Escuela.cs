namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;

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

        public TiposEscuela tipoEscuela { get; set; }

        public Curso[] Cursos {get; set;}

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



    }
}