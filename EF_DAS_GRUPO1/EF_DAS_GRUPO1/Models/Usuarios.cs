using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace EF_DAS_GRUPO1.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Contraseña { get; set; }

        public string fechaRegistro { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        [Range(18, 99, ErrorMessage = "La edad debe ser mayor a 17 años")]
        public int Edad { get; set; }

        public string Direccion { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [Range(900000000, 999999999, ErrorMessage = "El telefono debe tener 9 digitos y comenzar con 9")]
        public int Telefono { get; set; }

        public string TipoUsuario { get; set; }

        public string Token { get; set; }

    }
}
