using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.VM
{
    public class ProductVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 1000000, ErrorMessage = "Out of range 1~100000")]
        public int price { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Expire date is required")]
        public DateTime expire_date { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Production date is required")]
        public DateTime production_date { get; set; }
        [Required(ErrorMessage = "Quantity required")]
        public int quantity { get; set; }
        public string barcode { get; set; }
        public IFormFile barcodeImg { get; set; }
        public IEnumerable<Product_order> pro_ord { get; set; }


    }
}
