//namespace Gym.Models
//{
//    public class Activo
//    {
//    }
//}

namespace Gym.Models;
public class Activo
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = "";

    public int Estado { get; set; }

    public string Marca { get; set; } = "";

    public string NumSerie { get; set; } = "";

    public int Cantidad { get; set; }

    public string Nota1 { get; set; } = "";

    public string Nota2 { get; set; } = "";

    public int SedeId { get; set; }

    public Sede? Sede { get; set; }
}
