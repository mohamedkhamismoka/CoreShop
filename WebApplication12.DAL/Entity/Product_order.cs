using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.DAL.Entity
{
    public class Product_order
    {
        public int pro_id { get; set; }
        public int ord_id { get; set; }
        public int quantity { get; set; }

        [Column(TypeName ="Date")]
        public DateTime date { get; set; }
        [ForeignKey("pro_id")]
        public Product product { get; set; }
        [ForeignKey("ord_id")]
        public order orders { get; set; }
    }
}
