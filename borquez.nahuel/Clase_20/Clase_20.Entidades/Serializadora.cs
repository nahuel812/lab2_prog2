using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    static class Serializadora
    {
        public static bool Serializar(IXML ixml)
        {
            return ixml.Guardar("ixml.xml");
        }

        public static bool Deserializar(IXML ixml, out object obj)
        {
            return ixml.Leer("ixml.xml", out obj);

        }
    }
}
