﻿using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_static.Models;
using static System.Net.Mime.MediaTypeNames;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [MinWords(5)]
        public string Description { get; set; }
        public string? Image { get; set; } = "~/img/Marghe-pizza-bufala.webp";

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(2, 50, ErrorMessage = "il prezzo deve essere tra 2 e 50 euro")]
        public double Price { get; set; }
        public Pizza() 
        {
            Image ??= "/img/Marghe-pizza-bufala.webp";
        }
        public Pizza(string name, string description, string? image, double price)
        {
            Name = name;
            Description = description;
            Image = image ?? "~/img/Marghe-pizza-bufala.webp";
            Price = price;
        }
    }
}
