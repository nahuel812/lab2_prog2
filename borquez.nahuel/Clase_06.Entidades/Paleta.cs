using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaximaColores;

        public int PropCantidad { get { return this._cantMaximaColores; } }

        private Paleta() : this(5)//llama al constructor de abajo, y lo inicializa con 5 si es el default
        {

        }

        private Paleta(int maxima)
        {
            this._cantMaximaColores = maxima;
            this._colores = new Tempera[_cantMaximaColores];
        }
        
        public static implicit operator Paleta(int cantidad)//crea la cantidad de paletas q le pase
        {
            Paleta paletaAux = new Paleta(cantidad);
            return paletaAux;
        }

        /// <summary>
        /// Muestra la cant maxima de colores en paleta, y la lista de los colores en el array de paleta
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            string retorno = "";
            retorno = "Cant maxima de colores:" + this._cantMaximaColores.ToString()+"\n";

            for (int i = 0; i < this._colores.Length; i++)
            {
                if (!Object.Equals(this._colores[i],null))
                {
                    retorno += this._colores[i];
                    //retorno += "\n";
                }
            }
            return retorno;
        }

        public static explicit operator string(Paleta paletaUno)
        {
            return paletaUno.Mostrar();
        }
        //sobrecargas de operadores
        public static bool operator ==(Paleta paletaUno,Tempera temperaUno)
        {
            bool retorno = false;
            int i;

            //if(!paletaUno.Equals(null) && !temperaUno.Equals(null))
            if (!Object.Equals(paletaUno, null) && !Object.Equals(temperaUno, null))
            {
                for (i = 0; i < paletaUno._colores.Length; i++)
                {
                    if (paletaUno._colores[i] == temperaUno)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            else
            {
                //if (paletaUno.Equals(null) && temperaUno.Equals(null))

                if (!Object.Equals(paletaUno, null) && !Object.Equals(temperaUno, null))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta paletaUno, Tempera temperaUno)
        {
            return !(paletaUno == temperaUno);
        }

        public static Paleta operator +(Paleta paletaUno, Tempera temperaUno)
        {
            int indice = -1;
            if (paletaUno == temperaUno)
            {
                //significa que esta, le agrego la cantidad al color de la posicion
                indice = paletaUno | temperaUno;
                if(indice != -1)
                {
                    paletaUno._colores[indice] += temperaUno;
                }
            }
            else
            {
                //si no esta lo agrego en el primer lugar libre
                indice = paletaUno.BuscarLibre();
                paletaUno._colores[indice] = temperaUno;//asignacion directa, lo agrego en ese indice

            }
            return paletaUno;
        }

        private int BuscarLibre()
        {
            int indice = -1;
            for (int i = 0; i <= this._colores.Length; i++)
            {
                //if (this._colores[i].Equals(null))//cuando es null esta libre
                if (this._colores[i] == null)
                {
                    indice = i;//retorno el indice
                    break;
                }
            }

            return indice;
        }

        /// <summary>
        /// Devuelve el indice de donde se encuentra la tempera pasada como parametro, sino -1
        /// </summary>
        /// <param name="paletaUno"></param>
        /// <param name="temperaUno"></param>
        /// <returns></returns>
        public static int operator |(Paleta paletaUno, Tempera temperaUno)
        {
            int respuesta = -1;

            for (int i = 0; i < paletaUno._colores.Length; i++)
            {
                if (paletaUno == temperaUno)
                {
                    respuesta = i;
                    break;
                }
            }

            return respuesta;
        }

        public static Paleta operator -(Paleta paletaUno,Tempera temperaUno)
        {
            int indice = -1;
            if (paletaUno == temperaUno)
            {
                //significa que esta, le agrego la cantidad al color de la posicion
                indice = paletaUno | temperaUno;
                if (indice != -1)
                {
                    paletaUno._colores[indice] -= temperaUno;

                }
            }
            
            return paletaUno;
        }

        public Tempera this[int index]
        {
            get { return this._colores[index]; }//agregar verificacion del index para que no sea menor a 0

            set { this._colores[index] = value; }
        }
    }
}
