using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FlowerShop.Core;

public class User
{
    [Key]
    public Guid Id { get; set; }
    
    public string Email { get; set; }
    
    public string? Role { get; set; }
    
    public string UserName { get; set; }
    
    public string City { get; set; }
    
    public string PasswordHash { get; set; }
    
    public string FirstName { get; set; }

    public double Balance { get; set; }
    
    public string LastName { get; set; }

    public List<Guid>? ShopFlowers { get; set; } = new List<Guid>();
    
    public List<Guid>? ShopToys { get; set; } = new List<Guid>();
    
    public List<Guid>? ShopPacks { get; set; } = new List<Guid>();
}