using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALA.Extras
{
     public static class Formats
    {
        public static bool IsNumeric(string value)
        {
            int intValue;
            double doubleValue;

            // Intentar convertir la cadena en un número entero
            if (int.TryParse(value, out intValue))
            {
                return true; // La cadena es un número entero
            }
            // Intentar convertir la cadena en un número decimal
            else if (double.TryParse(value, out doubleValue))
            {
                return true; // La cadena es un número decimal
            }
            else
            {
                return false; // La cadena no es un número
            }
        }
    }
}
