using DinoDiner.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test class for Frycertops fries
    /// </summary>
    public class FryceritopsUnitTests
    {
        /// <summary>
        /// Inherits from base class Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Fryceritops test = new Fryceritops();
            Assert.IsAssignableFrom<Side>(test);
        }
        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fryceritops")]
        [InlineData(ServingSize.Medium, "Medium Fryceritops")]
        [InlineData(ServingSize.Large, "Large Fryceritops")]
        public void NameShouldBeCorrect(ServingSize s, string n)
        {
            Fryceritops test = new Fryceritops() { Size = s };
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
        [InlineData(ServingSize.Large, 5.00)]
        public void PriceShouldBeCorrect(ServingSize s, decimal p)
        {
            Fryceritops test = new Fryceritops() { Size = s };
            Assert.Equal(p, test.Price);
        }

        /// <summary>
        /// Check that teh number of calories is correct
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="sauce">sauce</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(ServingSize.Small, false, 375)]
        [InlineData(ServingSize.Medium, false, 465)]
        [InlineData(ServingSize.Large, false, 510)]
        [InlineData(ServingSize.Small, true, 375 + 80)]
        [InlineData(ServingSize.Medium, true, 465 + 80)]
        [InlineData(ServingSize.Large, true, 510 + 80)]
        public void CaloriesShouldBeCorrect(ServingSize s, bool sauce, uint cals)
        {
            Fryceritops test = new Fryceritops() { Size = s, Sauce = sauce };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// Checks that the serving size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Fryceritops test = new Fryceritops();
            test.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, test.Size);
        }

        /// <summary>
        /// Fries should come with salt
        /// </summary>
        [Fact]
        public void SaltShouldDefaultToTrue()
        {
            Fryceritops test = new Fryceritops();
            Assert.True(test.Salt);
        }

        /// <summary>
        /// Should be able to take off salt
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSalt()
        {
            Fryceritops test = new Fryceritops();
            test.Salt = !test.Salt;
            Assert.False(test.Salt);
        }

        /// <summary>
        /// Fries should not deafult to having sauce
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToFalse()
        {
            Fryceritops test = new Fryceritops();
            Assert.False(test.Sauce);
        }

        /// <summary>
        /// Should be able to add sauce to the order
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()
        {
            Fryceritops test = new Fryceritops();
            test.Sauce = !test.Sauce;
            Assert.True(test.Sauce);
        }
    }
}
