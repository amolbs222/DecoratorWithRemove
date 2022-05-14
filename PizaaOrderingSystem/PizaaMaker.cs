using PizaaOrderingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizaaOrderingSystem
{
    public class PizaaMaker : Pizza
    {
        protected Pizza _pizza;

        public PizaaMaker(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetPizaaDetails()
        {
            return _pizza.Description;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        } 
        public override Pizza RemovePizzaItem(string name)
        {
        
            if (this.GetType().Name== name)
            {
                return _pizza;
            }
            else
            {
                this._pizza = _pizza.RemovePizzaItem(name);
                return this;
            }
        }
    }  
}
