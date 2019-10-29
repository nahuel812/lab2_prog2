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
    public class Auto : IXML
    {
        public string marca;
        public double precio;

        public Auto()
        {

        }

        public Auto(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public override string ToString()
        {
            return String.Format("Marca: {0} - Precio: {1}",this.marca,this.precio);
        }


        public bool Guardar(string str)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Auto));
                
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
                XmlSerializer xml = new XmlSerializer(typeof(Auto));
                
                StreamReader strReader = new StreamReader(str);

                obj = (Auto)xml.Deserialize(strReader);

                //Console.WriteLine("Deserialize: ");
                //Console.WriteLine(obj);
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
