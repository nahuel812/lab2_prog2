using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_17.Entidades;

namespace Clase_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Carreta carreta1 = new Carreta(100);

            Familiar familiar1 = new Familiar(2000, "FGG554", 4);
            Deportivo deportivo1 = new Deportivo(3000, "QWE123", 200);

            Comercial comercial1 = new Comercial(5000, 500, 100);
            Privado privado1 = new Privado(7000, 800, 20);

            Console.WriteLine("Impuesto deportivo: {0}",deportivo1.CalcularImpuesto());
            Console.WriteLine("Impuesto comercial: {0}",comercial1.CalcularImpuesto());
            Console.WriteLine("Impuesto privado: {0}", privado1.CalcularImpuesto());

            Console.WriteLine(Gestion.MostrarImpuestoNacional(deportivo1));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(comercial1));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(privado1));



            Console.ReadKey();

        }
    }
}
