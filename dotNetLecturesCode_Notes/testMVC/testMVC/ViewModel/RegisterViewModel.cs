using System.ComponentModel.DataAnnotations;

namespace testMVC.ViewModel
{
    public class RegisterViewModel
    {

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public string Address { get; set; }
    }
}
