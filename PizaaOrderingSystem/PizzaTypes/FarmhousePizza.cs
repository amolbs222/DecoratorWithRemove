using PizaaOrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizaaOrderingSystem.PizzaTypes
{
    public class FarmhousePizza : PizaaMaker
    {
        public FarmhousePizza(Pizza pizza)
            : base(pizza)
        {
            Description = "Farm house Pizza with";
        }

        public override string GetPizaaDetails()
        {
            return String.Format("{0} {1}", _pizza.GetPizaaDetails(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 120;
        }
    }
}
