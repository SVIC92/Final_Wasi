using System.ComponentModel.DataAnnotations;

namespace Proyecto_Wasi_Final.Models
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
