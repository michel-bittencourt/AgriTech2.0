using Flunt.Notifications;
using Flunt.Validations; //Biblioteca Flunt torna o codigo mais limpo, organizado e facil de manter

namespace AgriTechPlus.Models.Validations;

public class EntityValidator : Notifiable<Notification> //Usando Flunt
{
    public Contract<Entity> ValidarEntity(Guid id, string loginUsuario, string nomeUsuario, DateTime tempoAtual, string ipUsuario)
    {
        var contrato = new Contract<Entity>();

        contrato.IsNotNullOrEmpty(id.ToString(), "Id não pode ser nulo ou vazio.");
        contrato.IsNotNullOrEmpty(loginUsuario.ToString(), "Login do usuário não pode ser nulo ou vazio.");
        contrato.IsNotNullOrEmpty(nomeUsuario.ToString(), "Nome do usuário não pode ser nulo ou vazio.");
        contrato.IsNotNullOrEmpty(tempoAtual.ToString(), "Dia e hora atual não podem ser nulos ou vazios.");
        contrato.IsNotNullOrEmpty(ipUsuario.ToString(), "IP do usuário não pode ser nulo ou vazio.");

        return contrato;
    }
}
