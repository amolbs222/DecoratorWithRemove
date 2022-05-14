using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizaaOrderingSystem.Interfaces
{
    public abstract class Pizza
    {
        public string Description { get; set; }

        public abstract string GetPizaaDetails();

        public abstract double CalculateCost();

        public abstract Pizza RemovePizzaItem(string name);
    }
}
