using Microsoft.EntityFrameworkCore;

namespace vega.Persistence
{
    public class VegaDBContext : DbContext 
    {
        
        public VegaDBContext(DbContextOptions<VegaDBContext> options) : base(options)
        {
            
        }       


    }
}