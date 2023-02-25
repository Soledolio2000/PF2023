using System.ComponentModel.DataAnnotations;

namespace PF2023.Server.Models
{
    public class Cliente
    {
        [Key]
        int Id {get;set;}
        string Nombre {get;set;} = null!;
        string Cedula {get;set;} = null!;
        string Pasaporte {get;set;} = null!;
        string LicenciaConducir {get;set;} = null!;
        
    }
}