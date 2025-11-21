using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace AulaPOOSerializacaoObjetoXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Serializando objeto...");
            //string arquivo = WriteXML();
            //Console.WriteLine("Objeto gravado no disco em " + arquivo);
            ReadXML();
        }
        public static string WriteXML()
        {
            Book livro = new Book();
            livro.title = "Harry Potter 1 - A Pedra Filosofal";
            //Prepara objeto serializador:
            XmlSerializer writer = new XmlSerializer(typeof(Book));
            //Prepara o arquivo XML para gravar no disco:
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\livro.xml";
            FileStream arquivoXML = File.Create(path);
            //Realiza a serialização e gravação no disco:
            writer.Serialize(arquivoXML, livro);
            arquivoXML.Close();
            return path;
        }
        public static void ReadXML()
        {
            //Prepara objeto serializador:
            XmlSerializer reader = new XmlSerializer(typeof(Book));
            //Prepara o arquivo XML
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\livro.xml";
            StreamReader arquivoXML = new StreamReader(path);
            //Deserialização do XML para objeto:
            Book livro = (Book)reader.Deserialize(arquivoXML);
            arquivoXML.Close();

            Console.WriteLine($"O livro lido foi: {livro.title}");
        }
    }
}
