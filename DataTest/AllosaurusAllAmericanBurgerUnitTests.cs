using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger() ;
            Assert.Equal("Allosaurus All-American Burger", test.Name);
        }

        /// <summary>
        /// Checks that the price is correct 
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.Equal(2.10m, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.Equal((uint)233, test.Calories);
        }

        /// <summary>
        /// Should start with 1 patty
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.Equal((uint)1, test.Patties);
        }

        /// <summary>
        /// Should be able to change the number of patties
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPatties()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Patties = 3;
            Assert.Equal((uint)3, test.Patties);
        }

        /// <summary>
        /// Ketchup is correctly applied
        /// </summary>
        [Fact] 
        public void KetchupShouldDefaultToTrue()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.True(test.Ketchup);
        }

        /// <summary>
        /// Should be able to add and remove ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Ketchup = false;
            Assert.False(test.Ketchup);
        }

        /// <summary>
        /// Mustard is correctly applied
        /// </summary>
        [Fact] 
        public void MustardShouldDefaultToTrue()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.True(test.Mustard);
        }

        /// <summary>
        /// Should be able to add and remove Mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Mustard = false;
            Assert.False(test.Mustard);
        }

        /// <summary>
        /// Pickle is correctly applied
        /// </summary>
        [Fact] 
        public void PickleShouldDefaultToTrue()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.True(test.Pickle);
        }

        /// <summary>
        /// Should be able to add and remove pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Pickle = false;
            Assert.False(test.Pickle);
        }

        /// <summary>
        /// Mayo is correctly applied
        /// </summary>
        [Fact] 
        public void MayoShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.Mayo);
        }
        
        /// <summary>
        /// Should be able to add and remove Mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Mayo = true;
            Assert.True(test.Mayo);
        }

        /// <summary>
        /// BBQ should not come with the burger
        /// </summary>
        [Fact] 
        public void BBQShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.BBQ);
        }

        /// <summary>
        /// Should be able to add and remove BBQ
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.BBQ = true;
            Assert.True(test.BBQ);
        }

        /// <summary>
        /// Onion is correctly applied
        /// </summary>
        [Fact] 
        public void OnionShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.Onion);
        }

        /// <summary>
        /// Should be able to add and remove onion
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Onion = true;
            Assert.True(test.Onion);
        }

        /// <summary>
        /// Tomato is correctly applied
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.Tomato);
        }

        /// <summary>
        /// Should be able to add and remove tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Tomato = true;
            Assert.True(test.Tomato);
        }

        /// <summary>
        /// Lettuce is correctly applied
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.Lettuce);
        }

        /// <summary>
        /// Should be able to add and remove lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Lettuce = true;
            Assert.True(test.Lettuce);
        }

        /// <summary>
        /// American Cheese is correctly applied
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.AmericanCheese);
        }

        /// <summary>
        /// Should be able to add and remove American Cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.AmericanCheese = true;
            Assert.True(test.AmericanCheese);
        }

        /// <summary>
        /// Swiss cheese is correctly applied
        /// </summary>
        [Fact] 
        public void SwissCheeseShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.SwissCheese);
        }

        /// <summary>
        /// Should be able to add and remove swiss cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.SwissCheese = true;
            Assert.True(test.SwissCheese);
        }

        /// <summary>
        /// Bacon is correctly applied
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.Bacon);
        }

        /// <summary>
        /// Should be able to add and remove Bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Bacon = true;
            Assert.True(test.Bacon);
        }

        /// <summary>
        /// Mushroom is correctly applied
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.False(test.Mushrooms);
        }

        /// <summary>
        /// Should be able to add and remove mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            test.Mushrooms = true;
            Assert.True(test.Mushrooms);
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
            AllosaurusAllAmericanBurger test = new AllosaurusAllAmericanBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }
    }
}
