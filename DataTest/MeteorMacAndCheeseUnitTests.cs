using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// test class for the mac and cheese
    /// </summary>
    public class MeteorMacAndCheeseUnitTests
    {
        /// <summary>
        /// Inherits from base class Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MeteorMacAndCheese test = new MeteorMacAndCheese();
            Assert.IsAssignableFrom<Side>(test);
        }
        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Meteor Mac & Cheese")]
        [InlineData(ServingSize.Medium, "Medium Meteor Mac & Cheese")]
        [InlineData(ServingSize.Large, "Large Meteor Mac & Cheese")]
        public void NameShouldBeCorrect(ServingSize s, string n)
        {
            MeteorMacAndCheese test = new MeteorMacAndCheese() { Size = s };
            Assert.Equal(n, test.Name);
        }

        /// <summary>
        /// Checks that the price is correct
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="p">price</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.50)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.25)]
        public void PriceShouldBeCorrect(ServingSize s, decimal p)
        {
            MeteorMacAndCheese test = new MeteorMacAndCheese() { Size = s };
            Assert.Equal(p, test.Price);
        }

        /// <summary>
        /// Check that teh number of calories is correct
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="sauce">sauce</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 425)]
        [InlineData(ServingSize.Medium, 510)]
        [InlineData(ServingSize.Large, 700)]
        public void CaloriesShouldBeCorrect(ServingSize s, uint cals)
        {
            MeteorMacAndCheese test = new MeteorMacAndCheese() { Size = s };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// Checks that the serving size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MeteorMacAndCheese test = new MeteorMacAndCheese();
            test.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, test.Size);
        }
    }
}
