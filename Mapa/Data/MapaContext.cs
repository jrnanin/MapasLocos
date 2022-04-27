#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mapa.Models;

namespace Mapa.Data
{
    public class MapaContext : DbContext
    {
        public MapaContext (DbContextOptions<MapaContext> options)
            : base(options)
        {
        }

        public DbSet<Mapa.Models.Point> Point { get; set; }
    }
}
