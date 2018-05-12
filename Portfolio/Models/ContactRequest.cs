using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class ContactRequest
    {
        [Display(Name = "Name: ", Description = "Your name.")]
        public string Name { get; set; }
        [Display(Name = "Phone Number: ", Description = "Phone number to be reached at.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email: ", Description = "Email number to be reached at.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Comment/Question ", Description = "What would you like to say?")]
        public string CommentQuestion { get; set; }
    }
}