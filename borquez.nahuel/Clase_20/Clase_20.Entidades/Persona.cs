using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Clase_20.Entidades
{
    public class Persona: IXML
    {
        public string nombre;
        public string apellido;
        private int edad;
        private List<string> apodos;

        public Persona()
        {
            apodos = new List<string>();
        }

        public Persona(string nombre, string apellido, int edad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;

        }

        public int Edad { get { return this.edad; } set { this.edad = value; } }

        public List<string> Apodos { get { return this.apodos; } }


        public override string ToString()
        {
            return String.Format("Nombre: {0} - Apellido: {1}", this.nombre, this.apellido);
        }


        public bool Guardar(string str)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));

                StreamWriter streamWriter = new StreamWriter(str);
                xmlSerializer.Serialize(streamWriter, this);

                streamWriter.Close();
                Console.ReadKey();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
                return false;
            }
        }

        public bool Leer(string str, out object obj)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));

                StreamReader strReader = new StreamReader(str);

                obj = (Persona)xml.Deserialize(strReader);

                Console.ReadKey();

                return true;
            }
            catch (Exception e)
            {
                obj = null;
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return false;
            }
        }

    }
}