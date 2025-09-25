namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animais gato = new Animais ("Mimi", "Felino", 3);
            Animais cachorro = new Animais ("Rex", "Canino", 5);
            Animais passaro = new Animais ("Piu", "Ave", 1);

            gato.ApresentarSe(gato);
            gato.Dormir(false);
            gato.Acordar(true);
            gato.FazerSom();
            

            cachorro.ApresentarSe(cachorro);
            cachorro.Dormir(false);
            cachorro.Acordar(true);
            cachorro.FazerSom();
            

            passaro.ApresentarSe(passaro);
            passaro.Dormir(false);
            passaro.Acordar(true);
            passaro.FazerSom();
            
        }
    }
}
