using System;

public class Carro:Veiculo
{
    public int NumeroPortas { get; set; }

    public void AbrirPortas()
    {
        Console.WriteLine("Abrindo portas do carro");
    }

    public override void Acelerar()
    {
        velocidade += 15; // Carros aceleram mais rápido
        Console.WriteLine($"Carro acelerando suavemente: {velocidade} km/h");
    }
}
