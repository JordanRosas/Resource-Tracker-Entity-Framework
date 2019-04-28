using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Attendees.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "* This field is required")]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "* This field is required")]
        [Column(TypeName = "nvarchar(250)")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public int PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Location { get; set; }
    }
}
