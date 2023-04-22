using Flunt.Validations;

namespace AgriTechPlus.Models.Validations;

public class ComposicaoValidator : EntityValidator
{
    public Contract<ComposicaoModel> ValidarComposicao(string nome, string descricao, string observacaoGeral)
    {
        var contrato = new Contract<ComposicaoModel>();

        contrato.IsNotNullOrEmpty(nome, "Nome não pode ser nulo ou vazio.")

        .IsLowerOrEqualsThan(descricao, 500, "Descrição não pode ter mais que 500 caracteres")

        .IsLowerOrEqualsThan(observacaoGeral, 500, "Observação geral não pode ter mais que 500 caracteres");

        return contrato;
    }
}
