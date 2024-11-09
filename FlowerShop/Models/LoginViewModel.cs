using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Models;

public class LoginViewModel
{
    [Required (ErrorMessage = "Необходимо ввести почту")]
    public string Email { get; set; }
    
    [Required (ErrorMessage = "Необходимо ввести пароль")]
    public string Password { get; set; }
}