using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SerializaçãoBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serializando binariamente o objeto.");
            //SerializarBinario();
            //SerializarSOAP();
            SerializarJson();
            Console.WriteLine("Serialização concluída");
        }

        private static void SerializarBinario()
        {
            MyObject obj = new MyObject();
            obj.n1 = 1;
            obj.n2 = 24;
            obj.str = "Aula de POO de Serialização Binária";
            IFormatter formatter = new BinaryFormatter();
            Stream arquivoBinario = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(arquivoBinario, obj);
            arquivoBinario.Close();
        }

        private static void SerializarSOAP()
        {
            MyObject obj = new MyObject();
            obj.n1 = 1;
            obj.n2 = 24;
            obj.str = "Aula de POO de Serialização com Soapformatter";
            IFormatter formatter = new SoapFormatter();
            Stream arquivoBinario = new FileStream("MyFileSoap.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(arquivoBinario, obj);
            arquivoBinario.Close();
        }
        private static void SerializarJson()
        {
            MyObject obj = new MyObject();
            obj.n1 = 1;
            obj.n2 = 24;
            obj.str = "Aula de POO de Serialização em JsonSerializer";
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText("MyFileJson.json", jsonString);
        }
    }
}
