using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogetherApp.Models
{
    public class ResponseModel
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please, Let Us Know Your Attendance")]
        public bool? WillAttend { get; set; }
    }
}
