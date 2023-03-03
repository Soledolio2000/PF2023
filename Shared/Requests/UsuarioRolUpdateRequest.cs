using System.ComponentModel.DataAnnotations;

namespace CrudBlazor.Shared.Requests;

//En esta parte hacemos una herencia de Create a Update en los requests
// En el update se necesita el ID para el momento de cualquier cambio pida el ID
// Para el Required se necesita el using System.ComponentModel.DataAnnotations;
public class UsuarioRolUpdateRequest : UsuarioRolCreateRequest
{
    [Required(ErrorMessage ="Se debe proporcionar el Id del rol a modificar.")]
    public int id {get; set;}

}