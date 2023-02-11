using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ContosoPizza.Models;

public class Topping
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    
    [JsonIgnore]
    public ICollection<Pizza>? Pizzas { get; set; }
    
    public int Calories { get; set; }
}