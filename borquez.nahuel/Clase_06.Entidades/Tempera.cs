using System;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        //constructor
        public Tempera(ConsoleColor miColor, string miMarca,int miCant)
        {
            this._color = miColor;
            this._marca = miMarca;
            this._cantidad = miCant;
        }

        //metodos
        private string Mostrar()
        {
            return "Color:" + this._color + " Marca:" + this._marca + " Cantidad:" + this._cantidad;
        }

        //propiedades
        public string propTemperaMarca { get{return this._marca; } }
        public int propTemperaCant { get {return this._cantidad; } }
        public ConsoleColor propTemperaColor { get { return this._color; } }
    
        //sobrecarga de operadores
        public static implicit operator string (Tempera miTempera)
        {
            return miTempera.Mostrar();
        }

        /// <summary>
        /// Retorna true si los colores y las marcas de las dos temperas son iguales
        /// </summary>
        /// <param name="temperaUno"></param>
        /// <param name="temperaDos"></param>
        /// <returns></returns>
        public static bool operator ==(Tempera temperaUno, Tempera temperaDos)
        {
            bool retorno = false;
            //if (!temperaUno.Equals(null) && !temperaDos.Equals(null))
            if(!Object.Equals(temperaUno,null) && !Object.Equals(temperaDos,null))
            {
                if (temperaUno._marca == temperaDos._marca && temperaUno._color == temperaDos._color)
                {
                    retorno = true;
                }
            }
            else
            {
                //if (temperaUno.Equals(null) && temperaDos.Equals(null))

                if (Object.Equals(temperaUno, null) && Object.Equals(temperaDos, null))
                {
                    retorno = true;
                }
            }
                
            return retorno;
        }
        public static bool operator !=(Tempera temperaUno, Tempera temperaDos)
        {
            return !(temperaUno == temperaDos);
        }

        /// <summary>
        /// Agrega en temperaUno la cantidad pasada como parametro
        /// </summary>
        /// <param name="temperaUno"></param>
        /// <param name="cant"></param>
        /// <returns></returns>
        public static Tempera operator +(Tempera temperaUno, int cant)
        {
            //if (!temperaUno.Equals(null))
            if(!Object.Equals(temperaUno,null))
            {
                if( cant > 0)
                {
                    temperaUno._cantidad += cant;
                }
            }
            return temperaUno;
        }
        
        /// <summary>
        /// Agrega en temperaUno la cantidad de temperaDos si son iguales en color y marca.
        /// </summary>
        /// <param name="temperaUno"></param>
        /// <param name="temperaDos"></param>
        /// <returns></returns>
        public static Tempera operator +(Tempera temperaUno, Tempera temperaDos)
        {
            //if (!temperaUno.Equals(null) && !temperaDos.Equals(null))
            if(!Object.Equals(temperaUno,null) && !Object.Equals(temperaDos,null))
            {
                if (temperaUno == temperaDos)
                {
                    temperaUno = temperaUno + temperaDos._cantidad;
                    
                }
            }
            return temperaUno;
        }

        public static Tempera operator -(Tempera temperaUno, int cant)
        {
            //if (!temperaUno.Equals(null))
            if (!Object.Equals(temperaUno, null))
            {
                if (cant > 0)
                {
                    temperaUno._cantidad -= cant;
                    if(temperaUno._cantidad <= 0)
                    {
                        temperaUno = null;
                    }
               
                }
            }
            return temperaUno;
        }

        public static Tempera operator -(Tempera temperaUno, Tempera temperaDos)
        {
            if (!Object.Equals(temperaUno, null) && !Object.Equals(temperaDos, null))
            {
                if (temperaUno == temperaDos)
                {
                    temperaUno = temperaUno - temperaDos._cantidad;
                }
            }
            return temperaUno;
        }



    }
}
