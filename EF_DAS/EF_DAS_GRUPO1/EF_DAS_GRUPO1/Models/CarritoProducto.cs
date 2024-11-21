using System.ComponentModel.DataAnnotations;

namespace EF_DAS_GRUPO1.Models
{
    public class CarritoProducto
    {
        [Key]
        public int IdCarritoProducto { get; set; }

        public int IdCarrito { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }
    }
}
