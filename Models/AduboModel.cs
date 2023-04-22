namespace AgriTechPlus.Models;

public class AduboModel : EntityModel
{
    public string Nome { get; set; }
    public ICollection<ComponentesModel>? Componentes { get; set; } = new List<ComponentesModel>();
    public string? DescricaoMontagem { get; set; }
    public int? QuandoUsar { get; set; } //Quantidade de dias aproximados para decompor e poder usar
    public DateTime? Data { get; set; } //Data aproximada para adubo ficar pronto para uso
    public string? ObservacaoGeral { get; set; }
}
