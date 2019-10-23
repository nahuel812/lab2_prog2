using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos) : base(precio,patente)
        {
            this._cantAsientos = cantidadAsientos;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }

        public override void MostrarPatente()
        {
            Console.WriteLine(this._patente);
        }

    }
}
