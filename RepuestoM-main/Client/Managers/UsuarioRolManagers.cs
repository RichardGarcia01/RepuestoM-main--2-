using RepuestoM.Shared.Wrapper;
using RepuestoM.Shared.Records;
using RepuestoM.Shared.Router;
using RepuestoM.Client.Extensions;
using RepuestoM.Shared.Request;
using System.Net.Http.Json;

namespace RepuestoM.Client.Managers;



public interface IUsuarioRolManager
{
    Task<Result<int>> CreateAsync(UsuarioRolCreateRequest request);
    Task<ResultList<UsuarioRollRecords>> GetAsync();
    Task<Result<UsuarioRollRecords>> GetByIdAsync(int Id);
}

public class UsuarioRolManager : IUsuarioRolManager
{
    private readonly HttpClient httpClient;

    public UsuarioRolManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<ResultList<UsuarioRollRecords>> GetAsync()
    {
        try
        {
            var response = await httpClient.GetAsync(UsuarioRolRouteManager.BASE);
            var resultado = await response.ToResultList<UsuarioRollRecords>();
            return resultado;
        }
        catch (Exception e)
        {
            return ResultList<UsuarioRollRecords>.Fail(e.Message);
        }
    }
    public async Task<Result<int>> CreateAsync(UsuarioRolCreateRequest request)
    {
        var response = await httpClient.PostAsJsonAsync(UsuarioRolRouteManager.BASE, request);
        return await response.ToResult<int>();
    }
    public async Task<Result<UsuarioRollRecords>> GetByIdAsync(int Id)
    {
        var response = await httpClient.GetAsync(UsuarioRolRouteManager.BuildRouter(Id));
        return await response.ToResult<UsuarioRollRecords>();
    }
}