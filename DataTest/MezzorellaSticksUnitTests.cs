using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test Class for the mezzorella sticks
    /// </summary>
    public class MezzorellaSticksUnitTests
    {
        /// <summary>
        /// Inherits from base class Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MezzorellaSticks test = new MezzorellaSticks();
            Assert.IsAssignableFrom<Side>(test);
        }
        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Mezzorella Sticks")]
        [InlineData(ServingSize.Medium, "Medium Mezzorella Sticks")]
        [InlineData(ServingSize.Large, "Large Mezzorella Sticks")]
        public void NameShouldBeCorrect(ServingSize s, string n)
        {
            MezzorellaSticks test = new MezzorellaSticks() { Size = s };
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
            MezzorellaSticks test = new MezzorellaSticks() { Size = s };
            Assert.Equal(p, test.Price);
        }

        /// <summary>
        /// Check that teh number of calories is correct
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="sauce">sauce</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 530)]
        [InlineData(ServingSize.Medium, 620)]
        [InlineData(ServingSize.Large, 730)]
        public void CaloriesShouldBeCorrect(ServingSize s, uint cals)
        {
            MezzorellaSticks test = new MezzorellaSticks() { Size = s };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// Checks that the serving size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MezzorellaSticks test = new MezzorellaSticks();
            test.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, test.Size);
        }
    }
}
