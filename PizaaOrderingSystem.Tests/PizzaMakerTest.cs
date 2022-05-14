using Moq;
using PizaaOrderingSystem.Interfaces;
using PizaaOrderingSystem.PizzaSizes;
using PizaaOrderingSystem.PizzaTypes;
using PizaaOrderingSystem.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizaaOrderingSystem.Tests
{
    public class PizzaMakerTest
    {
        private readonly Mock<Pizza> _Pizza;
        public PizzaMakerTest()
        {
            _Pizza = new Mock<Pizza>();
        }
        [Fact]
        public void  VerifyAppropriateTypeOfPizaaGetsReturned_WithSize()
        {
            Pizza pizza = new LargePizza();
            pizza = new MargheritaPizza(pizza);
            Assert.Equal("Large Margherita Pizza with", pizza.GetPizaaDetails());
        }

        [Fact]
        public void VerifyAppropriateTypeOfPizaaGetsReturned_WithToppings()
        {
            Pizza pizza = new LargePizza();
            pizza = new MargheritaPizza(pizza);
            pizza = new CheeseToppings(pizza);
            Assert.Equal("Large Margherita Pizza with Cheese Toppings", pizza.GetPizaaDetails());
        }


        [Fact]
        public void VerifyAppropriateTypeOfPizaaGetsReturned_WithMultipleToppings()
        {
            Pizza pizza = new MediumPizza();
            pizza = new PeppyPaneerPizza(pizza);
            pizza = new CheeseToppings(pizza);
            pizza = new HamToppings(pizza);
            Assert.Equal("Medium Peppy Paneer Pizza with Cheese Toppings Ham Toppings", pizza.GetPizaaDetails());
        }
        /******Same way we can write down more test cases********/
    }
}
