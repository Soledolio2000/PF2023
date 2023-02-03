using System.ComponentModel.DataAnnotations;
namespace PF2023.Server.Models;

public class Usuario
{
    [Key]
    public int Id { get; set; }
    public int UsuarioRolId { get; set; } 
    public UsuarioRol? UsuarioRol {get; set;} 
    public string Name {get; set;} = null!;
    public string NikeName {get; set;} = null!;
    public string Password {get; set;} = null!;

    public static Usuario Crear (UsuarioRequest request)
    {
      return new Usuario()
      {
            UsuarioRolId = request.UsuarioRolId,
            Name = request.Name,
            NikeName = request.nikeName,
            Password = request.Password

      };  
    }
    public static Usuario Editar (UsuarioRequest request)
    {
      return new Usuario()
      {
            UsuarioRolId = request.UsuarioRolId,
            Name = request.Name,
            NikeName = request.nikeName,
            Password = request.Password

      };  
    }
}