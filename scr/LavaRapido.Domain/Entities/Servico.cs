namespace LavaRapido.Domain.Entities;

public class Servico
{
    public int Id { get; private set; }

    public string Nome { get; private set; }

    public decimal Preco { get; private set; }

    public bool Ativo { get; private set; }

    public Servico(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
        Ativo = true;
    }
}