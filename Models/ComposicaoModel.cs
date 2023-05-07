using AgriTechPlus.Models.Validations;

namespace AgriTechPlus.Models;

public class ComposicaoModel : Entity
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string? ObservacaoGeral { get; set; }

    public ComposicaoModel() { }
    public ComposicaoModel(Guid id, string loginUsuario, string nomeUsuario, DateTime tempoAtual, string ipUsuario, string gatewayUsuario, string nome, string descricao, string observacaoGeral) : base(id, loginUsuario, nomeUsuario, tempoAtual)
    {
        Nome = nome;
        Descricao = descricao;
        ObservacaoGeral = observacaoGeral;

        ComposicaoValidator validar = new();
        validar.ValidarComposicao(nome, descricao, observacaoGeral);
    }
}
