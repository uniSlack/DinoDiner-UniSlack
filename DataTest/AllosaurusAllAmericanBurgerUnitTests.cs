using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test class for the Allosaurus burger
    /// </summary>
    public class AllosaurusAllAmericanBurgerUnitTests
    {
        /// <summary>
        /// Inherits from base class Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger() ;
            Assert.Equal("Allosaurus All-American Burger", test.Name);
        }

        /// <summary>
        /// Checks that the price is correct 
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.Equal(2.10m, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.Equal((uint)233, test.Calories);
        }

        /// <summary>
        /// Should start with 1 patty
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.Equal((uint)1, test.Patties);
        }

        /// <summary>
        /// Should be able to change the number of patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Patties = 3;
            Assert.Equal((uint)3, test.Patties);
        }

        /// <summary>
        /// Ketchup is correctly applied
        /// </summary>
        [Fact] 
        public void KetchupShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.True(test.Ketchup);
        }

        /// <summary>
        /// Should be able to add and remove ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Ketchup = false;
            Assert.False(test.Ketchup);
        }

        /// <summary>
        /// Mustard is correctly applied
        /// </summary>
        [Fact] 
        public void MustardShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.True(test.Mustard);
        }

        /// <summary>
        /// Should be able to add and remove Mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Mustard = false;
            Assert.False(test.Mustard);
        }

        /// <summary>
        /// Pickle is correctly applied
        /// </summary>
        [Fact] 
        public void PickleShouldDefaultToTrue()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.True(test.Pickle);
        }

        /// <summary>
        /// Should be able to add and remove pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Pickle = false;
            Assert.False(test.Pickle);
        }

        /// <summary>
        /// Mayo is correctly applied
        /// </summary>
        [Fact] 
        public void MayoShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.Mayo);
        }
        
        /// <summary>
        /// Should be able to add and remove Mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Mayo = true;
            Assert.True(test.Mayo);
        }

        /// <summary>
        /// BBQ should not come with the burger
        /// </summary>
        [Fact] 
        public void BBQShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.BBQ);
        }

        /// <summary>
        /// Should be able to add and remove BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.BBQ = true;
            Assert.True(test.BBQ);
        }

        /// <summary>
        /// Onion is correctly applied
        /// </summary>
        [Fact] 
        public void OnionShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.Onion);
        }

        /// <summary>
        /// Should be able to add and remove onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Onion = true;
            Assert.True(test.Onion);
        }

        /// <summary>
        /// Tomato is correctly applied
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.Tomato);
        }

        /// <summary>
        /// Should be able to add and remove tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Tomato = true;
            Assert.True(test.Tomato);
        }

        /// <summary>
        /// Lettuce is correctly applied
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.Lettuce);
        }

        /// <summary>
        /// Should be able to add and remove lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Lettuce = true;
            Assert.True(test.Lettuce);
        }

        /// <summary>
        /// American Cheese is correctly applied
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.AmericanCheese);
        }

        /// <summary>
        /// Should be able to add and remove American Cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.AmericanCheese = true;
            Assert.True(test.AmericanCheese);
        }

        /// <summary>
        /// Swiss cheese is correctly applied
        /// </summary>
        [Fact] 
        public void SwissCheeseShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.SwissCheese);
        }

        /// <summary>
        /// Should be able to add and remove swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.SwissCheese = true;
            Assert.True(test.SwissCheese);
        }

        /// <summary>
        /// Bacon is correctly applied
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.Bacon);
        }

        /// <summary>
        /// Should be able to add and remove Bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Bacon = true;
            Assert.True(test.Bacon);
        }

        /// <summary>
        /// Mushroom is correctly applied
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            Assert.False(test.Mushrooms);
        }

        /// <summary>
        /// Should be able to add and remove mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            AllosaurusAll_AmericanBurger test = new AllosaurusAll_AmericanBurger();
            test.Mushrooms = true;
            Assert.True(test.Mushrooms);
        }
    }
}
