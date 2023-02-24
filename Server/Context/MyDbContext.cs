using Microsoft.EntityFrameworkCore;
using PF2023.Server.Models;
namespace PF2023.Server.Context;

internal interface IMyDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}


internal class MyDbContext : DbContext, IMyDbContext
{
    //Contructor de la clase
    protected readonly IConfiguration _configuration;
    public MyDbContext(IConfiguration configuration)  
    { 
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(_configuration.GetConnectionString("DBUsuario"));
    }

    #region Tablas de la BD.
    public DbSet<Usuario> Usuarios { set; get; } = null!;
    public DbSet<Usuario> UsuariosRol { set; get; } = null!;
    #endregion
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}