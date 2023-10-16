using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.DAL.Entity
{
    public class Branch
    {
    
        public int BranchId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public string Phone { get; set; }
        [StringLength(20)]
        public string manager { get; set; }
        





    }
}
