using Cascd_Dpdwn.Data;
using Cascd_Dpdwn.Models;

namespace Cascd_Dpdwn.VMs
{
    public class AllTbl
    {
        private readonly ApplicationDbContext _context;
        public AllTbl(ApplicationDbContext context)
        {
                _context = context;
        }
        public List<tbl_Territory> Territory { get; set; } = new List<tbl_Territory>();
        public tbl_Country tbl_Country { get; set; } = new tbl_Country();

    }
}
