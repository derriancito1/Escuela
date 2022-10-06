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

    public IEnumerable<Evaluacion> GetListaEvaluaciones()
    {
        if (_diccionario.TryGetValue(LlavesDiccionario.Evaluacion,out IEnumerable<ObjetoEscuelaBase> lista))
        {
            return lista.Cast<Evaluacion>();
        }else
        {
            return new List<Evaluacion>();
            //Escribir en log
        }
    }

    public IEnumerable<string> GetListaAsignaturas()
    {
        var listaEvaluaciones = GetListaEvaluaciones();
        return (from Evaluacion ev in listaEvaluaciones 
        where ev.Nota >= 3.0f
        select ev.Asignatura.nombre).Distinct();
    }

    public Dictionary<string, IEnumerable< Evaluacion>> GetDicEvaluaXAsig()
    {
        var dictaRta = new Dictionary<string, IEnumerable<Evaluacion>>();
        return dictaRta;
    }
}


