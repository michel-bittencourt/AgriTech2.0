namespace AgriTechPlus.Models;

public class ComponentesModel : Entity
{
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public ICollection<ComposicaoModel>? Composicoes { get; set; } = new List<ComposicaoModel>();
    public string? Descricao { get; set; }
    public string? ObservacaoGeral { get; set; }
}
