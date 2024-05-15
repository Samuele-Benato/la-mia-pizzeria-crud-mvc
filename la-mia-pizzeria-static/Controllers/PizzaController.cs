using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly List<Pizza> _pizzas = new List<Pizza>
        {
            new Pizza("BUFALA", "Passata di pomodoro San Marzano. Dop, bufala campana Dop, pepe nero, basilico fresco, olio extravergine d’oliva biologico.", "~/img/Marghe-pizza-bufala.webp", 8.50),
            new Pizza("NORMA", "Passata di pomodoro San Marzano Dop, provola affumicata d’Agerola, melanzane al forno, pomodorini semi dry, ricotta salata, basilico fresco, olio extra vergine d’oliva biologico.", "~/img/Marghe-Norma.webp", 10.50),
            new Pizza("NAPOLI", "Passata di pomodoro San Marzano Dop, fior di latte d’Agerola, alici di Cetara, olive caiazzane, capperi di Salina, origano, basilico fresco, olio extravergine d’oliva biologico.", "~/img/marghe-napoli.webp", 9.50),
            new Pizza("VEGANA", "Creazione della settimana con prodotti stagionali, ingredienti freschi e naturali. Perfetta per gli amanti della cucina vegetale.", "~/img/Marghe-Vegana.webp", 7.50),
            new Pizza("DIAVOLA GIALLA", "Passata di pomodorini del Piannolo del Vesuvio gialli, fior di latte d’Agerola, salamino piccante di Secondigliano, fili di peperoncino, nduja, basilico fresco, olio extravergine d’oliva", "~/img/Marghe-Diavola.webp", 12.50),
            new Pizza("MELANZANE E PORCHETTA", "Crema di melanzane cotte al forno, fior di latte, provola affumicata, porchetta d’Ariccia, taralli pugliesi, crema di pomodorini, rosmarino, olio extravergine d’oliva", "~/img/Marghe-Melanzane-e-porchetta.webp", 11.50)
        };
        
        
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                foreach(Pizza pizza in _pizzas)
                {
                    db.Add(pizza);
                    db.SaveChanges();
                }
              
            }

            if (_pizzas.Any())
            {
                return View(_pizzas);
            }
            else
            {
                ViewBag.Message = "Nessuna pizza disponibile al momento.";
                return View();
            }
          
        }

        public IActionResult Details(int id)
        {
            var pizza = _pizzas.Where(p => p.PizzaId == id);
            if (pizza == null)
            {
                return NotFound();
            }
            return View(pizza);
        }
    }
}
