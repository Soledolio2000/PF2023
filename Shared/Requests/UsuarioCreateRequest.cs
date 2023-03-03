using System.ComponentModel.DataAnnotations;

namespace PF2023.Shared.Requests;

public class UsuarioCreateRequest
{
    
    [Range(1,int.MaxValue, ErrorMessage = "EL rol seleccionado no es valido")]
    public int UsuarioRolId {get; set;} 
    [   Required (ErrorMessage = "Se debe de proporcionar el nombre del rol"), 
        MinLength(5, ErrorMessage ="El nombre debe superar los 5 caracteres."),
        MaxLength(100, ErrorMessage ="El nombre no debe suerar los 5 caracteres.")
    ]
    public string Name { get; set; } =null!;
     [   Required (ErrorMessage = "Se debe de proporcionar el nickname del rol"), 
         MinLength(3, ErrorMessage ="El nickname debe superar los 3 caracteres."),
        MaxLength(100, ErrorMessage ="El nickname no debe suerar los 5 caracteres.")
    ]
    public string NickName { get; set; } =null!;
    [   Required (ErrorMessage = "Se debe de proporcionar una contraseña"), 
         MinLength(3, ErrorMessage ="La contaseña debe superar los 3 caracteres."),
        MaxLength(100, ErrorMessage ="La contraseña no debe suerar los 50 caracteres.")
    ]
    public string Password { get; set; } =null!; 

    // Esta Parte es para agregar al proyecto final grupal
}

public class UsuarioUpdateRequest : UsuarioCreateRequest
{
    [Required(ErrorMessage = "Se debe proporcionar el Id del rol a modificar")]
    public int id {get; set;}

}