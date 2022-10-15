using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test class for the triceritots
    /// </summary>
    public class TriceritotsUnitTests
    {
        /// <summary>
        /// Inherits from base class Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Triceritots test = new Triceritots();
            Assert.IsAssignableFrom<Side>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Triceritots")]
        [InlineData(ServingSize.Medium, "Medium Triceritots")]
        [InlineData(ServingSize.Large, "Large Triceritots")]
        public void NameShouldBeCorrect(ServingSize s, string n)
        {
            Triceritots test = new Triceritots() { Size = s };
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
            Triceritots test = new Triceritots() { Size = s };
            Assert.Equal(p, test.Price);
        }

        /// <summary>
        /// Check that teh number of calories is correct
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="sauce">sauce</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 351)]
        [InlineData(ServingSize.Medium, 409)]
        [InlineData(ServingSize.Large, 583)]
        public void CaloriesShouldBeCorrect(ServingSize s, uint cals)
        {
            Triceritots test = new Triceritots() { Size = s };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// Checks that the serving size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Triceritots test = new Triceritots();
            test.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, test.Size);
        }

        /// <summary>
        /// Checks that the data bound properties change
        /// </summary>
        /// <param name="size">data to test</param>
        /// <param name="propertyName">name that we are checking</param>
        [Theory]
        [InlineData(ServingSize.Small, "Size")]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Large, "Size")]
        [InlineData(ServingSize.Small, "Price")]
        [InlineData(ServingSize.Medium, "Price")]
        [InlineData(ServingSize.Large, "Price")]
        [InlineData(ServingSize.Small, "Calories")]
        [InlineData(ServingSize.Medium, "Calories")]
        [InlineData(ServingSize.Large, "Calories")]
        public void ChangingSizeShouldNotifyOfPropertyChanges(ServingSize size, string propertyName)
        {
            Triceritots tots = new Triceritots();
            Assert.PropertyChanged(tots, propertyName, () => {
                tots.Size = size;
            });
        }

        /// <summary>
        /// Checks that INotifyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            Triceritots tots = new Triceritots();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tots);
        }
    }
}
