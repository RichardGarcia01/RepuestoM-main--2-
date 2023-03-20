using System.Data;
using Ardalis.ApiEndpoints;
using RepuestoM.Server.Context;

using RepuestoM.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using RepuestoM.Shared.Records;
using RepuestoM.Shared.Router;
 
namespace RepuestoM.Server.Endpoints.UsuarioRoles;
using Repuesta = ResultList<UsuarioRollRecords>;
public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<Repuesta>
{
    private readonly IMyDbContext dbContext;
    
    public  Get(IMyDbContext dbContext)
    {
        this .dbContext = dbContext;
    }
    [HttpGet(UsuarioRolRouteManager.BASE)]

    public override async Task<ActionResult<Repuesta>> HandleAsync(CancellationToken cancellationToken = default)
    {   try{ 
         var roles = await dbContext.UsuariosRoles
        .Select(rol=>rol.ToRecord())
        .ToListAsync(cancellationToken);

         return Repuesta.Success(roles);
       }
            catch(Exception ex )
            {
                return Repuesta.Fail(ex.Message);
            }
      }
    }

     

    