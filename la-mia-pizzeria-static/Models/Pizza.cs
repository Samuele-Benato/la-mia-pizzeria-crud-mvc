using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Description { get; set; }
        public string? Image { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(4, 25, ErrorMessage = "il prezzo deve essere tra 4 e 25 euro")]
        public double Price { get; set; }

        public Pizza() { }
        public Pizza(string name, string description, string image, double price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
