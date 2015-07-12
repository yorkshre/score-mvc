using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SklepMuzyczny.Models
{
    public class user
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be 6 char long.")]
        public string password { get; set; }
        [Compare("Password", ErrorMessage = "Confirm password dose not match.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage="Please provide full name",AllowEmptyStrings=false)]
        public string FullName { get;set;}
        [RegularExpression(@"^([0-9a-zA-Z)]([\+]\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z0-9]{2,3})$",
            ErrorMessage="Please provide valid email ic")]

        public string EmailID {get;set;}
    }
}