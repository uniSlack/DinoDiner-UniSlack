using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test Class for the coffee
    /// </summary>
    public class CretaceousCoffeeUnitTests
    {
        /// <summary>
        /// Inherits from base class Drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            CretaceousCoffee test = new CretaceousCoffee();
            Assert.IsAssignableFrom<Drink>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Cretaceous Coffee")]
        [InlineData(ServingSize.Medium, "Medium Cretaceous Coffee")]
        [InlineData(ServingSize.Large, "Large Cretaceous Coffee")]
        public void NameShouldBeCorrect(ServingSize s, string n)
        {
            CretaceousCoffee test = new CretaceousCoffee() { Size = s };
            Assert.Equal(n, test.Name);
        }

        /// <summary>
        /// Checks that the price is correct
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="p">price</param>
        [Theory]
        [InlineData(ServingSize.Small, .75)]
        [InlineData(ServingSize.Medium, 1.25)]
        [InlineData(ServingSize.Large, 2.00)]
        public void PriceShouldBeCorrect(ServingSize s, decimal p)
        {
            CretaceousCoffee test = new CretaceousCoffee() { Size = s };
            Assert.Equal(p, test.Price);
        }

        /// <summary>
        /// Checks that the calories are correct
        /// </summary>
        /// <param name="c">cream</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(true, 64)]
        [InlineData(false, 0)]
        public void CaloriesShouldBeCorrect(bool c, uint cals)
        {
            CretaceousCoffee test = new CretaceousCoffee() { Cream = c };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// Checks that the serving size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CretaceousCoffee test = new CretaceousCoffee();
            test.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, test.Size);
        }

        /// <summary>
        /// Should be able to change the cream
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCream()
        {
            CretaceousCoffee test = new CretaceousCoffee();
            test.Cream = true;
            Assert.True(test.Cream);
        }

        /// <summary>
        /// Cream should not be served by default
        /// </summary>
        [Fact]
        public void CreamShouldDefaultToFalse()
        {
            CretaceousCoffee test = new CretaceousCoffee();
            Assert.False(test.Cream);
        }

        /// <summary>
        /// Checks that INotifyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            CretaceousCoffee test = new CretaceousCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }
    }
}
