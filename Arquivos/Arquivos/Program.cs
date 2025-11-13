using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string NomeArquivo;
                Console.WriteLine("Informe um nome para o arquivo com extensão: ");
                NomeArquivo = Console.ReadLine();

                // Verifica se o arquivo existe:

                if (!File.Exists(NomeArquivo))
                {
                    throw new ArquivoInvalidoException("O arquivo não existe no caminho informado.");
                }
                // Verifica se é um arquivo .txt

                if (Path.GetExtension(NomeArquivo).ToLower() != ".txt")
                {
                    Console.WriteLine("Tipo de arquivo inválido, por favor, insira um nome no formato .txt!");
                }
                // Ler e exibir o conteúdo do arquivo:

                string conteudo = File.ReadAllText(NomeArquivo);
                Console.WriteLine("O conteúdo do arquivo " + NomeArquivo + " é: \n" + conteudo);
            }
            catch (ArquivoInvalidoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (IOException)
            {
                Console.WriteLine("Ocorreu uma falha inesperada de entrada e saída.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu uma falha inesperada.");
            }
            finally
            {
                Console.WriteLine("Programa encerrado.");
            }
        }
    }
}
