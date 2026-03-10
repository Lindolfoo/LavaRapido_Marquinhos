namespace LavaRapido.Domain.Entities;

public class Agendamento
{
    public int Id { get; private set; }

    public int ClienteId { get; private set; }

    public int VeiculoId { get; private set; }

    public int ServicoId { get; private set; }

    public DateTime DataAgendamento { get; private set; }

    public int Status { get; private set; }

    public DateTime DataCriacao { get; private set; }

    public Agendamento(int clienteId, int veiculoId, int servicoId, DateTime data)
    {
        ClienteId = clienteId;
        VeiculoId = veiculoId;
        ServicoId = servicoId;
        DataAgendamento = data;
        Status = 1;
        DataCriacao = DateTime.UtcNow;
    }
}