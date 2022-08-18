using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades;

public class Curso
{
    public string uniqueId { get; private set; }
    public string nombre { get; set; }
    public TiposJornada jornada { get; set; }

    public Curso()
    {
        uniqueId = Guid.NewGuid().ToString();
    }

}
