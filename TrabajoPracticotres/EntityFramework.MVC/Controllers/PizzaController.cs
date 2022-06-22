using ApiLogic;
using EntityFramework.Entities;
using EntityFramework.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework.MVC.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        PizzaLogic logic = new PizzaLogic();

        public async Task<ActionResult> Index()
        {
            List<Pizza> pizza = await logic.GetPizza();
            List<PizzaModel> pizzaViewModel = pizza.Select(d => new PizzaModel()
            {
                

                Crust = d.Crust,
                Flavor = d.Flavor,
                Size = d.Size,
                TableNo = d.Table_No,

            }).ToList();

            return View(pizzaViewModel);
        }
    }
}