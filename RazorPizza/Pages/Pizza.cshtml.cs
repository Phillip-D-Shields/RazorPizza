using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzasDb = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true, 
                Cheese=true, 
                FinalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle = "Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                GreenPeppers=true,
                FinalPrice=7
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Sausage=true,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                Sausage=true,
                GreenPeppers=true,
                FinalPrice=8
            },
        };
        public void OnGet()
        {
        }
    }
}
