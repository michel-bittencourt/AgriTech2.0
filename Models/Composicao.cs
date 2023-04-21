namespace AgriTechPlus.Models;

public class Composicao : Entity
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string? ObservacaoGeral { get; set; }

    public Composicao() { }
}
