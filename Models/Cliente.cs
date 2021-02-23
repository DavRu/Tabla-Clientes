using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CLIENTES.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direcion { get; set; }
        public string Telefono { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de alta")]
        public DateTime FechaAlta { get; set; }
    


}
}
