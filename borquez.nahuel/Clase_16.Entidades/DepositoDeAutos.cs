using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16.Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                //comparar con ==
                if( d._lista.Contains(a) != true)
                {
                    d._lista.Add(a);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        
        private int GetIndice(Auto a)
        {
            return this._lista.IndexOf(a);
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if (d._lista.Contains(a) == true)
            {
                //usar getindice
                d._lista.Remove(a);
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        
        public bool Agregar(Auto a)
        {
            return (this + a);
        }

        public bool Remover(Auto a)
        {
            return (this - a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad maxia: {0}\nListado de Autos:\n", this._capacidadMaxima);
            foreach (Auto item in this._lista)
            {
                sb.AppendFormat(item.ToString());
            }
            return sb.ToString();
        }

    }
}
