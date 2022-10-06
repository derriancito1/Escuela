using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEscuela.Entidades;

namespace CoreEscuela.App;

public class Reporteador
{
    Dictionary<LlavesDiccionario, IEnumerable<ObjetoEscuelaBase>> _diccionario;
    public Reporteador(Dictionary<LlavesDiccionario, IEnumerable<ObjetoEscuelaBase>> dicObsEsc)
    {
        if (dicObsEsc == null)
        {
            throw new ArgumentException(nameof(dicObsEsc));
        }
        _diccionario = dicObsEsc;
    }

    public IEnumerable<Escuela> GetListaEvaluaciones()
    {
        IEnumerable<Escuela> rta;
        if (_diccionario.TryGetValue(LlavesDiccionario.Escuela,out IEnumerable<ObjetoEscuelaBase> lista))
        {
            rta = lista.Cast<Escuela>();
        }else
        {
            rta = null;
            //Escribir en log
        }
       //var respuesta = _diccionario.TryGetValue(LlavesDiccionario.Escuela,out IEnumerable<ObjetoEscuelaBase> lista);
        return rta;
    }
}

