using System;
using System.ComponentModel.DataAnnotations;

namespace PF2023.Server.Models
{
    public class Reserva
    {
        [Key]
        int Id {get;set;}
        Vehiculo Vehiculo = null!;
        DateTime FechaInicio;
        DateTime FechaFin;
        string Nombre_Cliente {get;set;} = null!;
    
    }
}