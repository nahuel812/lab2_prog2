using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de lista Centralita -> central
            Centralita central = new Centralita("Telefonica");

            //Creacion de nuevas llamadas ( 2 locales, 2 provinciales)
            Local localUno = new Local("Avellaneda", (float)0.30, "Lanus", (float)2.65);
            Provincial provincialUno = new Provincial("Corrientes", (Franja)0, 21, "Sanfa Fe");
            Local localDos = new Local("Puerto Madero", 45, "Quilmes", (float)1.99);
            Provincial provincialDos = new Provincial((Franja)2, provincialUno);

            //Se agregan a la lista de a uno y se muestra la lista
            central += localUno;
            Console.WriteLine("Se agrego primer llamada local\n" + central.ToString());
            Console.ReadKey();
            central += provincialUno;
            Console.WriteLine("Se agrego primer llamada provincial\n" + central.ToString());
            Console.ReadKey();
            central += localDos;
            Console.WriteLine("Se agrego segunda llamada local\n" + central.ToString());
            Console.ReadKey();
            central += provincialDos;
            Console.WriteLine("Se agrego segunda llamada Provincial\n" + central.ToString());
            Console.ReadKey();
            Console.Clear();

            //Se intentara agregar la primer llamada nuevamente
            Console.WriteLine("Se agrego primer llamada local nuevamente\n");
            central += localUno;
            Console.ReadKey();
            //Se muestra el listado completo
            Console.Clear();
            Console.WriteLine("Listado completo: \n\n" + central.ToString());

            //Ordenamiento de la lista
            Console.Clear();
            Console.WriteLine("Se ordenara la lista y mostrara nuevamente ordenada.\n");
            Console.WriteLine("Lista sin ordenar:\n" + central.ToString());
            central.OrdenarLLamadas();
            Console.WriteLine("Lista ordenada:\n" + central.ToString());
            Console.ReadLine();

            Console.WriteLine("Ganancia Local: " + central.CalcularGanancia((ETipoLlamada) 0));
            Console.WriteLine("Ganancia Provincial: " + central.CalcularGanancia((ETipoLlamada)1));
            Console.WriteLine("Ganancia Total: " + central.CalcularGanancia((ETipoLlamada)2));
            Console.ReadLine();
        }
    }
}
