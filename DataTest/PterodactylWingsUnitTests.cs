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
    /// Testing class for Pterodactyl Wings
    /// </summary>
    public class PterodactylWingsUnitTests
    {
        /// <summary>
        /// Inherits from base class Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            PterodactylWings test = new PterodactylWings();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        /// <param name="s">Sauce</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, "Buffalo Pterodactyl Wings")]
        [InlineData(WingSauce.HoneyGlaze, "Honey Glazed Pterodactyl Wings")]
        [InlineData(WingSauce.Teriyaki, "Teriyaki Pterodactyl Wings")]
        public void NameShouldBeCorrect(WingSauce s, string n)
        {
            PterodactylWings test = new PterodactylWings() { Sauce = s };
            Assert.Equal(n, test.Name);
        }

        /// <summary>
        /// Checks that the price is correct in all scenarios
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            PterodactylWings test = new PterodactylWings();
            Assert.Equal(8.95m, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct in all scenarios
        /// </summary>
        /// <param name="s">sauce</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, 360)]
        [InlineData(WingSauce.Teriyaki, 342)]
        [InlineData(WingSauce.HoneyGlaze, 359)]
        public void CaloriesShouldBeCorrect(WingSauce s, uint cals)
        {
            PterodactylWings test = new PterodactylWings() { Sauce = s };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// Checks that the wings should start with buffalo sauce
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToBuffalo()
        {
            PterodactylWings test = new PterodactylWings();
            Assert.Equal(WingSauce.Buffalo, test.Sauce);
        }

        /// <summary>
        /// Checks that sauce should be able to change
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()
        {
            PterodactylWings test = new PterodactylWings();
            test.Sauce = WingSauce.HoneyGlaze;
            Assert.Equal(WingSauce.HoneyGlaze, test.Sauce);
        }

        /// <summary>
        /// Checks that INotifyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            PterodactylWings test = new PterodactylWings();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }
    }
}
