using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDBContext : DbContext 
    {
        
        public VegaDBContext(DbContextOptions<VegaDBContext> options) : base(options)
        {
            
        }       

        public DbSet<Make> Makes { get; set; }

    }
}