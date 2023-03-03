using System.ComponentModel.DataAnnotations;

namespace PF2023.Shared.Requests;

// en el create no se necesita el ID
public class UsuarioRolCreateRequest
{
[   Required (ErrorMessage = "Se debe de proporcionar el nombre del rol"), 
    MinLength(5, ErrorMessage ="El nombre debe superar los 5 caracteres."),
    MaxLength(100, ErrorMessage ="El nombre no debe suerar los 5 caracteres.")
]
    public string Nombre {get; set;} = null!;
    public bool PermisoParaCrear {get; set;}
    public bool PermisoParaEditar {get; set;}
    public bool PermisoParaEliminar {get; set;}
}
