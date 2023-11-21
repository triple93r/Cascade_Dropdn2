using Microsoft.EntityFrameworkCore;

namespace Cascd_Dpdwn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<tblBananaStock> TblBananaStock { get; set; }
    }
}
