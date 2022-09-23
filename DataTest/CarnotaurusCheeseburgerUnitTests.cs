using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test class for Carno burgers
    /// </summary>
    public class CarnotaurusCheeseburgerUnitTests
    {
        /// <summary>
        /// Inherits from base class Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.Equal("Carnoaurus Cheeseburger", test.Name);
        }

        /// <summary>
        /// Checks that the price is correct 
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.Equal(2.55m, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.Equal((uint)356, test.Calories);
        }

        /// <summary>
        /// Should start with 1 patty
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.Equal((uint)1, test.Patties);
        }

        /// <summary>
        /// Should be able to change the number of patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Patties = 3;
            Assert.Equal((uint)3, test.Patties);
        }

        /// <summary>
        /// Ketchup is correctly applied
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.True(test.Ketchup);
        }

        /// <summary>
        /// Should be able to add and remove ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Ketchup = false;
            Assert.False(test.Ketchup);
        }

        /// <summary>
        /// Mustard is correctly applied
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.Mustard);
        }

        /// <summary>
        /// Should be able to add and remove Mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Mustard = true;
            Assert.True(test.Mustard);
        }

        /// <summary>
        /// Pickle is correctly applied
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.True(test.Pickle);
        }

        /// <summary>
        /// Should be able to add and remove pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Pickle = false;
            Assert.False(test.Pickle);
        }

        /// <summary>
        /// Mayo is correctly applied
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.Mayo);
        }

        /// <summary>
        /// Should be able to add and remove Mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Mayo = true;
            Assert.True(test.Mayo);
        }

        /// <summary>
        /// BBQ should not come with the burger
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.BBQ);
        }

        /// <summary>
        /// Should be able to add and remove BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.BBQ = true;
            Assert.True(test.BBQ);
        }

        /// <summary>
        /// Onion is correctly applied
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.Onion);
        }

        /// <summary>
        /// Should be able to add and remove onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Onion = true;
            Assert.True(test.Onion);
        }

        /// <summary>
        /// Tomato is correctly applied
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.True(test.Tomato);
        }

        /// <summary>
        /// Should be able to add and remove tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Tomato = false;
            Assert.False(test.Tomato);
        }

        /// <summary>
        /// Lettuce is correctly applied
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.Lettuce);
        }

        /// <summary>
        /// Should be able to add and remove lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Lettuce = true;
            Assert.True(test.Lettuce);
        }

        /// <summary>
        /// American Cheese is correctly applied
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.True(test.AmericanCheese);
        }

        /// <summary>
        /// Should be able to add and remove American Cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.AmericanCheese = false;
            Assert.False(test.AmericanCheese);
        }

        /// <summary>
        /// Swiss cheese is correctly applied
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.SwissCheese);
        }

        /// <summary>
        /// Should be able to add and remove swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.SwissCheese = true;
            Assert.True(test.SwissCheese);
        }

        /// <summary>
        /// Bacon is correctly applied
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.Bacon);
        }

        /// <summary>
        /// Should be able to add and remove Bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Bacon = true;
            Assert.True(test.Bacon);
        }

        /// <summary>
        /// Mushroom is correctly applied
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            Assert.False(test.Mushrooms);
        }

        /// <summary>
        /// Should be able to add and remove mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            CarnotaurusCheeseburger test = new CarnotaurusCheeseburger();
            test.Mushrooms = true;
            Assert.True(test.Mushrooms);
        }
    }
}
