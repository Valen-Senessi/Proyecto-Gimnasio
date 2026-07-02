//namespace Gym.Models
//{
//    public class Usuario
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; } = "";

        public int DNI { get; set; }

        public string? Sexo { get; set; }

        public string? Observaciones { get; set; }

        public string? Nota1 { get; set; }

        public string? Nota2 { get; set; }

        public int PerfilId { get; set; }

        [ForeignKey(nameof(PerfilId))]
        public Perfil? Perfil { get; set; }
    }
}