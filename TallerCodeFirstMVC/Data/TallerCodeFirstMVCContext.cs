using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerCodeFirstMVC.Models;

namespace TallerCodeFirstMVC.Data
{
    public class TallerCodeFirstMVCContext : DbContext
    {
        public TallerCodeFirstMVCContext (DbContextOptions<TallerCodeFirstMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TallerCodeFirstMVC.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<TallerCodeFirstMVC.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<TallerCodeFirstMVC.Models.Jugador> Jugador { get; set; } = default!;
    }
}
