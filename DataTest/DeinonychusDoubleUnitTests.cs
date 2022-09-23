using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test class for Deinon double
    /// </summary>
    public class DeinonychusDoubleUnitTests
    {
        /// <summary>
        /// Inherits from base class Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.Equal("Deinonychus Double", test.Name);
        }

        /// <summary>
        /// Checks that the price is correct 
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.Equal(4.35m, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.Equal((uint)598, test.Calories);
        }

        /// <summary>
        /// Should start with 1 patty
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToTwo()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.Equal((uint)2, test.Patties);
        }

        /// <summary>
        /// Should be able to change the number of patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Patties = 3;
            Assert.Equal((uint)3, test.Patties);
        }

        /// <summary>
        /// Ketchup is correctly applied
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToFalse()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.False(test.Ketchup);
        }

        /// <summary>
        /// Should be able to add and remove ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Ketchup = true;
            Assert.True(test.Ketchup);
        }

        /// <summary>
        /// Mustard is correctly applied
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.False(test.Mustard);
        }

        /// <summary>
        /// Should be able to add and remove Mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Mustard = true;
            Assert.True(test.Mustard);
        }

        /// <summary>
        /// Pickle is correctly applied
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.True(test.Pickle);
        }

        /// <summary>
        /// Should be able to add and remove pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Pickle = false;
            Assert.False(test.Pickle);
        }

        /// <summary>
        /// Mayo is correctly applied
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.False(test.Mayo);
        }
        
        /// <summary>
        /// Should be able to add and remove Mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Mayo = true;
            Assert.True(test.Mayo);
        }

        /// <summary>
        /// BBQ is correctly applied
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToTrue()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.True(test.BBQ);
        }

        /// <summary>
        /// Should be able to add and remove BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.BBQ = false;
            Assert.False(test.BBQ);
        }

        /// <summary>
        /// Onion is correctly applied
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToTrue()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.True(test.Onion);
        }

        /// <summary>
        /// Should be able to add and remove onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Onion = false;
            Assert.False(test.Onion);
        }

        /// <summary>
        /// Tomato is correctly applied
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToFalse()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.False(test.Tomato);
        }

        /// <summary>
        /// Should be able to add and remove tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Tomato = true;
            Assert.True(test.Tomato);
        }

        /// <summary>
        /// Lettuce is correctly applied
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.False(test.Lettuce);
        }

        /// <summary>
        /// Should be able to add and remove lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Lettuce = true;
            Assert.True(test.Lettuce);
        }

        /// <summary>
        /// American Cheese is correctly applied
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.False(test.AmericanCheese);
        }

        /// <summary>
        /// Should be able to add and remove American Cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.AmericanCheese = true;
            Assert.True(test.AmericanCheese);
        }

        /// <summary>
        /// Swiss cheese is correctly applied
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToTrue()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.True(test.SwissCheese);
        }

        /// <summary>
        /// Should be able to add and remove swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.SwissCheese = false;
            Assert.False(test.SwissCheese);
        }

        /// <summary>
        /// Bacon is correctly applied
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.False(test.Bacon);
        }

        /// <summary>
        /// Should be able to add and remove Bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Bacon = true;
            Assert.True(test.Bacon);
        }

        /// <summary>
        /// Mushroom is correctly applied
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToTrue()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            Assert.True(test.Mushrooms);
        }

        /// <summary>
        /// Should be able to add and remove mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            DeinonychusDouble test = new DeinonychusDouble();
            test.Mushrooms = false;
            Assert.False(test.Mushrooms);
        }
    }
}
