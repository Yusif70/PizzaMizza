using PizzaMizza.Entity;
using PizzaMizza.Enums;
using PizzaMizza.Services;

PizzaService pizzaService = new();

Console.WriteLine("PizzaMizzaya xos gelmisiniz");
while (true)
{
    Console.Write("Pizzalarin siyahisina baxmaq ucun 1, yeni pizza yaratmaq ucun 2 daxil edin: ");
    int.TryParse(Console.ReadLine(), out int act);
    switch (act)
    {
        case 1:
            if (pizzaService.GetAll().Count == 0)
            {
                Console.WriteLine("sistemde pizza movcud deyil");
            }
            else
            {
                foreach (Pizza pizza in pizzaService.GetAll())
                {
                    Console.WriteLine($"{pizza.Id}-{pizza.Name} {pizza.Size} olcude cemi {pizza.Price}$");
                }
                Console.WriteLine("Pizza haqqinda etrafli melumat almaq isteyirsizse pizzanın İd -sini ,istemirsizse 0 daxil edin: ");

                bool loop = true;
                while (loop)
                {
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        if (index == 0)
                        {
                            loop = false;
                        }
                        else if (index > pizzaService.GetAll().Count)
                        {
                            Console.WriteLine("daxil etdiyiniz indeks ucun pizza tapilmadi");
                        }
                        else
                        {
                            foreach (string ingredient in pizzaService.GetAll().Find(pizza => pizza.Id == index).Ingredients)
                            {
                                Console.WriteLine(ingredient);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("emeliyyat tapilmadi");
                    }
                }
            }
            break;
        case 2:
            int id = pizzaService.GetAll().Count == 0 ? 1 : pizzaService.GetAll().Count + 1;
            Console.Write("pizza adi: ");
            string name = Console.ReadLine();
            bool invalid = true;
            while (invalid)
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("pizza adi bos buraxila bilmez");
                    name = Console.ReadLine();
                }
                else
                {
                    invalid = false;
                }
            }
            Console.WriteLine("pizza inqrediyentlerini daxil edin, sonlandirmaq ucun 3 daxil edin");
            List<string> ingredients = [];

            invalid = true;
            while (invalid)
            {
                string ingredient = Console.ReadLine();
                if (string.IsNullOrEmpty(ingredient.Trim()))
                {
                    Console.WriteLine("inqredient daxil edin");
                }
                else if (ingredient == "3")
                {
                    invalid = false;
                }
                else
                {
                    ingredients.Add(ingredient);
                }
            }

            Console.WriteLine("pizza olcusu: ");
            foreach (string s in Enum.GetNames(typeof(PizzaSize)))
            {
                Console.WriteLine($"\t{s}");
            }
            invalid = true;
            var size = new object();
            while (invalid)
            {
                string sizeInput = Console.ReadLine();
                if (Enum.TryParse(typeof(PizzaSize), sizeInput, true, out size))
                {
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("zehmet olmasa menudan bir olcu daxil edin");
                }
            }
            Console.Write("pizza qiymeti: ");
            double price = 0;
            invalid = true;
            while (invalid)
            {
                if (!double.TryParse(Console.ReadLine(), out double result))
                {
                    Console.WriteLine("reqem daxil edin");
                }
                else
                {
                    invalid = false;
                    price = result;
                }
            }

            Pizza newPizza = new(id, name, price, (PizzaSize)size, ingredients);
            pizzaService.Create(newPizza);
            break;
        default:
            Console.WriteLine("emeliyyat tapilmadi");
            break;
    }
}
