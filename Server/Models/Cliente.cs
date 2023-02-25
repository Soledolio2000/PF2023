using System.ComponentModel.DataAnnotations;

namespace CrudBlazor.Server.Models
{
    public class Cliente
    {
        [Key]
        int id {get;set;}
        string Nombre {get;set;} = null!;
        string Cedula {get;set;} = null!;
        string Pasaporte {get;set;} = null!;
        string LicenciaConducir {get;set;} = null!;
        
    }
}