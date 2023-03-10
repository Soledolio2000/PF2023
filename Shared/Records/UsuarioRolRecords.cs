namespace PF2023.Shared.Records;

public class UsuarioRolRecord
{
    public UsuarioRolRecord()
    {

    }
    public UsuarioRolRecord(int id, string nombre, bool permisoParaCrear, bool permisoParaEditar, bool permisoParaEliminar)
    {
        this.id = id;
        this.Nombre = nombre;
        this.PermisoParaCrear = permisoParaCrear;
        this.PermisoParaEditar = permisoParaEditar;
        this.PermisoParaEliminar = permisoParaEliminar;
    }

    public int id {get; set;}
    public string Nombre {get; set;} = null!;
    public bool PermisoParaCrear {get; set;}
    public bool PermisoParaEditar {get; set;}
    public bool PermisoParaEliminar {get; set;}
}
