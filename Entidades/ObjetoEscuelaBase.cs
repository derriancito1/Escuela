using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades;

public abstract class ObjetoEscuelaBase
{
    public string uniqueId {get; private set;}
    public string nombre { get; set;}

    public ObjetoEscuelaBase()
    {
        uniqueId = Guid.NewGuid().ToString();
    }
}
