using Microsoft.EntityFrameworkCore;
using TrasladoSeguro.Models;

namespace TrasladoSeguro.Data
{
    internal class TrasladoSeguroContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<ServicioTransporte> ServicioTransportes { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=TrasladoSeguro;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

    }
}
