using System;

public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        protected int velocidade = 0;

        public virtual void Acelerar()
        {
            velocidade += 10;
            Console.WriteLine($"Acelerando. Velocidade: {velocidade} km/h");
        }

        public virtual void Frear()
        {
            velocidade = Math.Max(0, velocidade - 10);
            Console.WriteLine($"Freando. Velocidade: {velocidade} km/h");
        }
    }

}
}
