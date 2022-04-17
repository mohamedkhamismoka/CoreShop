using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.VM
{
    public class CustomerVM
    {
       
        public int Custo_Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(3, ErrorMessage = "Min length is 3")]
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number required")]
        [RegularExpression("01[0-2][0-9]{8}", ErrorMessage = "Enter valid phone number")]
        public string phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Mail is required")]
        public string mail { get; set; }


        [Required(ErrorMessage = "Address required")]
        [RegularExpression("[0-9]{2,5}-[a-zA-Z]{1,50}-[a-zA-Z]{1,50}-[a-zA-Z]{1,50}", ErrorMessage = "address must like 12-Street name-cityname-countryname")]
        public string address { get; set; }
        public IEnumerable<order> orders { get; set; }
    }
}
