using PizzaMizza.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Entity
{
	public partial class Pizza(int id, string name, double price, string size, List<string> ingredients)
	{
		public int Id { get; set; } = id;
		public string Name { get; set; } = name;
		public double Price { get; set; } = price;
		public string Size { get; set; } = size;
	}
	public partial class Pizza
	{
		public List<string> Ingredients { get; set; } = ingredients;
	}
}
