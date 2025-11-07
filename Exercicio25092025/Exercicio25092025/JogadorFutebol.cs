using System;

public class JogadorFutebol
{
	public string nome;
	public int energia;
	public int gols;
	public bool estaJogando;

	public JogadorFutebol(string nome)
	{
		this.nome = nome;
		this.energia = 100;
		this.gols = 0;
		this.estaJogando = false;
	}

	public bool IniciarJogo()
	{
		estaJogando=true;
		Console.WriteLine("O Jogo começou!");
		return estaJogando;
	}

    public bool TerminarJogo()
    {
        estaJogando = false;
        Console.WriteLine("O Jogo acabou!");
        return estaJogando;
    }

	public int Correr()
	{
		if (energia => 0, estaJogando = true){
			(energia - 10) = energia
		}
	}

}
