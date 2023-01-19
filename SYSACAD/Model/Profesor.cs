using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Profesor : Persona
    {
        private List<Materia> materiasACargo;

        public List<Materia> MateriasACargo { get { return materiasACargo; } set { materiasACargo = value; } }

        public Profesor(string id, string nombre, string apellido, string dni, string genero, string username, string password, EPermiso credencial)
        : base(id, nombre, apellido, dni, genero, username, password, credencial)
        {
            MateriasACargo = new List<Materia>();
        }

    }
}
