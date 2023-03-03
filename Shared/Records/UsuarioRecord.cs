namespace CrudBlazor.Shared.Records;

public class UsuarioRecord
{
    public UsuarioRecord()
    {
        
    }
    public UsuarioRecord(int id, UsuarioRolRecord usuarioRol, string name, string nickName, string password)
    {
        this.id = id;
        UsuarioRol = usuarioRol;
        Name = name;
        NickName = nickName;
        Password = password;
    }

    public int id {get; set;}
    public virtual UsuarioRolRecord UsuarioRol {get; set;} = null!;
    public string Name { get; set; } =null!;
    public string NickName { get; set; } =null!;
    public string Password { get; set; } =null!;
}