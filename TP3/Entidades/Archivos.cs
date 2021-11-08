using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Entidades
{
    public class Archivos
    {
        /// <summary>
        /// Metodo genérico para serializar objetos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruta"></param>
        /// <param name="objeto"></param>
        public static void SerializarAXml<T>(string ruta, T objeto)
        {
            using (XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, objeto);
            }
        }

        /// <summary>
        /// Metodo genérico para deserializar objetos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public static T DeserializarDesdeXml<T>(string ruta) where T : class
        {
            using (XmlTextReader streamReader = new XmlTextReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                T objeto = xmlSerializer.Deserialize(streamReader) as T;
                return objeto;
            }
        }

    }
}
