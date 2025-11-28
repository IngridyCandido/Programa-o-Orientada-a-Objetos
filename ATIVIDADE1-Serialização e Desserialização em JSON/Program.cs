using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;

namespace ATIVIDADE1_Serialização_e_Desserialização_em_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serializando com Json...");
            SerializarJson();
            Console.WriteLine("Serialização concluída.");
            Console.WriteLine("Agora ele será deserializado...");
            DeserializarJson();
            Console.WriteLine("Deserialização concluída.");
        }
        private static void SerializarJson()
        {
            Produto obj = new Produto();
            obj.Id = 1;
            obj.Nome = "Feijão";
            obj.Preco = 3.99;
            obj.Quantidade = 9;
            string jsonString = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            File.WriteAllText("produto.json", jsonString);
            Console.WriteLine("Objeto serializado em produto.json");
            Console.WriteLine(jsonString);
        }

        private static void DeserializarJson()
        {
            string jsonLido = File.ReadAllText("produto.json");
            Produto obj = JsonSerializer.Deserialize<Produto>(jsonLido);
            Console.WriteLine("\nObjeto deserealizado:");
            Console.WriteLine($"ID: {obj.Id}.");
            Console.WriteLine($"Nome: {obj.Nome}.");
            Console.WriteLine($"Preço: {obj.Preco}.");
            Console.WriteLine($"Quantidade: {obj.Quantidade}.");
        }
    }
}
