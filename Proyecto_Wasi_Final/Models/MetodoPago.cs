using System.ComponentModel.DataAnnotations;

namespace Proyecto_Wasi_Final.Models
{
    public class MetodoPago
    {
        [Key]
        public int IdMetodoPago { get; set; }

        public string TipoPago { get; set; }

        public string Detalles { get; set; }
    }
}
