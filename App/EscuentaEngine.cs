namespace CoreEscuela.Entidades
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");

            Escuela.Cursos = new List<Curso>()
                            {
                                new Curso() { nombre = "101", jornada=TiposJornada.Mañana},
                                new Curso() { nombre = "201", jornada=TiposJornada.Mañana},
                                new Curso() { nombre = "301", jornada=TiposJornada.Mañana},
                                new Curso() { nombre = "401", jornada=TiposJornada.Tarde},
                                new Curso() { nombre = "501", jornada=TiposJornada.Tarde}
                            };

        }
    }
}