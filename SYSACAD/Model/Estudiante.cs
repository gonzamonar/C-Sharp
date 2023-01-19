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

        //private List<Materia> materiasAprobadas;
        private List<Materia> materiasInscripto;
        

        //public List<Materia> MateriasAprobadas { get { return materiasAprobadas; } set { materiasAprobadas = value; } }
        public List<Materia> MateriasInscripto { get { return materiasInscripto; } set { materiasInscripto = value; } }

        
        public Estudiante(string id, string nombre, string apellido, string dni, string genero, string username, string password, EPermiso credencial)
        : base(id, nombre, apellido, dni, genero, username, password, credencial)
        {
            //MateriasAprobadas = new List<Materia>();
            MateriasInscripto = new List<Materia>();
        }

    }
}