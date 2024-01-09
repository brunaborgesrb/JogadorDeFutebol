using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }
    public static Jogador Novo()
    {
        string nome = Console.ReadLine();

        string nacionalidade = Console.ReadLine();

        int idade = int.Parse(Console.ReadLine());

        string posicao = Console.ReadLine();

        return new Jogador(nome, nacionalidade, idade, posicao);
    }
}

class Program
{
    static void Main()
    {
        // Criar objeto jogador
        Jogador novoJogador = Jogador.Novo();

        // Exibir as informações do jogador
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(novoJogador.Nome);
        Console.WriteLine(novoJogador.Nacionalidade);
        Console.WriteLine(novoJogador.Idade);
        Console.WriteLine("Posição: " + novoJogador.Posicao);
    }
}