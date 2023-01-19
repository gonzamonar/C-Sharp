using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal static partial class Error
    {
        internal static class Msg
        {
            private static readonly string isMandatory = "Error: El campo es obligatorio.";
            private static readonly string isNaN = "Error: Sólo se aceptan números.";
            private static readonly string isAlpha = "Error: Sólo se aceptan letras.";
            private static readonly string isAlphaWhite = "Error: Sólo se aceptan letras y espacios.";
            private static readonly string isAlphanum = "Error: Sólo se aceptan letras y números.";
            private static readonly string dgvError = "Ha ocurrido un error en la carga de la vista del Datagrid.";

            public static string IsMandatory { get { return isMandatory; } }
            public static string IsNaN { get { return isNaN; } }
            public static string IsAlpha { get { return isAlpha; } }
            public static string IsAlphanum { get { return isAlphanum; } }
            public static string IsAlphaWhite { get { return isAlphaWhite; } }
            public static string DgvError { get { return dgvError; } }


            public static string IsOutOfRange(string range)
            {
                return $"Error: El rango aceptado es {range}.";
            }

            public static string IsTooLong(string max)
            {
                return $"Error: El máximo permitido son {max} caracteres.";
            }

            public static string IsTooShort(string min)
            {
                return $"Error: El mínimo permitido son {min} caracteres.";
            }

            public static string IsNotSelected(string selection)
            {
                return $"Error: Debe seleccionar {selection}.";
            }

            public static string IsNotSelected()
            {
                return "Error: Debe seleccionar una opción.";
            }

            public static string KeyExists(string key)
            {
                return $"Error: {key} ya existe.";
            }
        }
    }
}
