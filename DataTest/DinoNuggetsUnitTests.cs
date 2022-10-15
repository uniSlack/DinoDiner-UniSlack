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
    /// Test class for Dino Nuggets
    /// </summary>
    public class DinoNuggetsUnitTests
    {
        /// <summary>
        /// Inherits from base class Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            DinoNuggets test = new DinoNuggets();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        /// <param name="c">Count</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(0, "0 Dino Nuggets")]
        [InlineData(1, "1 Dino Nuggets")]
        [InlineData(2, "2 Dino Nuggets")]
        [InlineData(4, "4 Dino Nuggets")]
        [InlineData(400000, "400000 Dino Nuggets")]
        [InlineData(8, "8 Dino Nuggets")]
        [InlineData(9, "9 Dino Nuggets")]
        [InlineData(11, "11 Dino Nuggets")]
        public void NameShouldBeCorrect(uint c, string n)
        {
            DinoNuggets test = new DinoNuggets() { Count = c };
            Assert.Equal(n, test.Name);
        }

        /// <summary>
        /// Checks that the price is correct in all scenarios
        /// </summary>
        /// <param name="c">count</param>
        /// <param name="p">price</param>
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0.25)]
        [InlineData(2, 0.5)]
        [InlineData(4, 1.0)]
        [InlineData(400000, 100000.0)]
        [InlineData(8, 2.0)]
        [InlineData(9, 2.25)]
        [InlineData(11, 2.75)]
        public void PriceShouldBeCorrect(uint c, decimal p)
        {
            DinoNuggets test = new DinoNuggets() { Count = c };
            Assert.Equal(p, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct in all scenarios
        /// </summary>
        /// <param name="c">count</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(0, 0 * 61)]
        [InlineData(1, 1 * 61)]
        [InlineData(2, 2 * 61)]
        [InlineData(4, 4 * 61)]
        [InlineData(400000, 400000 * 61)]
        [InlineData(8, 8 * 61)]
        [InlineData(9, 9 * 61)]
        [InlineData(11, 11 * 61)]
        public void CaloriesShouldBeCorrect(uint c, uint cals)
        {
            DinoNuggets test = new DinoNuggets() { Count = c };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// The count of nuggest should start at 6
        /// </summary>
        [Fact]
        public void CountShouldDefaultToSix()
        {
            DinoNuggets test = new DinoNuggets();
            Assert.Equal((uint)6, test.Count);
        }

        /// <summary>
        /// Count should be able to chage
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCount()
        {
            DinoNuggets test = new DinoNuggets();
            test.Count = 8;
            Assert.Equal((uint)8, test.Count);
        }

        /// <summary>
        /// Checks that INotifyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            DinoNuggets test = new DinoNuggets();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }
    }
}
