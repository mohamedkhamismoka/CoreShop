using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.DAL.Entity
{
    public class Product
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        [Column(TypeName ="Date")]
        public DateTime expire_date { get; set; }
        [Column(TypeName = "Date")]
        public DateTime production_date { get; set; }

        public int quantity { get; set; }
        public string barcode { get; set; }


        public IEnumerable<Product_order> pro_ord { get; set; }

    }
}
