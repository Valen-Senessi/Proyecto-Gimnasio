using System.ComponentModel.DataAnnotations;


namespace Gym.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Ingresá tu DNI")]
		[Display(Name = "DNI")]
		public string DNI { get; set; } = string.Empty; // string para aceptar puntos del input, se limpia en el controller

		[Required(ErrorMessage = "Ingresá tu contraseña")]
		[DataType(DataType.Password)]
		public string UsuPsw { get; set; } = string.Empty;
	}
}