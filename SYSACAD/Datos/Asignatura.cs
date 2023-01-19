using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Asignatura
    {
        private int codigo;
        private string codigoGenerico;
        private string titulo;
        private List<Asignatura> correlativas;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string CodigoGenerico { get { return codigoGenerico; } set { codigoGenerico = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public List<Asignatura> Correlativas { get { return correlativas; } set { correlativas = value; } }


        public Asignatura(int codigo, string codigoGenerico, string titulo)
        {
            Codigo = codigo;
            CodigoGenerico = codigoGenerico;
            Titulo = titulo;
            Correlativas = new List<Asignatura>();
        }

        public static bool operator ==(Asignatura a1, Asignatura a2)
        {
            return a1.Codigo == a2.Codigo;
        }

        public static bool operator !=(Asignatura a1, Asignatura a2)
        {
            return !(a1 == a2);
        }

        public static bool operator ==(Asignatura a, Inscripcion i)
        {
            return a.Codigo == i.Materia.Asignatura.Codigo;
        }

        public static bool operator !=(Asignatura a, Inscripcion i)
        {
            return !(a == i);
        }

        public static bool operator ==(Asignatura a, Materia m)
        {
            return a.Codigo == m.Asignatura.Codigo;
        }

        public static bool operator !=(Asignatura a, Materia m)
        {
            return !(a == m);
        }

    }
}
