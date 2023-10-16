using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.DAL.Entity
{
    public class Customer
    {
      
     
        public int id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public string phone { get; set; }
        [StringLength(20)]
        public string mail { get; set; }

        public string address { get; set; }
        public IEnumerable<order> orders { get; set; }
    }
}
