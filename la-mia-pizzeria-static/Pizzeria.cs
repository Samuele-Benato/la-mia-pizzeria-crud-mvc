namespace la_mia_pizzeria_static
{
    public class Pizzeria
    {
        public string Name { get; set; }
        public List<Pizza> pizzas { get; set; } = new List<Pizza>();

        public Pizzeria(string name) // Mi rendo conto che in questo modo ogni pizzeria creata avrà questo elenco di pizze predefinito ma al momento è un comportamento voluto 
        {
            Name = name;

            Pizza bufala = new Pizza("BUFALA", "Passata di pomodoro San Marzano. Dop, bufala campana Dop, pepe nero, basilico fresco, olio extravergine d’oliva biologico.", "~/img/Marghe-pizza-bufala.webp", 8.50);
            pizzas.Add(bufala);

            Pizza norma = new Pizza("NORMA", "Passata di pomodoro San Marzano Dop, provola affumicata d’Agerola, melanzane al forno, pomodorini semi dry, ricotta salata, basilico fresco, olio extra vergine d’oliva biologico.", "~/img/Marghe-Norma.webp", 10.50);
            pizzas.Add(norma);

            Pizza napoletana = new Pizza("NAPOLI", "Passata di pomodoro San Marzano Dop, fior di latte d’Agerola, alici di Cetara, olive caiazzane, capperi di Salina, origano, basilico fresco, olio extravergine d’oliva biologico.", "~/img/marghe-napoli.webp", 9.50);
            pizzas.Add(napoletana);

            Pizza vegana = new Pizza("VEGANA", "Creazione della settimana con prodotti stagionali, ingredienti freschi e naturali. Perfetta per gli amanti della cucina vegetale.", "~/img/Marghe-Vegana.webp", 7.50);
            pizzas.Add(vegana);

            Pizza diavola = new Pizza("DIAVOLA GIALLA", "Passata di pomodorini del Piannolo del Vesuvio gialli, fior di latte d’Agerola, salamino piccante di Secondigliano, fili di peperoncino, nduja, basilico fresco, olio extravergine d’oliva", "~/img/Marghe-Diavola.webp", 12.50);
            pizzas.Add(diavola);

            Pizza melanzanePorchetta = new Pizza("MELANZANE E PORCHETTA", "Crema di melanzane cotte al forno, fior di latte, provola affumicata, porchetta d’Ariccia, taralli pugliesi, crema di pomodorini, rosmarino, olio extravergine d’oliva", "~/img/Marghe-Melanzane-e-porchetta.webp", 11.50);
            pizzas.Add(melanzanePorchetta);
        }
    }
}
