using PizzaMizza.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services
{
    public interface IPizzaService
    {
        public void Create(Pizza pizza);
        public void Update(int id,Pizza pizza);
        public void Delete(int id);
        public List<Pizza> GetAll();
        public Pizza GetById(int id);
        int Count { get; }

    }
}
