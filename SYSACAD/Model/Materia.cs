using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Materia
    {
        private string codigo;
        private Asignatura asignatura;
        private Cuatrimestre cuatrimestre;
        private List<Profesor> docentes;
        private Dictionary<string, Inscripcion> inscriptos;

        public string Codigo { get { return codigo; } set { codigo = value; } }
        public Asignatura Asignatura { get { return asignatura; } set { asignatura = value; } }
        public Cuatrimestre Cuatrimestre { get { return cuatrimestre; } set { cuatrimestre = value; } }
        public List<Profesor> Docentes { get { return docentes; } set { docentes = value; } }
        public Dictionary<string, Inscripcion> Inscriptos { get { return inscriptos; } set { inscriptos = value; } }


        public Materia(Asignatura asignatura, Cuatrimestre cuatrimestre)
        {
            codigo = Keygen(asignatura, cuatrimestre);
            this.asignatura = asignatura;
            this.cuatrimestre = cuatrimestre;
            docentes = new List<Profesor>();
            inscriptos = new Dictionary<string, Inscripcion>();
        }


        public static string Keygen(Asignatura asignatura, Cuatrimestre cuatrimestre)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(asignatura.CodigoGenerico);
            sb.Append("_");
            sb.Append(Cuatrimestre.Keygen(cuatrimestre));

            return sb.ToString();
        }

        public static string Keygen(string codigoGenericoAsignatura, string codigoCuatrimestre)
        {
            StringBuilder sb = new StringBuilder();

            if(codigoGenericoAsignatura is not null && codigoCuatrimestre is not null)
            {
                sb.Append(codigoGenericoAsignatura);
                sb.Append("_");
                sb.Append(codigoCuatrimestre);
            }

            return sb.ToString();
        }


        public string InformeDocentesACargo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("");
            int q = Docentes.Count();
            if (q > 0)
            {
                foreach (Profesor p in Docentes)
                {
                    sb.Append($"{p.GetUserInfo()}");
                    q--;
                    if (q > 1)
                    {
                        sb.Append(", ");
                    }
                    else if (q == 1)
                    {
                        sb.Append(" y ");
                    }
                }
            }
            return sb.ToString();
        }

        public bool IsExamCreated(ETipoExamen examen)
        {
            bool isCreated = false;
            if(inscriptos.Count() > 0)
            {
                if(examen == ETipoExamen.PrimerParcial && inscriptos.Values.First().PrimerParcial is not null)
                {
                    isCreated = true;
                }

                if (examen == ETipoExamen.SegundoParcial && inscriptos.Values.First().SegundoParcial is not null)
                {
                    isCreated = true;
                }
            }
            return isCreated;
        }


        public static bool operator ==(Materia m1, Materia m2)
        {
            return m1.Codigo == m2.Codigo;
        }

        public static bool operator !=(Materia m1, Materia m2)
        {
            return !(m1 == m2);
        }

        public static bool operator ==(Materia m, Inscripcion i)
        {
            return m.Codigo == i.Materia.Codigo;
        }

        public static bool operator !=(Materia m, Inscripcion i)
        {
            return !(m == i);
        }

        public static bool operator ==(Materia m, Asignatura a)
        {
            return m.Asignatura.Codigo == a.Codigo;
        }
        
        public static bool operator !=(Materia m, Asignatura a)
        {
            return !(m == a);
        }
    }
}