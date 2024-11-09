using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Models;

public class UserViewModel
{
    [Required (ErrorMessage = "Необходимо ввести почту")]
    public string Email { get; set; }
    
    [Required (ErrorMessage = "Необходимо ввести пароль")]
    public string Password { get; set; }
    
    [Required (ErrorMessage = "Необходимо ввести имя")]
    public string FirstName { get; set; }
    
    [Required (ErrorMessage = "Необходимо ввести фамилию")]
    public string LastName { get; set; }
}