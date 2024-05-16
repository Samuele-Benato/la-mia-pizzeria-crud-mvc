using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
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
