using Flunt.Notifications;
using Flunt.Validations; //Biblioteca Flunt torna o codigo mais limpo, organizado e facil de manter

namespace AgriTechPlus.Models.Validations;

public class EntityValidator : Notifiable<Notification> //Usando Flunt
{
    public Contract<EntityModel> ValidarEntity(Guid id, string loginUsuario, string nomeUsuario, DateTime tempoAtual, string ipUsuario, string gatewayUsuario)
    {
        var contrato = new Contract<EntityModel>();

        contrato.IsNotNullOrEmpty(id.ToString(), "Id não pode ser nulo ou vazio.")
        .IsNotNullOrEmpty(loginUsuario, "Login do usuário não pode ser nulo ou vazio.")
        .IsGreaterOrEqualsThan(loginUsuario, 5, "Login do usuário não pode ter menos que 5 caracteres")
        .IsLowerOrEqualsThan(loginUsuario, 20, "Login do usuário não pode ter mais que 20 caracteres")

        .IsNotNullOrEmpty(nomeUsuario, "Nome do usuário não pode ser nulo ou vazio.")
        .IsGreaterOrEqualsThan(nomeUsuario, 3, "Nome do usuário não pode ter menos que 3 caracteres")
        .IsLowerOrEqualsThan(nomeUsuario, 50, "Nome do usuário não pode ter mais que 50 caracteres")

        .IsNotNullOrEmpty(tempoAtual.ToString(), "Dia e hora atual não podem ser nulos ou vazios.")

        .IsNotNullOrEmpty(ipUsuario, "IP do usuário não pode ser nulo ou vazio.")
        .IsGreaterOrEqualsThan(ipUsuario, 16, "IP do usuário não pode ter menos que 3 caracteres")
        .IsLowerOrEqualsThan(ipUsuario, 16, "IP do usuário não pode ter mais que 50 caracteres")

        .IsNotNullOrEmpty(gatewayUsuario, "Gateway do usuário não pode ser nulo ou vazio.")
        .IsGreaterOrEqualsThan(gatewayUsuario, 16, "Gateway do usuário não pode ter menos que 3 caracteres")
        .IsLowerOrEqualsThan(gatewayUsuario, 16, "Gateway do usuário não pode ter mais que 50 caracteres");

        return contrato;
    }
}
