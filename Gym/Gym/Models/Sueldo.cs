//namespace Gym.Models
//{
//    public class Sueldo
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{
    public class Sueldo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaPago { get; set; }

        [Required]
        public float Importe { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        public int DNI { get; set; }

        [Required]
        [StringLength(50)]
        public string Sexo { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string CUIL { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Estado { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string CBU { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Alias { get; set; } = string.Empty;
    }
}
