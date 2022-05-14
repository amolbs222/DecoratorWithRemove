using PizaaOrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizaaOrderingSystem.Toppings
{
    public class PeppersToppings : PizaaMaker
    {
        public PeppersToppings(Pizza pizza)
            : base(pizza)
        {
            Description = "Peppers Toppings";
        }

        public override string GetPizaaDetails()
        {
            return String.Format("{0} {1}", _pizza.GetPizaaDetails(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
    }
}
