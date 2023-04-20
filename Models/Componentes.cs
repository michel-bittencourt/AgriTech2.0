namespace AgriTechPlus.Models;

public class Componentes
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public ICollection<Composicao>? Composicoes { get; set; } = new List<Composicao>();
    public string? Descricao { get; set; }
    public string? ObservacaoGeral { get; set; }

    public void AddComposicao(Composicao composicao)
    {
        try
        {
            Composicoes.Add(composicao);
        }
        catch (Exception ex)
        {
            throw new Exception($"Algo deu errado! Error: {ex.Message}");
        }
    }
}
