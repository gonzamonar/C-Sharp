using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Inscripcion
    {
        private Estudiante alumno;
        private Materia materia;
        private ECondicion condicion;
        private Examen primerParcial;
        private int notaPrimerParcial;
        private Examen segundoParcial;
        private int notaSegundoParcial;
        private bool asistencia;

        public Estudiante Alumno { get { return alumno; } set { alumno = value; } }
        public Materia Materia { get { return materia; } set { materia = value; } }
        public ECondicion Condicion { get { return condicion; } set { condicion = value; } }
        public Examen PrimerParcial { get { return primerParcial; } set { primerParcial = value; } }
        public int NotaPrimerParcial { get { return notaPrimerParcial; } set { notaPrimerParcial = value; } }
        public Examen SegundoParcial { get { return segundoParcial; } set { segundoParcial = value; } }
        public int NotaSegundoParcial { get { return notaSegundoParcial; } set { notaSegundoParcial = value; } }
        public bool Asistencia { get { return asistencia; } set { asistencia = value; } }

        public Inscripcion(Estudiante estudiante, Materia materia)
        {
            Alumno = estudiante;
            Materia = materia;
            Condicion = ECondicion.regular;
            PrimerParcial = null;
            SegundoParcial = null;
            Asistencia = false;
        }

        public static bool operator ==(Inscripcion i, Materia m)
        {
            return i.Materia == m;
        }

        public static bool operator !=(Inscripcion i, Materia m)
        {
            return !(i == m);
        }

        public static bool operator ==(Inscripcion i, Asignatura a)
        {
            return i.Materia.Asignatura.Codigo == a.Codigo;
        }

        public static bool operator !=(Inscripcion i, Asignatura a)
        {
            return !(i == a);
        }
    }
}
