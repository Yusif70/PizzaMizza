using PizzaMizza.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services
{
	public class PizzaService
	{
		private List<Pizza> pizzaList = [];
		public void CreatePizza(Pizza pizza)
		{
			pizzaList.Add(pizza);
		}
		public List<Pizza> GetPizzas()
		{
			return pizzaList;
		}
	}
}
