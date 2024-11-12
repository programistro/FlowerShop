using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Core;

public class Flower
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public double Price { get; set; }
    
    public string Image { get; set; }
}