using PizaaOrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizaaOrderingSystem.PizzaSizes
{
    public class MediumPizza : Pizza
    { 
        public MediumPizza()
        {
            Description = "Medium";
        }

        public override string GetPizaaDetails()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 6.00;
        }

        public override Pizza RemovePizzaItem(string name) { return null; }
    }
}
