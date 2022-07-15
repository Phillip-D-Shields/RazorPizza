using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel ThisPizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = ThisPizza.BasePrice;
            if (ThisPizza.TomatoSauce) PizzaPrice += 1;
            if (ThisPizza.Cheese) PizzaPrice += 1;
            if (ThisPizza.Pepperoni) PizzaPrice += 1;
            if (ThisPizza.Mushroom) PizzaPrice += 1;
            if (ThisPizza.Pineapple) PizzaPrice += 1;
            if (ThisPizza.Sausage) PizzaPrice += 1;
            if (ThisPizza.GreenPeppers) PizzaPrice += 1;

            return RedirectToPage("/CheckOut/Checkout", new { ThisPizza.PizzaName, PizzaPrice });
            
        }
    }
}
