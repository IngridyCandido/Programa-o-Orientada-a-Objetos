using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LocadoraFilme
{
    public static class BDusuarios
    {
        private static string arquivo = "usuarios.xml";

        public static void adicionarUsuario(List<usuario> lista)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<usuario>));
            using (StreamWriter writer = new StreamWriter(arquivo))
            {
                serializer.Serialize(writer, lista);
            }
        }
        public static List<usuario> listarUsuarios()
        {
            if (!File.Exists(arquivo)) return new List<usuario>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<usuario>));
                using (StreamReader reader = new StreamReader(arquivo))
                {
                    return (List<usuario>)serializer.Deserialize(reader);
                }
            }
            catch
            {
                return new List<usuario>();
            }
        }
    }
}
