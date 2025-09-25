using System;

public class Animais
{
	public string nome;
	public string especie;
	public int idade;
	public bool estaDormindo;

	public Animais (string nome, string especie, int idade)
	{
		this.nome = nome;
		this.especie = especie;
		this.idade = idade;
		this.estaDormindo = false;
	}

	public bool Dormir (bool estaDormindo)
	{
		estaDormindo = true;
		Console.WriteLine("O animal está dormindo.");
		return estaDormindo;
	}

	public bool Acordar (bool estaDormindo)
	{
		estaDormindo = false;
		Console.WriteLine("O animal acordou.");
		return estaDormindo;
	}

	public void FazerSom()
	{
		Console.WriteLine("O animal fez um som.");
    }

	public void ApresentarSe(Animais Animal)
	{
		Console.WriteLine("Meu nome é " + Animal.nome + ". Sou da especie " + Animal.especie + " e tenho " + Animal.idade + " anos.");
	}
}
