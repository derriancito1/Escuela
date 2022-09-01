using System.Linq;
using CoreEscuela.Entidades;
namespace CoreEscuela.Entidades
{
    public sealed class EscuelaEngine
    {
        public  Escuela Escuela { get; set; }

        
        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion
                            {
                                Asignatura = asignatura,
                                nombre = $"{asignatura.nombre} Ev#{i+1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

        public List<ObjetoEscuelaBase> GetObjetoEscuela()
        {
            var listaObj = new List<ObjetoEscuelaBase>();
            listaObj.Add(Escuela);
            listaObj.AddRange(Escuela.Cursos);

            foreach (var curso in Escuela.Cursos)
            {
                listaObj.AddRange(curso.Asignaturas);
                listaObj.AddRange(curso.Alumnos);

                foreach (var alumno in curso.Alumnos)
                {
                    listaObj.AddRange(alumno.Evaluaciones);
                }
            }
            return listaObj;
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{nombre="Matematicas"},
                    new Asignatura{nombre="Educacion Fisica"},
                    new Asignatura{nombre="Castellano"},
                    new Asignatura{nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno{nombre=$"{n1} {n2} {a1}"};
            return listaAlumnos.OrderBy((Al) => Al.uniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
                            {
                                new Curso() { nombre = "101", jornada=TiposJornada.Mañana},
                                new Curso() { nombre = "201", jornada=TiposJornada.Mañana},
                                new Curso() { nombre = "301", jornada=TiposJornada.Mañana},
                                new Curso() { nombre = "401", jornada=TiposJornada.Tarde},
                                new Curso() { nombre = "501", jornada=TiposJornada.Tarde}
                            };

            Random rnd = new Random();
            
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}