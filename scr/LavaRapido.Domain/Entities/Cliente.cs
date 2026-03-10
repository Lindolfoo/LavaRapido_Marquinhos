namespace LavaRapido.Domain.Entities;

public class Cliente
{
    public int Id { get; private set; }

    public string Nome { get; private set; }

    public string Telefone { get; private set; }

    public string Email { get; private set; }

    public bool Ativo { get; private set; }

    public DateTime DataCadastro { get; private set; }

    public Cliente(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Ativo = true;
        DataCadastro = DateTime.UtcNow;
    }
}