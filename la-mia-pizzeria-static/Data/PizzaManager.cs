using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Data
{
    public static class PizzaManager
    {
        public static int CountPizzas()
        {
            using PizzaContext db = new PizzaContext();
            return db.Pizzas.Count();
        }
        public static List<Pizza> GetPizzas()
        {
            using (PizzaContext db = new PizzaContext())  
            return db.Pizzas.ToList();
        }

        public static Pizza GetPizza(int id)
        {
            using (PizzaContext db = new PizzaContext())  
            return db.Pizzas.FirstOrDefault(p => p.PizzaId == id);
        }

        public static void InsertPizza(Pizza pizza)
        {
            using PizzaContext db = new PizzaContext();
            db.Pizzas.Add(pizza);
            db.SaveChanges();
        }

        public static void Seed()
        {
            if (CountPizzas() == 0)
            {
                InsertPizza(new Pizza("BUFALA", "Passata di pomodoro San Marzano. Dop, bufala campana Dop, pepe nero, basilico fresco, olio extravergine d’oliva biologico.", "~/img/Marghe-pizza-bufala.webp", 8.50));
                InsertPizza(new Pizza("NORMA", "Passata di pomodoro San Marzano Dop, provola affumicata d’Agerola, melanzane al forno, pomodorini semi dry, ricotta salata, basilico fresco, olio extra vergine d’oliva biologico.", "~/img/Marghe-Norma.webp", 10.50));
                InsertPizza(new Pizza("NAPOLI", "Passata di pomodoro San Marzano Dop, fior di latte d’Agerola, alici di Cetara, olive caiazzane, capperi di Salina, origano, basilico fresco, olio extravergine d’oliva biologico.", "~/img/marghe-napoli.webp", 9.50));
                InsertPizza(new Pizza("VEGANA", "Creazione della settimana con prodotti stagionali, ingredienti freschi e naturali. Perfetta per gli amanti della cucina vegetale.", "~/img/Marghe-Vegana.webp", 7.50));
                InsertPizza(new Pizza("DIAVOLA GIALLA", "Passata di pomodorini del Piannolo del Vesuvio gialli, fior di latte d’Agerola, salamino piccante di Secondigliano, fili di peperoncino, nduja, basilico fresco, olio extravergine d’oliva", "~/img/Marghe-Diavola.webp", 12.50));
                InsertPizza(new Pizza("MELANZANE E PORCHETTA", "Crema di melanzane cotte al forno, fior di latte, provola affumicata, porchetta d’Ariccia, taralli pugliesi, crema di pomodorini, rosmarino, olio extravergine d’oliva", "~/img/Marghe-Melanzane-e-porchetta.webp", 11.50));
            }
        }
    }
}
