using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public class Carreta : Vehiculo
    {
        public Carreta(double precio) : base(precio)
        {

        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
    }
}
