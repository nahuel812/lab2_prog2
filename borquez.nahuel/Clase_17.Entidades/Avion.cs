using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Avion : Vehiculo, IAFIP
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public double CalcularImpuesto()
        {
            //throw new NotImplementedException();
            return this._precio * 1.33;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }


    }
}
