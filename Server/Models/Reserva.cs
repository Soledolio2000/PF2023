using System;
using System.ComponentModel.DataAnnotations;

namespace PF2023.Server.Models
{
    public class Reserva
    {
        [Key]
        int Id {get;set;}
        public int IdCliente {get;set;}
        public int IdVehiculo {get;set;}
       public DateTime FechaInicial {get;set;}
       public DateTime FechaFin {get;set;}
       public double TotalAPagar {get;set;} = null!;

    
    }
}