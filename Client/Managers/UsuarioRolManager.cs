using System.Runtime.Intrinsics.X86;
using System;
using PF2023.Shared.Wrapper;
using PF2023.Shared.Records;
using PF2023.Shared.Routes;
using PF2023.Client.Extensions;

namespace PF2023.Client.Managers;

public interface IUsuarioRolManager
{
    Task<ResultList<UsuarioRolRecord>> GetTaskAsync();
}

public class UsuarioRolManager : IUsuarioRolManager
{
    private readonly HttpClient httpClient;

    public UsuarioRolManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<ResultList<UsuarioRolRecord>> GetTaskAsync()
    {
        try
        {
            var response = httpClient.GetAsync(UsuarioRolRouteManager.BASE);
            var resultado = await response.ToResultList<UsuarioRolRecord>();
            return resultado;
        }
        catch (Exception e)
        {
            return ResultList<UsuarioRolRecord>.Fail(e.Message);
        }
    }
}