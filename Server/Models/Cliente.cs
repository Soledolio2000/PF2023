using System;
using System.ComponentModel.DataAnnotations;

namespace PF2023.Server.Models
{
    public class Cliente
    {
        [Key]
        int Id {get;set;}
        string Nombre_Cliente {get;set;} = null!;
        string Cedula_Cliente {get;set;} = null!;
        string Telefono_Cliente {get;set;} = null!;
        string LicenciaConducir {get;set;} = null!;
        string Direccion_Cliente {get;set;} = null!;
        
    }
}