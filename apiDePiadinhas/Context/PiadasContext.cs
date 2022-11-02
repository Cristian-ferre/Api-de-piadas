using Microsoft.EntityFrameworkCore;
using apiDePiadinhas.Entities;

namespace apiDePiadinhas.Context
{
    public class PiadasContext : DbContext
    {
        public PiadasContext(DbContextOptions<PiadasContext> options) : base(options)
        {

        }

        public DbSet<Piadas> Piadas {get; set;}
    }
}