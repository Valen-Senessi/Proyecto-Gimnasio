//namespace Gym.Models
//{
//    public class RelacionPlanUsuario
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Models
{
    public class RelacionPlanUsuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        public double Precio { get; set; }

        [Required]
        public int SedeId { get; set; }

        [ForeignKey(nameof(SedeId))]
        public Sede? Sede { get; set; }

        [Required]
        [StringLength(50)]
        public string PlanesId { get; set; } = string.Empty;
    }
}
