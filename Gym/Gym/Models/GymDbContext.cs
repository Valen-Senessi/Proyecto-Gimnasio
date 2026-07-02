//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Numerics;

//namespace Gym.Models
//{
//    public class GymDbContext
//    {
//    }
//}

using Gym.Models;
using Microsoft.EntityFrameworkCore;

namespace Gym.Models    //GestionGimnasio.Data
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Perfil> Perfiles { get; set; }

        public DbSet<Sede> Sedes { get; set; }

        public DbSet<Activo> Activos { get; set; }

        public DbSet<Plan> Planes { get; set; }

        public DbSet<RelacionPlanUsuario> RelacionPlanUsuarios { get; set; }

        public DbSet<Sueldo> Sueldos { get; set; }
    }
}
