namespace PF2023.Server.Models;

public class UsuarioRequest 
{
public int Id {get; set;}
public int UsuarioRolId { get; set; }
public string Name { get; set; } = null!;
public string nikeName { get; set; } = null!;
public string Password { get; set; } = null!;


}