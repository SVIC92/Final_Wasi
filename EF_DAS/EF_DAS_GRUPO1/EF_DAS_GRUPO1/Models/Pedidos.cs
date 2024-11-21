using System.ComponentModel.DataAnnotations;

namespace EF_DAS_GRUPO1.Models
{
    public class Pedidos
    {
        [Key]
        public int IdPedido { get; set; }

        public int IdUsuario { get; set; }

        public string fechaPedido { get; set; }

        public double Total { get; set; }

        public string Estado { get; set; }

        public int IdMetodoPago { get; set; }

    }
}
