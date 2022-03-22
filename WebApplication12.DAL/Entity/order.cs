using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.DAL.Entity
{
    public class order
    {

        public int customer_id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderr_num { get; set; }
        public int totalPrice { get; set; }
        public DateTime date { get; set; }

        [ForeignKey("customer_id")]
        public Customer customer { get; set; }
        public IEnumerable<Product_order> pro_ord { get; set; }


    }
}
