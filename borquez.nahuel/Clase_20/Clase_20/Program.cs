using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Clase_20.Entidades;

namespace Clase_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona miPersona = new Persona("Juan", "Perez");

            //Console.WriteLine(miPersona);//.ToString());
            //Console.ReadKey();


            ////serializacion
            //try
            //{
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

            //    // = new XmlTextWriter();
            //    //uso uno de los dos

            //    StreamWriter streamWriter = new StreamWriter("persona.xml");
            //    xmlSerializer.Serialize(streamWriter, miPersona);
            //    streamWriter.Close();


            //    XmlTextWriter txtWriter = new XmlTextWriter("persona2.xml", Encoding.UTF8);
            //    xmlSerializer.Serialize(txtWriter, miPersona);
            //    txtWriter.Close();

                
                
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //}

            ////deserializacion
            //try
            //{
            //    XmlSerializer xml = new XmlSerializer(typeof(Persona));


            //    StreamReader strReader = new StreamReader("persona.xml");
                
            //    miPersona = (Persona)xml.Deserialize(strReader);

            //    Console.WriteLine("Deserialize: ");
            //    Console.WriteLine(miPersona);
            //    Console.ReadKey();


            //    ///con textReader
            //    XmlTextReader txtReader = new XmlTextReader("persona2.xml");
                
            //    miPersona = (Persona)xml.Deserialize(txtReader);

            //    Console.WriteLine("Deserialize: ");
            //    Console.WriteLine(miPersona);
            //    Console.ReadKey();

            //}
            //catch(Exception e )
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //}

            ///LISTA GENERICA

            //List<Persona> lista = new List<Persona>();

            //Persona p1 = new Persona("pablo", "diaz",55);
            //Persona p2 = new Persona("asdf", "hdfh",20);
            //Persona p3 = new Persona("qwer", "dfhf",25);
            //Persona p4 = new Persona("zxcv", "vmbnm",44);

            ////agrego apodos
            //p1.Apodos.Add("qqqq");
            //p1.Apodos.Add("qqqq2");
            //p2.Apodos.Add("wwwwww");
            //p3.Apodos.Add("wwwwww");
            //p4.Apodos.Add("eeeeee");


            ////los agrego a la lsita
            //lista.Add(p1);
            //lista.Add(p2);
            //lista.Add(p3);
            //lista.Add(p4);
            
            
            //try
            //{
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));


            //    StreamWriter streamWriter = new StreamWriter("lista.xml");
            //    xmlSerializer.Serialize(streamWriter, lista);
                
            //    streamWriter.Close();
            //    Console.ReadKey();

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //}

            //Auto a1 = new Auto("asdf", 2222);

            //a1.Guardar("guardar.xml");
            //Console.ReadKey();

            
            //a1.Leer("guardar.xml",out object a2 );
            //Console.WriteLine(a2.ToString());
            //Console.ReadKey();

            /*
            Persona p1 = new Persona("xczv", "bcvnbn", 66);

            p1.Guardar("guardar.xml");
            Console.ReadKey();
            */

            //////////////////////////////////////////
            //

            List<Persona> personas = new List<Persona>();

            Persona p1 = new Persona("pedro", "perez", 44);
            Empleado e1 = new Empleado("carlos", "diaz", 33, 12345, 23.445);
            Alumno a1 = new Alumno("juan", "sanchez", 23, 9);

            personas.Add(p1);
            personas.Add(e1);
            personas.Add(a1);

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
                
                StreamWriter streamWriter = new StreamWriter("listaPersonas.xml");
                xmlSerializer.Serialize(streamWriter, personas);

                streamWriter.Close();
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
            Console.ReadLine();
        }
    }
}
