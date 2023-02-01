using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.VM
{
    public class OrderVM
    {
 
        public int orderr_num { get; set; }
        public int customer_id { get; set; }
        [Required(ErrorMessage = "Total Price is required")]
        [Range(1, 1000)]
        public int totalPrice { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required")]

        public DateTime date { get; set; }
     
        public Customer customer { get; set; }
        public IEnumerable<Product_order> pro_ord { get; set; }


    }
}
