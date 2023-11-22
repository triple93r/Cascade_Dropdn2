using Cascd_Dpdwn.Data;
using Cascd_Dpdwn.Models;

namespace Cascd_Dpdwn.VMs
{
    public class AllTbl
    {
     
        public List<tbl_Territory> Territory { get; set; } = new List<tbl_Territory>();
        public List<tbl_Country> tbl_Country { get; set; } = new List<tbl_Country>();

    }
}
