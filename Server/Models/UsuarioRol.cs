namespace PF2023.Server.Models;

public class UsuarioRol
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool PermisoParaCrear { get; set; }
    public bool PermisoParaEditar { get; set; }
    public bool PermisoParaEliminar { get; set; }
    
public virtual ICollection<UsuarioRol>? Usuarios {get; set;}
}