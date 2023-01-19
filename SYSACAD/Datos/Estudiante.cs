using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Estudiante : Persona
    {
        public static readonly int MaxInscripcionesPermitidas = 2;

        private List<Materia> materiasAprobadas;
        private Dictionary<string, Inscripcion> materiasInscripto;


        public List<Materia> MateriasAprobadas { get { return materiasAprobadas; } set { materiasAprobadas = value; } }
        public Dictionary<string, Inscripcion> MateriasInscripto { get { return materiasInscripto; } set { materiasInscripto = value; } }


        public Estudiante(string nombre, string apellido, int dni, EGenero genero, string username, string password, EPermiso credencial)
            : base(nombre, apellido, dni, genero, username, password, credencial)
        {
            MateriasAprobadas = new List<Materia>();
            MateriasInscripto = new Dictionary<string, Inscripcion>();
        }


        public bool DoesFulfillCorrelativities(Asignatura asignatura)
        {
            int count = 0;
            foreach(Asignatura correlativa in asignatura.Correlativas)
            {
                if (HadApprovedSubject(correlativa))
                {
                    count++;
                }
            }
            return count >= asignatura.Correlativas.Count;
        }

        public bool HadApprovedSubject(Asignatura asignatura)
        {
            bool approved = false;

            foreach (Materia materiaAprobada in MateriasAprobadas)
            {
                if (asignatura == materiaAprobada)
                {
                    approved = true;
                    break;
                }
            }

            return approved;
        }

        public bool IsEnrolled(Asignatura asignatura)
        {
            bool enrolled = false;

            foreach (Inscripcion inscripcion in MateriasInscripto.Values)
            {
                if (asignatura == inscripcion)
                {
                    enrolled = true;
                    break;
                }
            }

            return enrolled;
        }
    }
}
