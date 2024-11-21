using System.ComponentModel.DataAnnotations;

namespace EF_DAS_GRUPO1.Models
{
    public class MetodoPago
    {
        [Key]
        public int IdMetodoPago { get; set; }

        public string TipoPago { get; set; }

        public string Detalles { get; set; }
    }
}
