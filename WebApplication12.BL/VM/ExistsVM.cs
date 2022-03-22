using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.VM
{
    public class ExistsVM
    {
        public int prod_Id { get; set; }
        public int bran_Id { get; set; }
        [Range(1, 1000)]

        public int quantity { get; set; }
        [ForeignKey("bran_Id")]
        [Required(ErrorMessage = "branch required")]


        public Branch branch { get; set; }
        [ForeignKey("pro_Id ")]
        [Required(ErrorMessage = "product required")]
        public Product product { get; set; }
    }
}
