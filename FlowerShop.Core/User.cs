using Microsoft.AspNetCore.Identity;

namespace FlowerShop.Core;

public class User : IdentityUser
{
    public string Email { get; set; }
    
    public string FirstName { get; set; }

    public double Balance { get; set; }
    
    public string LastName { get; set; }

    public List<Guid> ShopFlowers { get; set; } = new List<Guid>();
}