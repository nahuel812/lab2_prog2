using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public static class Gestion
    {
        //devuelve el impusto que le cobro al vehiculo
        public static double MostrarImpuestoNacional(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

    }
}
