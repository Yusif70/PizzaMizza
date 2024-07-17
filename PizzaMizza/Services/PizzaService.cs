using PizzaMizza.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services
{
	public class PizzaService : IPizzaService
	{
		private List<Pizza> pizzaList = [];

        public int Count => throw new NotImplementedException();

        public void Create(Pizza pizza)
		{
			pizzaList.Add(pizza);
		}
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAll()
		{
			return pizzaList;
		}

        public Pizza GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Pizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
