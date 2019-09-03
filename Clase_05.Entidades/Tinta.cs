using System;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _Color;
        private ETipoTinta _tipo;//constantes agrupadas bajo un nombre

        //constructor con sobrecarga, 0, 1 y 2 param
        public Tinta()
        {
            this._Color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.comun;
        }
        public Tinta(ConsoleColor miColor) : this()
        {
            this._Color = miColor;
        }
        public Tinta(ConsoleColor miColor, ETipoTinta miTinta) : this(miColor)
        {
            this._tipo = miTinta;
        }

        //metodos
        //de clase = static , instancia = no static

        private string Mostrar()//tipo de tinta y el color por mensaje
        {
            return "Color" + this._Color + "  Tipo:" + this._tipo;
        }

        public static string Mostrar(Tinta miTinta)
        {
            return miTinta.Mostrar();
        }

        //sobrecarga de operador
        public static bool operator ==(Tinta tintaUno, Tinta tintaDos)//color y tinta iguales
        {
            bool retorno = false;

            if(tintaUno._Color == tintaDos._Color && tintaUno._tipo == tintaDos._tipo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Tinta tintaUno, Tinta tintaDos)
        {
            return !(tintaUno == tintaDos);//uso la comparacion del == que cree para comparar pero negada   
        }

        public static bool operator ==(Tinta tintaUno, ConsoleColor color)//debe deovlver true si es el mismo color de tinta coincide con el console coolor del param
        {
            bool retorno = false;

            if(tintaUno._Color == color)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Tinta tintaUno, ConsoleColor color)
        {
            return !(tintaUno == color);
        }
        
        
        //casteo explicito, castear objeto tipo tinta y 
        public static explicit operator string(Tinta tintaUno)
        {
            //como solo tengo que mostrar utilizo el metodo que cree antes
            return tintaUno.Mostrar();//tintaUno._Color + " " + tintaUno._tipo;
        }
       
    }


    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        //constructor sobrecargado 0,1,2 y 3 param
        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 0;
        }
        public Pluma(string marc) : this()
        {
            this._marca = marc;
        }
        public Pluma(string marc, Tinta tint) : this(marc)
        {
            this._tinta = tint;
        }
        public Pluma(string marc, Tinta tint, int cant) : this(marc, tint)
        {
            this._cantidad = cant;
        }

        //METODOS
        private string Mostrar()//de instancia = no static
        {
            return this._marca + " " + Tinta.Mostrar(this._tinta) + " " + this._cantidad;
        }

        //SOBRECARGA DE OPERADORES
        //comparo la pluma que le paso con la tinta que le paso, si son iguales true, sino false
        public static bool operator ==(Pluma miPluma, Tinta miTinta)
        {
            return (miPluma._tinta == miTinta);
        }

        public static bool operator !=(Pluma miPluma, Tinta miTinta)
        {
            return !(miPluma == miTinta);
        }

        //tomar un objeto tipo pluma y sumarlo con un tipo tinta. si el atributo tinta de mi pluma es igual a la tinta que recibo
        //con el == , subo las tintas hasta un maximo de 100

        public static Pluma operator +(Pluma miPluma, Tinta miTinta)
        {
            if (miPluma._tinta == miTinta && miPluma._cantidad < 100)
            {
                miPluma._cantidad++;
            }
            return miPluma;
        }



        /*
         * en el main
         * tinta a = new tinta();
         * string b = (string)a;
         * pluma c = new pluma();
         * 
         * b=c;
         * c=c+a;
         * c+=a; // sirve para simular una sobrecarga con el operador sobrecargado +
         * 
         * 
         */
    }
}
