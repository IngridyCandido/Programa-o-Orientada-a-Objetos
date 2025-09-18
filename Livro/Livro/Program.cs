namespace Livro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("Jogo dos tronos", "Joao", 345);
            Livro livro2 = new Livro("Orgulho e Preconceito", "Jane Austin", 234);
            Livro livro3 = new Livro("A culpa é das estralas", "John", 321);

            Console.WriteLine("Os livros que temos na nossa biblioteca são: " + livro1.titulo + ", " + livro2.titulo + ", " + livro1.titulo + ".");
        }
    }
}
