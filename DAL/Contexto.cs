using Adrian_P1_AP2.Models;
using Microsoft.EntityFrameworkCore;

namespace Adrian_P1_AP2.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<TipoCliente> TipoClientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source= Registro.db");
        }

        
    }
}