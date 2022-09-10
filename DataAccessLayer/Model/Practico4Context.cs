using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Practico4Context : DbContext
    {
        public Practico4Context() { }
        public Practico4Context(DbContextOptions<Practico4Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost,14330;Database=Practico3; User Id = sa; Password = Tisj*2022;");
            }
        }
        public DbSet<Personas> Personas { get; set; }

        public DbSet<Direcciones> Direcciones { get; set; }
        public DbSet<TipoContactos> TipoContactos { get; set; }

    }
}
