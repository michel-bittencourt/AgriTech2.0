using AgriTechPlus.Infra.Data;
using AgriTechPlus.Infra.Funcoes;
using AgriTechPlus.Models;

namespace AgriTechPlus.Controllers.Composicao;

public class ComposicaoPost
{
    public static string Template => "/composicao";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(ComposicaoRequest composicaoRequest, ApplicationDbContext context)
    {
        GetIP getIpUsuario = new GetIP();
        GetGateway getGatewayUsuario = new GetGateway();
        GetIpExterno getIpExterno = new GetIpExterno();

        var composicao = new ComposicaoModel
        {
            Nome = composicaoRequest.Nome,
            Descricao = composicaoRequest.Descricao,
            ObservacaoGeral = composicaoRequest.ObservacaoGeral,
            LoginUsuario = composicaoRequest.loginUsuario,
            NomeUsuario = composicaoRequest.nomeUsuario,
            IpUsuario = getIpUsuario.Ipv4Local(),
            GatewayUsuario = getGatewayUsuario.Gateway(),
            IpExterno = getIpExterno.IpExterno(),
            IpExternoReverso = getIpExterno.IpExternoReverso()

        };
        context.Add(composicao);
        await context.SaveChangesAsync();

        return Results.Created($"/composicao/{composicao.Id}", composicao.Id);
    }
}
