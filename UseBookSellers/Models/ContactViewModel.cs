using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UseBookSellers.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "First Name(s)")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Required]
        [StringLength(800)]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}