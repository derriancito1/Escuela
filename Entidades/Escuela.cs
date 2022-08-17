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

        private int myVar;

        public Escuela(string nombre, int anoDeCreacion, string pais, string ciudad)
        {
            this.nombre = nombre;
            this.anoDeCreacion = anoDeCreacion;
            this.pais = pais;
            this.ciudad = ciudad;
        }



    }
}