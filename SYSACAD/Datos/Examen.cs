using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Examen
    {
        private ETipoExamen tipo;
        private DateOnly fecha;

        public ETipoExamen Tipo { get { return tipo; } set { tipo = value; } }
        public DateOnly Fecha { get { return fecha; } set { fecha = value; } }

        public Examen(ETipoExamen tipo, DateOnly fecha)
        {
            Tipo = tipo;
            Fecha = fecha;
        }
    }
}
