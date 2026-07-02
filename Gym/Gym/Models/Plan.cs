//namespace Gym.Models
//{
//    public class Plan
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Precio { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; } = string.Empty;

        [Required]
        public int SedeId { get; set; }

        [ForeignKey(nameof(SedeId))]
        public Sede? Sede { get; set; }

        [Required]
        [StringLength(50)]
        public string Nota1 { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Nota2 { get; set; } = string.Empty;

        public ICollection<RelacionPlanUsuario> RelacionPlanUsuarios { get; set; } = new List<RelacionPlanUsuario>();
    }
}
