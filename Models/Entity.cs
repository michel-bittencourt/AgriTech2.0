namespace AgriTechPlus.Models;

using AgriTechPlus.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;

//Abstract indica que essa classe nao pode ser instanciada diretamente, somente pode ser herdada por outras classes
public abstract class Entity
{
    //Gera um novo Guid global para cada instancia da classe.
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; private set; }

    //Para auditoria
    [Required]
    [StringLength(100)]
    public string LoginUsuario { get; private set; }
    public string NomeUsuario { get; private set; }
    //Recomendado utilizar no banco o horario em UTC, e converter para local somente ao mostrar para o usuario
    public DateTime TempoAtual { get; private set; } = DateTime.UtcNow;
    public string IpUsuario { get; private set; }
    public string GatewayUsuario { get; private set; }

    //Construtor
    public Entity(Guid id, string loginUsuario, string nomeUsuario, DateTime tempoAtual, string ipUsuario, string gatewayUsuario)
    {
        Id = id;
        LoginUsuario = loginUsuario;
        NomeUsuario = nomeUsuario;
        TempoAtual = tempoAtual;
        IpUsuario = ipUsuario;
        GatewayUsuario = gatewayUsuario;

        EntityValidator validar = new();
        //O uso do _ deixa claro que o valor da solicitacao abaixo nao sera usada em nenhum outro bloco
        _ = validar.ValidarEntity(id, loginUsuario, nomeUsuario, tempoAtual, ipUsuario, gatewayUsuario);
    }
}
