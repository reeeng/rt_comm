using Microsoft.EntityFrameworkCore;
using RTComm.Data;


namespace RTComm
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<ConstructionCo> ConstructionCo { get; set; }
        public DbSet<Jobs> Jobs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public ApplicationDbContext()
        {
        }
    }
}
