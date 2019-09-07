using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class GuestReponse
    {
        [Required(ErrorMessage ="Enter your name please")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your Email please")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your Phone please")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter your decide please")]
        public bool? WillAttend { get; set; }
    }
}
