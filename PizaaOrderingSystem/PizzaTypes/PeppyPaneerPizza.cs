using PizaaOrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizaaOrderingSystem.PizzaTypes
{
    public class PeppyPaneerPizza : PizaaMaker
    {
        public PeppyPaneerPizza(Pizza pizza)
            : base(pizza)
        {
            Description = "Peppy Paneer Pizza with";
        }

        public override string GetPizaaDetails()
        {
            return String.Format("{0} {1}", _pizza.GetPizaaDetails(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 110;
        }
    }
}
