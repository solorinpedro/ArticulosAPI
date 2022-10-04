using ArticulosAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ArticulosAPI.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Articulos> Articulos { get; set; }
    }
}
