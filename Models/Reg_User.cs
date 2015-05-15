//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace Final_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reg_User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]

        public string Username { get; set; }
        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]

        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Confirm Password Does Not Match")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Conpassword { get; set; }
        public string Uimage { get; set; }
    }
}
