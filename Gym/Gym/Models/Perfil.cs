//namespace Gym.Models
//{
//    public class Perfil
//    {
//    }
//}

using Gym.Models;

public class Perfil
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}