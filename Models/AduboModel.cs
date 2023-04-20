namespace AgriTechPlus.Models;

public class AduboModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ICollection<Componentes>? Componentes { get; set; } = new List<Componentes>();
    public string? DescricaoMontagem { get; set; }
    public int? QuandoUsar { get; set; } //Quantidade de dias aproximados para decompor e poder usar
    public DateTime? Data { get; set; } //Data aproximada para adubo ficar pronto para uso
    public string? ObservacaoGeral { get; set; }
}
