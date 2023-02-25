using System.ComponentModel.DataAnnotations;
using System.Dynamic;
namespace CrudBlazor.Server.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id {get;set;}
        public string Marca {get; set;} = null!;
        public string Modelo {get; set;} = null!;
        public string Tipo  {get; set;} = null!;
        public int Anio {get; set;}
        public int precio {get;set;}
    }
}