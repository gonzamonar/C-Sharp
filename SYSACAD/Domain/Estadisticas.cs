using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Estadisticas
    {
        //a.Calcular el promedio de alumnos inscriptos por materia.
        //b.Calcular la nota promedio de cada materia.

        //public static float CalcularPromedioInscriptos()
        //{
        //    float promedioInscriptos = 0;
        //    float cantidadInscriptos = CalcularTotalInscriptos();
        //    float cantidadMaterias = CalcularTotalMaterias();

        //    if (cantidadMaterias > 0)
        //    {
        //        promedioInscriptos = cantidadInscriptos / cantidadMaterias;
        //    }

        //    return promedioInscriptos;
        //}

        //public static int CalcularTotalMaterias()
        //{
        //    return repository.ListadoMaterias.Count;
        //}

        //public static int CalcularTotalInscriptos()
        //{
        //    int cantidadInscriptos = 0;

        //    foreach (Materia m in repository.ListadoMaterias.Values)
        //    {
        //        cantidadInscriptos += m.Inscriptos.Count();
        //    }

        //    return cantidadInscriptos;
        //}

        //public static int CalcularInscriptosPorMateria(Materia m)
        //{
        //    return m.Inscriptos.Count;
        //}

        //public static float CalcularNotaPromedioPrimerParcialPorMateria(Materia m)
        //{
        //    float totalInscriptos = m.Inscriptos.Count;
        //    float notaTotal = 0;
        //    float notaPromedioPP = 0;

        //    foreach(Inscripcion i in m.Inscriptos.Values)
        //    {
        //        notaTotal += i.NotaPrimerParcial;
        //    }

        //    if(totalInscriptos > 0)
        //    {
        //        notaPromedioPP = notaTotal / totalInscriptos;
        //    }

        //    return notaPromedioPP;
        //}

        //public static float CalcularNotaPromedioSegundoParcialPorMateria(Materia m)
        //{
        //    float totalInscriptos = m.Inscriptos.Count;
        //    float notaTotal = 0;
        //    float notaPromedioSP = 0;

        //    foreach (Inscripcion i in m.Inscriptos.Values)
        //    {
        //        notaTotal += i.NotaSegundoParcial;
        //    }

        //    if (totalInscriptos > 0)
        //    {
        //        notaPromedioSP = notaTotal / totalInscriptos;
        //    }

        //    return notaPromedioSP;
        //}

        //public static float CalcularNotaPromedioPorMateria(Materia m)
        //{
        //    float totalInscriptos = m.Inscriptos.Count;
        //    float notaTotal = 0;
        //    float notaPromedio = 0;

        //    foreach (Inscripcion i in m.Inscriptos.Values)
        //    {
        //        notaTotal += i.NotaPrimerParcial;
        //        notaTotal += i.NotaSegundoParcial;
        //    }

        //    if (totalInscriptos > 0)
        //    {
        //        notaPromedio = notaTotal / totalInscriptos;
        //    }

        //    return notaPromedio / 2;
        //}
    }
}
