using Flunt.Notifications;
using Flunt.Validations; //Biblioteca Flunt torna o codigo mais limpo, organizado e facil de manter

namespace AgriTechPlus.Models.Validations;

public class EntityValidator : Notifiable<Notification> //Usando Flunt
{
    public Contract<Entity> ValidarEntity(Guid id, string loginUsuario, string nomeUsuario)
    {
        var contrato = new Contract<Entity>();

        contrato.IsNotNullOrEmpty(id.ToString(), "Id não pode ser nulo ou vazio.");

        contrato.IsNotNullOrEmpty(loginUsuario, "Login do usuário não pode ser nulo ou vazio.")
        .IsGreaterOrEqualsThan(loginUsuario, 5, "Login do usuário não pode ter menos que 5 caracteres")
        .IsLowerOrEqualsThan(loginUsuario, 20, "Login do usuário não pode ter mais que 20 caracteres");

        contrato.IsNotNullOrEmpty(nomeUsuario, "Nome do usuário não pode ser nulo ou vazio.")
        .IsGreaterOrEqualsThan(nomeUsuario, 3, "Nome do usuário não pode ter menos que 3 caracteres")
        .IsLowerOrEqualsThan(nomeUsuario, 50, "Nome do usuário não pode ter mais que 50 caracteres");

        return contrato;
    }
}
