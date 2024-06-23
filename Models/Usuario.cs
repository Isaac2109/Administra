using System.ComponentModel.DataAnnotations;

namespace Administra.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
