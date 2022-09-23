using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// Test class for the trex triple
    /// </summary>
    public class TRexTripleUnitTests
    {
        /// <summary>
        /// Inherits from base class Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            TRexTriple test = new TRexTriple();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            TRexTriple test = new TRexTriple();
            Assert.Equal("T-Rex Triple", test.Name);
        }

        /// <summary>
        /// Checks that the price is correct 
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            TRexTriple test = new TRexTriple();
            Assert.Equal(6.20m, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            TRexTriple test = new TRexTriple();
            Assert.Equal((uint)803, test.Calories);
        }

        /// <summary>
        /// Should start with 1 patty
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToThree()
        {
            TRexTriple test = new TRexTriple();
            Assert.Equal((uint)3, test.Patties);
        }

        /// <summary>
        /// Should be able to change the number of patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            TRexTriple test = new TRexTriple();
            test.Patties = 10;
            Assert.Equal((uint)10, test.Patties);
        }

        /// <summary>
        /// Ketchup is correctly applied
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            TRexTriple test = new TRexTriple();
            Assert.True(test.Ketchup);
        }

        /// <summary>
        /// Should be able to add and remove ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            TRexTriple test = new TRexTriple();
            test.Ketchup = false;
            Assert.False(test.Ketchup);
        }

        /// <summary>
        /// Mustard is correctly applied
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            TRexTriple test = new TRexTriple();
            Assert.False(test.Mustard);
        }

        /// <summary>
        /// Should be able to add and remove Mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            TRexTriple test = new TRexTriple();
            test.Mustard = true;
            Assert.True(test.Mustard);
        }

        /// <summary>
        /// Pickle is correctly applied
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            TRexTriple test = new TRexTriple();
            Assert.True(test.Pickle);
        }

        /// <summary>
        /// Should be able to add and remove pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            TRexTriple test = new TRexTriple();
            test.Pickle = false;
            Assert.False(test.Pickle);
        }

        /// <summary>
        /// Mayo is correctly applied
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToTrue()
        {
            TRexTriple test = new TRexTriple();
            Assert.True(test.Mayo);
        }
        
        /// <summary>
        /// Should be able to add and remove Mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            TRexTriple test = new TRexTriple();
            test.Mayo = false;
            Assert.False(test.Mayo);
        }

        /// <summary>
        /// BBQ is correctly applied
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            TRexTriple test = new TRexTriple();
            Assert.False(test.BBQ);
        }

        /// <summary>
        /// Should be able to add and remove BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            TRexTriple test = new TRexTriple();
            test.BBQ = true;
            Assert.True(test.BBQ);
        }

        /// <summary>
        /// Onion is correctly applied
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToTrue()
        {
            TRexTriple test = new TRexTriple();
            Assert.True(test.Onion);
        }

        /// <summary>
        /// Should be able to add and remove onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            TRexTriple test = new TRexTriple();
            test.Onion = false;
            Assert.False(test.Onion);
        }

        /// <summary>
        /// Tomato is correctly applied
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToTrue()
        {
            TRexTriple test = new TRexTriple();
            Assert.True(test.Tomato);
        }

        /// <summary>
        /// Should be able to add and remove tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            TRexTriple test = new TRexTriple();
            test.Tomato = false;
            Assert.False(test.Tomato);
        }

        /// <summary>
        /// Lettuce is correctly applied
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToTrue()
        {
            TRexTriple test = new TRexTriple();
            Assert.True(test.Lettuce);
        }

        /// <summary>
        /// Should be able to add and remove lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            TRexTriple test = new TRexTriple();
            test.Lettuce = false;
            Assert.False(test.Lettuce);
        }

        /// <summary>
        /// American Cheese is correctly applied
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            TRexTriple test = new TRexTriple();
            Assert.False(test.AmericanCheese);
        }

        /// <summary>
        /// Should be able to add and remove American Cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            TRexTriple test = new TRexTriple();
            test.AmericanCheese = true;
            Assert.True(test.AmericanCheese);
        }

        /// <summary>
        /// Swiss cheese is correctly applied
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            TRexTriple test = new TRexTriple();
            Assert.False(test.SwissCheese);
        }

        /// <summary>
        /// Should be able to add and remove swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            TRexTriple test = new TRexTriple();
            test.SwissCheese = true;
            Assert.True(test.SwissCheese);
        }

        /// <summary>
        /// Bacon is correctly applied
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            TRexTriple test = new TRexTriple();
            Assert.False(test.Bacon);
        }

        /// <summary>
        /// Should be able to add and remove Bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            TRexTriple test = new TRexTriple();
            test.Bacon = true;
            Assert.True(test.Bacon);
        }

        /// <summary>
        /// Mushroom is correctly applied
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            TRexTriple test = new TRexTriple();
            Assert.False(test.Mushrooms);
        }

        /// <summary>
        /// Should be able to add and remove mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            TRexTriple test = new TRexTriple();
            test.Mushrooms = true;
            Assert.True(test.Mushrooms);
        }
    }
}
