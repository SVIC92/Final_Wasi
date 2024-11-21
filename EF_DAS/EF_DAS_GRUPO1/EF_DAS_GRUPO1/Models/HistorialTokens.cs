using System.ComponentModel.DataAnnotations;

namespace EF_DAS_GRUPO1.Models
{
    public class HistorialTokens
    {
        [Key]
        public int IdHistorialToken { get; set; }

        public int IdUsuario { get; set; }

        public string FechaCreacion { get; set; }

        public int FechaExpiracion { get; set; }

        public int RefreshToken { get; set; }

        public int Token { get; set; }
    }
}
