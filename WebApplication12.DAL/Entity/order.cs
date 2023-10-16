using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.DAL.Entity
{
    public class order
    {

        public int customer_id { get; set; }

        public int orderid { get; set; }
        public int totalPrice { get; set; }
        [Column(TypeName ="Date")]
        public DateTime date { get; set; }

        [ForeignKey("customer_id")]
        public Customer customer { get; set; }
        public IEnumerable<Product_order> pro_ord { get; set; }


    }
}
