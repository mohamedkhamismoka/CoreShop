using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.BL.VM
{
    public class BranchVM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Branc_Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(3, ErrorMessage = "Min length is 3")]
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number required")]
        [RegularExpression("01[0-2][0-9]{8}", ErrorMessage = "Enter valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Manageris Required")]
        [MinLength(3, ErrorMessage = "Min length is 3")]
        public string manager { get; set; }

    }
}
