using Ardalis.ApiEndpoints;
using PF2023.Server.Context;
using PF2023.Shared.Records;
using PF2023.Shared.Wrapper;
using PF2023.AspNetCore.Mvc;
using PF2023.EntityFrameworkCore;
using RouteApiBase.Shared.Routes;

namespace PF2023.Server.EndPoints.UsuariosRoles;
using Respuesta = ResultList<UsuarioRolRecord>;

public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public Get(IMyDbContext  dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(UsuarioRolRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(CancellationToken cancellationToken = default)
    {
      try{
         var roles = await dbContext.UsuariosRoles
       .Select(rol=>rol.ToRecord())
       .ToListAsync(cancellationToken);
       
      return Respuesta.Success(roles);
      }

      catch(Exception ex){
        return Respuesta.Fail(ex.Message);
      }
    }
} 