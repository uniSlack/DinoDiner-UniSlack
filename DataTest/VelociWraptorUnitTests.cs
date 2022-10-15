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
    /// Test class for velociwraptors
    /// </summary>
    public class VelociWraptorUnitTests
    {
        /// <summary>
        /// Inherits from base class Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            VelociWraptor test = new VelociWraptor();
            Assert.IsAssignableFrom<Entree>(test);
        }

        /// <summary>
        /// Checks that the name is correct in all scenarios
        /// </summary>
        [Fact]
        public void NameShouldBeCorrect()
        {
            VelociWraptor test = new VelociWraptor();
            Assert.Equal("Veloci-Wraptor", test.Name);
        }

        /// <summary>
        /// Checks that the price is correct in all scenarios
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            VelociWraptor test = new VelociWraptor();
            Assert.Equal(6.25m, test.Price);
        }


        /// <summary>
        /// Checks that the calories are correct in all scenarios
        /// </summary>
        /// <param name="d">dressing</param>
        /// <param name="c">cheese</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(true, true, 732)]
        [InlineData(false, true, 732 - 94)]
        [InlineData(false, false, 732 - 94 - 22)]
        [InlineData(true, false, 732 - 22)]
        public void CaloriesShouldBeCorrect(bool d, bool c, uint cals)
        {
            VelociWraptor test = new VelociWraptor() { Dressing = d, Cheese = c };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// dressing should come with the wrap
        /// </summary>
        [Fact]
        public void DressingShouldDefaultToTrue()
        {
            VelociWraptor test = new VelociWraptor();
            Assert.True(test.Dressing);
        }

        /// <summary>
        /// should be able removed dressing from the order
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDressing()
        {
            VelociWraptor test = new VelociWraptor();
            test.Dressing = false;
            Assert.False(test.Dressing);
        }

        /// <summary>
        /// Cheese should come on the wrap
        /// </summary>
        /// [Fact]
        public void CheeseShouldDefaultToTrue()
        {
            VelociWraptor test = new VelociWraptor();
            Assert.True(test.Cheese);
        }

        /// <summary>
        /// Should be able to remove cheese from the order
        /// </summary>
        /// [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            VelociWraptor test = new VelociWraptor();
            test.Cheese = false;
            Assert.False(test.Cheese);
        }

        /// <summary>
        /// Checks that INotifyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            VelociWraptor test = new VelociWraptor();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }
    }
}
