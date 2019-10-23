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
            double impuesto = 0;
            impuesto = this._precio * 0.33;
            return impuesto;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }


    }
}
