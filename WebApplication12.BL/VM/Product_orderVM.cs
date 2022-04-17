using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.VM
{
    public class Product_orderVM
    {
        public int pro_id { get; set; }
        public int ord_id { get; set; }
     
        public int quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        public Product product { get; set; }
   
        public order orders { get; set; }
    }
}
