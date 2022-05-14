using PizaaOrderingSystem.Interfaces;
using PizaaOrderingSystem.PizzaSizes;
using PizaaOrderingSystem.PizzaTypes;
using PizaaOrderingSystem.Toppings;

class Program
{
    static void Main(string[] args)
    { 
        bool completPizzaProcessing = false;
        Pizza Pizza = new LargePizza();
        Console.WriteLine("********Order Your Pizza*******");
        Console.WriteLine("Please select size of pizza you wish to order,Press \n1 for Small \n2 for Medium \n3 for Large");
        string pizzaSize = Console.ReadLine();
        switch(Convert.ToInt32(pizzaSize))
        {
            case 1:
                Pizza = new SmallPizza();
                break;
            case 2:
                Pizza = new MediumPizza();
                break;
            case 3:
                Pizza = new LargePizza();
                break;
        }
        Console.WriteLine("Please select type of pizza you wish to order,Press \n1 for Margherita \n2 for Farmhouse \n3 for Peppy Paneer \n4 for Veg Extravaganza");
        string pizzaType = Console.ReadLine();
        switch (Convert.ToInt32(pizzaType))
        {
            case 1:
                Pizza = new MargheritaPizza(Pizza);
                break;
            case 2:
                Pizza = new FarmhousePizza(Pizza);
                break;
            case 3:
                Pizza = new PeppyPaneerPizza(Pizza);
                break;
            case 4:
                Pizza = new VegExtravaganzaPizza(Pizza);
                break;
        }
        do
        {
            Console.WriteLine("Do you want to add some toppings to pizza,Press \n1 for Cheese \n2 for Ham \n3 for Peppers \n4 to get final total");
           string pizzaToppings = Console.ReadLine();
            switch (Convert.ToInt32(pizzaToppings))
            {
                case 1:
                    Pizza = new CheeseToppings(Pizza);
                    break;
                case 2:
                    Pizza = new HamToppings(Pizza);
                    break;
                case 3:
                    Pizza = new PeppersToppings(Pizza);
                    break;
                case 4:
                    completPizzaProcessing = true;
                    break;
            }
        }
        while (!completPizzaProcessing);

        Pizza = Pizza.RemovePizzaItem(typeof(SmallPizza).Name);
        Pizza = Pizza.RemovePizzaItem(typeof(CheeseToppings).Name);
        Pizza = Pizza.RemovePizzaItem(typeof(HamToppings).Name);
      

        Console.WriteLine("Thanks for ordering the pizza here are the details of your order \nPizaa Details : "+Pizza.GetPizaaDetails()+"\nOrder Total : "+Pizza.CalculateCost()+"");
        Console.ReadLine();
    }
}