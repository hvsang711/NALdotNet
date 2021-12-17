using Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string UserType { get; set; }

        //public List<SelectListItem> UserTypes { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem{Value = UserType.NormalUser.ToString(), Text = UserType.NormalUser.ToString()},
        //    new SelectListItem{Value = UserType.VipUser.ToString(), Text = UserType.VipUser.ToString()},
        //    new SelectListItem{Value = UserType.Admin.ToString(), Text = UserType.Admin.ToString()}
        //};
    }
}
