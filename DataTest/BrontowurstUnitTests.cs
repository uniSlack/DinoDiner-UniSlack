using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    public class BrontowurstUnitTests
    {
        /// <summary>
        /// Should inherit from the base class of Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            Brontowurst test = new Brontowurst();
            Assert.IsAssignableFrom<Entree>(test);
        }


        /// <summary>
        /// Checks that the name is correct for every possible order
        /// </summary>
        /// <param name="o">onions</param>
        /// <param name="p">peppers</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void NameShouldBeCorrect(bool o, bool p)
        {
            Brontowurst test = new Brontowurst() { Onions = o, Peppers = p };
            Assert.Equal("Brontowurst", test.Name);
        }

        /// <summary>
        /// Checks that the price is correct
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            Brontowurst test = new Brontowurst();
            Assert.Equal(5.86m, test.Price);
        }
        
        /// <summary>
        /// Checks that the Calories are correct
        /// </summary>
        public void CaloriesShouldBeCorrect()
        {
            Brontowurst test = new Brontowurst();
            Assert.Equal((uint)512, test.Calories);
        }

        /// <summary>
        /// Onions should be on the bronto
        /// </summary>
        [Fact]
        public void OnionsShouldDefaultToTrue()
        {
            Brontowurst test = new Brontowurst();
            Assert.True(test.Onions);
        }

        /// <summary>
        /// Should be able to add or remove onions
        /// </summary>
        public void ShouldBeAbleToSetOnions()
        {
            Brontowurst test = new Brontowurst();
            test.Onions = false;
            Assert.False(test.Onions);
        }


        /// <summary>
        /// Onions should start on the bronto
        /// </summary>
        public void PeppersShouldDefaultToTrue()
        {
            Brontowurst test = new Brontowurst();
            Assert.True(test.Peppers);
        }

        /// <summary>
        /// should be able to add or remove peppers
        /// </summary>
        public void ShouldBeAbleToSetPeppers()
        {
            Brontowurst test = new Brontowurst();
            test.Peppers = false;
            Assert.False(test.Peppers);
        }
    }
}
