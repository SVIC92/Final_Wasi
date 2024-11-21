using System.ComponentModel.DataAnnotations;

namespace EF_DAS_GRUPO1.Models
{
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }

        public int IdProducto { get; set; }

        public int CantidadStock { get; set; }

    }
}
