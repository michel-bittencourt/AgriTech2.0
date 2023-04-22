using AgriTechPlus.Infra.Data;
using AgriTechPlus.Models;

namespace AgriTechPlus.Controllers.Composicao;

public class ComposicaoPost
{
    public static string Template => "/composicao";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static async Task<IResult> Action(ComposicaoRequest composicaoRequest, ApplicationDbContext context)
    {
        var composicao = new ComposicaoModel
        {
            Nome = composicaoRequest.Nome,
            Descricao = composicaoRequest.Descricao,
            ObservacaoGeral = composicaoRequest.ObservacaoGeral,
        };
        context.Add(composicao);
        await context.SaveChangesAsync();

        return Results.Created($"/composicao/{composicao.Id}", composicao.Id);
    }
}
