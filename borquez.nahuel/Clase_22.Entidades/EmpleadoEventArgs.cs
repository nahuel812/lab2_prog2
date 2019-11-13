using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_22.Entidades;

namespace Clase_22.Entidades
{
    public class EmpleadoEventArgs : EventArgs
    {
        public double SueldoAsignar
        {
            get; 
            set;
        }
        
    }
}
