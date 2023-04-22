using AgriTechPlus.Models.Validations;

namespace AgriTechPlus.Models;

public class ComposicaoModel : EntityModel
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string? ObservacaoGeral { get; set; }

    public ComposicaoModel() { }
    public ComposicaoModel(string nome, string descricao, string observacaoGeral)
    {
        Nome = nome;
        Descricao = descricao;
        ObservacaoGeral = observacaoGeral;

        ComposicaoValidator validar = new();
        validar.ValidarComposicao(nome, descricao, observacaoGeral);
    }
}
