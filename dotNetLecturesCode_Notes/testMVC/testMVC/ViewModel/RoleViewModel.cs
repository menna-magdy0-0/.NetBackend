﻿using System.ComponentModel.DataAnnotations;

namespace testMVC.ViewModel
{
    
    public class RoleViewModel
    {
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
