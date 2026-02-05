using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Locadora
{
    public static class BDFilmes
    {
        private const string Arquivo = "filmes.json";

        // Lista de filmes padrão usada para inicializar o arquivo na primeira execução.
        private static List<Filmes> ListaPadrao()
        {
            return new List<Filmes>
                {
                    new Filmes { Id = 1, Titulo = "O Poderoso Chefão", Genero = "Drama/Crime", Ano = 1972, Disponivel = true, Diretor = "Francis Ford Coppola" },
                    new Filmes { Id = 2, Titulo = "De Volta para o Futuro", Genero = "Aventura/Ficção", Ano = 1985, Disponivel = true, Diretor = "Robert Zemeckis" },
                    new Filmes { Id = 3, Titulo = "Clube da Luta", Genero = "Drama", Ano = 1999, Disponivel = true, Diretor = "David Fincher" },
                    new Filmes { Id = 4, Titulo = "A Viagem de Chihiro", Genero = "Animação/Fantasia", Ano = 2001, Disponivel = true, Diretor = "Hayao Miyazaki" },
                    new Filmes { Id = 5, Titulo = "Os Vingadores", Genero = "Ação/Sci-Fi", Ano = 2012, Disponivel = true, Diretor = "Joss Whedon" },
                    new Filmes { Id = 6, Titulo = "O Diario de uma paixão", Genero = "Drama", Ano = 2004, Diretor = "Nick Cassavetes", Disponivel = true },
                    new Filmes { Id = 7, Titulo = "Crepúsculo", Genero = "Drama", Ano = 2008, Diretor = "Catherine Harwicke", Disponivel = true },
                    new Filmes { Id = 8, Titulo = "Lua Nova", Genero = "Drama", Ano = 2009, Diretor = "Chris Weitz", Disponivel = true },
                    new Filmes { Id = 9, Titulo = "Eclipse", Genero = "Drama", Ano = 2010, Diretor = "David Slade", Disponivel = true },
                    new Filmes { Id = 10,Titulo = "Amanhecer parte I", Genero = "Drama", Ano = 2011, Diretor = "Bill Condon", Disponivel = true },
                    new Filmes { Id = 11,Titulo = "Amanhecer parte II", Genero = "Drama", Ano = 2012, Diretor = "Bill Condon", Disponivel = true },
                    new Filmes { Id = 12,Titulo = "O Lar das crianças Peculiares", Genero = "Ficção Científica", Ano = 2016, Diretor = "Tim Burton", Disponivel = true },
                    new Filmes { Id = 13,Titulo = "Donzela", Genero = "Ação", Ano = 2024, Diretor = "Juan Carlos Fresnadillo", Disponivel = true },
                    new Filmes { Id = 14,Titulo = "Como treinar o seu dragão 1", Genero = "Filmes para a família", Ano = 2010, Diretor = "Dean DeBlois", Disponivel = true },
                    new Filmes { Id = 15, Titulo = "Como treinar o seu dragão 2", Genero = "Filmes para a família", Ano = 2014, Diretor = "Dean DeBlois", Disponivel = true },
                    new Filmes { Id = 16, Titulo = "Como treinar o seu dragão 3", Genero = "Filmes para a família", Ano = 2019, Diretor = "Dean DeBlois", Disponivel = true },
                    new Filmes { Id = 17, Titulo = "Ela é demais", Genero = "Comédia Romântica", Ano = 1999, Diretor = "Robert Iscove", Disponivel = true },
                    new Filmes { Id = 18, Titulo = "A barraca do beijo", Genero = "Comédia Romântica", Ano = 2018, Diretor = "Vince Marcello", Disponivel = true },
                    new Filmes { Id = 19, Titulo = "Para todos os garotos que já amei", Genero = "Comédia Romântica", Ano = 2018, Diretor = "Susan Johnson", Disponivel = true },
                    new Filmes { Id = 20, Titulo = "Com carinho, Kitty", Genero = "Drama", Ano = 2025, Diretor = "Jenny Han", Disponivel = true },
            };
        }

        // Lê e desserializa a lista de filmes do arquivo JSON.
        public static List<Filmes> LerLista()
        {
            try
            {
                if (!File.Exists(Arquivo))
                {
                    var padrao = ListaPadrao();
                    SalvarLista(padrao);
                    return padrao;
                }

                string jsonLido = File.ReadAllText(Arquivo);
                var lista = JsonSerializer.Deserialize<List<Filmes>>(jsonLido);
                if (lista == null || !lista.Any())
                {
                    // Se preferir não sobrescrever um arquivo existente vazio, comente as duas linhas abaixo.
                    var padrao = ListaPadrao();
                    SalvarLista(padrao);
                    return padrao;
                }

                return lista ?? new List<Filmes>();
            }
            catch
            {
                // Em caso de erro na leitura/desserialização, retornar lista vazia.
                return new List<Filmes>();
            }
        }

        // Serializa e salva a lista de filmes no arquivo JSON.
        private static void SalvarLista(List<Filmes> lista)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string jsonString = JsonSerializer.Serialize(lista, options);
            File.WriteAllText(Arquivo, jsonString);
        }

        // Adiciona um filme à lista persistida (atribui Id automaticamente se necessário).
        public static void AdicionarFilme(Filmes filme)
        {
            if (filme == null)
                throw new ArgumentNullException(nameof(filme));

            var lista = LerLista();

            int proximoId = (lista.Any()) ? lista.Max(f => f.Id) + 1 : 1;
            if (filme.Id == 0)
                filme.Id = proximoId;

            lista.Add(filme);
            SalvarLista(lista);
        }

        // Retorna todos os filmes cadastrados.
        public static List<Filmes> ObterFilmes() => LerLista();

        public static bool ExcluirFilme(int id)
        {
            if (id <= 0)
                return false;

            try
            {
                var lista = LerLista();
                var filme = lista.FirstOrDefault(f => f.Id == id);
                if (filme == null)
                    return false;
                
                lista.Remove(filme);
                SalvarLista(lista);
                return true;
            }
            catch
            {
               return false;
            }
        }

    }
}
