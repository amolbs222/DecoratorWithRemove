using PizaaOrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizaaOrderingSystem.Toppings
{
    public class HamToppings : PizaaMaker
    {
        public HamToppings(Pizza pizza)
            : base(pizza)
        {
            Description = "Ham Toppings";
        }

        public override string GetPizaaDetails()
        {
            return String.Format("{0} {1}", _pizza.GetPizaaDetails(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.50;
        }
    }
}
