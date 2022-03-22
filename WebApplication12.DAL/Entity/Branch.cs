using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.DAL.Entity
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Branc_Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string manager { get; set; }






    }
}
