using System;
using System.ComponentModel.DataAnnotations;

namespace CrudBlazor.Server.Models
{
    public class Reserva
    {
        [Key]
        int id {get;set;}
        Vehiculo vehiculo = null!;
        DateTime FechaInicio;
        DateTime FechaFin;
        string ClienteNombre {get;set;} = null!;
    }
}