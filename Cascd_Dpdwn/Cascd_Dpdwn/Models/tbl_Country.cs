using System.ComponentModel.DataAnnotations;

namespace Cascd_Dpdwn.Models
{
    public class tbl_Country
    {
        [Key]
        public int Cnt_id { get; set; }
        public string Name { get; set; }    
        public int Ter_id { get; set; }
    }
}
