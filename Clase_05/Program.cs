using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05.Entidades;
namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta a = new Tinta();
            
            string b = (string)a;//uso la sobrecarga unaria
            Console.WriteLine("Muestro a b: {0}",b);

            Console.WriteLine("Muestro a a: ");

            Pluma c = new Pluma();
            //testear las combinaciones de si son iguales las tintas, si puedo mostrar la pluma, 
            //usar los explicits y implicits

            //b = c;
            c = c + a;
            c += a;
            
        }
    }
}
