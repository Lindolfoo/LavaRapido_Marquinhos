namespace LavaRapido.Domain.Entities;

public class Veiculo
{
    public int Id { get; private set; }

    public int ClienteId { get; private set; }

    public string Modelo { get; private set; }

    public string Placa { get; private set; }

    public string Cor { get; private set; }

    public DateTime DataCadastro { get; private set; }

    public Veiculo(int clienteId, string modelo, string placa, string cor)
    {
        ClienteId = clienteId;
        Modelo = modelo;
        Placa = placa;
        Cor = cor;
        DataCadastro = DateTime.UtcNow;
    }
}