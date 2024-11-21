using System.ComponentModel.DataAnnotations;

namespace EF_DAS_GRUPO1.Models
{
    public class DetallePedido
    {
        [Key]
        public int IdDetallePedido { get; set; }

        public int IdPedido { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public double PrecioUnitario { get; set; }
    }
}
