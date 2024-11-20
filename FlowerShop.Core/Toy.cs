using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Core;

public class Toy : IEntity
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Image { get; set; }
    
    public double Price { get; set; }
}