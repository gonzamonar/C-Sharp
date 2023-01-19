using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Model.Enums;

namespace Model
{
    public abstract class Persona : Usuario
    {
        private string nombre;
        private string apellido;
        private int dni;
        private EGenero genero;


        public Persona(string nombre, string apellido, int dni, string username, string password, EPermiso credencial)
            : base(username, password, credencial)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.genero = EGenero.O;
        }

        public Persona(string nombre, string apellido, int dni, EGenero genero, string username, string password, EPermiso credencial)
            : this(nombre, apellido, dni, username, password, credencial)
        {
            this.genero = genero;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public EGenero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        override public string GetUserInfo()
        {
            string fullname =  $"{nombre} {apellido}";
            return fullname;
        }

        public override int GetUserId()
        {
            return dni;
        }

        public static EGenero CastEGenero(string genre)
        {
            EGenero genero = EGenero.O;
            if (genre is not null)
            {
                switch (genre)
                {
                    case "M":
                        genero = EGenero.M;
                        break;
                    case "F":
                        genero = EGenero.F;
                        break;
                    case "NB":
                        genero = EGenero.NB;
                        break;
                }
            }
            return genero;
        }
    }
}
