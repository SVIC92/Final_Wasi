using System.ComponentModel.DataAnnotations;

namespace Proyecto_Wasi_Final.Models
{
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }

        public int IdProducto { get; set; }

        public int CantidadStock { get; set; }

    }
}
