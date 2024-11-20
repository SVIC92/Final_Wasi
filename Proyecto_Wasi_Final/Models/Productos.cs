using System.ComponentModel.DataAnnotations;

namespace Proyecto_Wasi_Final.Models
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public string Categoria { get; set; }

        public string ImagenURL { get; set; }

        public string Disponible { get; set; }
    }
}
