using AgriTechPlus.Infra.Funcoes;
using AgriTechPlus.Models.Validations;

namespace AgriTechPlus.Models;


//Abstract indica que essa classe nao pode ser instanciada diretamente, somente pode ser herdada por outras classes
public abstract class Entity
{
    //Gera um novo Guid global para cada instancia da classe.
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }

    //Para auditoria
    public string LoginUsuario { get; set; } = "";
    public string NomeUsuario { get; set; } = "";
    //Recomendado utilizar no banco o horario em UTC, e converter para local somente ao mostrar para o usuario
    public DateTime TempoAtual { get; set; } = DateTime.UtcNow;
    public string IpUsuario { get; set; } = "";
    public string GatewayUsuario { get; set; } = "";
    public string IpExterno { get; set; } = "";
    public string IpExternoReverso { get; set; } = "";

    //Construtor
    public Entity(Guid id, string loginUsuario, string nomeUsuario, DateTime tempoAtual)
    {
        Id = id;
        LoginUsuario = loginUsuario;
        NomeUsuario = nomeUsuario;
        TempoAtual = tempoAtual;

        EntityValidator validar = new();
        //O uso do _ deixa claro que o valor da solicitacao abaixo nao sera usada em nenhum outro bloco
        _ = validar.ValidarEntity(id, loginUsuario, nomeUsuario);
    }
}
