using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model
{
    public class Cuatrimestre
    {
        private ECuatrimestre periodo;
        private int anio;

        public ECuatrimestre Periodo { get { return periodo; } }
        public int Anio { get { return anio; } }

        public Cuatrimestre(ECuatrimestre cuatrimestre, int anio)
        {
            this.periodo = cuatrimestre;
            this.anio = anio;
        }

        public override string ToString()
        {
            string periodo = this.periodo.ToString();
            string anio = this.anio.ToString();

            return $"{periodo} {anio}";
        }

        public static string Keygen(ECuatrimestre periodo, int anio)
        {
            StringBuilder sb = new StringBuilder();

            if(periodo == ECuatrimestre.Primero)
            {
                sb.Append("1C");
            }
            else if (periodo == ECuatrimestre.Segundo)
            {
                sb.Append("2C");
            }
            else
            {
                sb.Append("VE");
            }
            sb.Append(anio.ToString());
            return sb.ToString();
        }

        public static string Keygen(Cuatrimestre cuatrimestre)
        {
            return Keygen(cuatrimestre.Periodo, cuatrimestre.Anio);
        }

        public static ECuatrimestre ParseECuatrimestre(string cuatrimestre)
        {
            ECuatrimestre ecuatrimestre = ECuatrimestre.Verano;

            if(cuatrimestre == "Primero")
            {
                ecuatrimestre = ECuatrimestre.Primero;
            }
            else if (cuatrimestre == "Segundo")
            {
                ecuatrimestre = ECuatrimestre.Segundo;
            }

            return ecuatrimestre;
        }
    }
}
