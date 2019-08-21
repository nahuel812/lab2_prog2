using System;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje = "Hola mundo";
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;//le cambio el color

            //Console.WriteLine("{0}", Sello.Imprimir());//muestro con el color
            Console.WriteLine("{0}", Sello.ArmarFormatoMensaje());

            Console.ForegroundColor = ConsoleColor.Gray;//vuelvo al color normal
            
        }

        static string ArmarFormatoMensaje()
        {
            string techo = "**";
            int i;
            int len;
            len = Sello.mensaje.Length;

            for (i=0;i<len;i++)
            {
                techo += "*"; //concateno el * hasta el final del len
            }

            return techo + "\n" + "*" + Sello.mensaje + "*\n" + techo;//retorno el mensaje armado
        }
    }
}
