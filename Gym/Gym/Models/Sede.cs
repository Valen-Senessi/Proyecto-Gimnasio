//namespace Gym.Models
//{
//    public class Sede
//    {
//    }
//}

using System;
using System.Numerics;

namespace Gym.Models;
public class Sede
{
    public int Id { get; set; }

    public string Direccion { get; set; } = "";

    public string Descripcion { get; set; } = "";

    public int Jerarquia { get; set; }

    public int Capacidad { get; set; }

    public ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public ICollection<Plan> Planes { get; set; } = new List<Plan>();
}
