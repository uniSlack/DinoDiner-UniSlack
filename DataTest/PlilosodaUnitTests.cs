using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    /// <summary>
    /// test class for the sodas
    /// </summary>
    public class PlilosodaUnitTests
    {
        /// <summary>
        /// Inherits from base class Drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Plilosoda test = new Plilosoda();
            Assert.IsAssignableFrom<Drink>(test);
        }

        /// <summary>
        /// Checks that the name is correct
        /// </summary>
        /// <param name="s">size</param>
        /// <param name="f">flavor</param>
        /// <param name="n">name</param>
        [Theory]
        [InlineData(ServingSize.Small, SodaFlavor.CherryCola, "Small Cherry Cola Plilosoda")]
        [InlineData(ServingSize.Small, SodaFlavor.Cola, "Small Cola Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.DinoDew, "Medium Dino Dew Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.DoctorDino, "Medium Doctor Dino Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.LemonLime, "Large Lemon-Lime Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.CherryCola, "Large Cherry Cola Plilosoda")]
        public void NameShouldBeCorrect(ServingSize s, SodaFlavor f, string n)
        {
            Plilosoda test = new Plilosoda() { Size = s, Flavor = f };
            Assert.Equal(n, test.Name);
        }

        /// <summary>
        /// Checks that the price is correct
        /// </summary>
        /// <param name="s">size</param>
        /// <param name="f">flavor</param>
        /// <param name="p">price</param>
        [Theory]
        [InlineData(ServingSize.Small, SodaFlavor.CherryCola, 1.0)]
        [InlineData(ServingSize.Small, SodaFlavor.Cola, 1.0)]
        [InlineData(ServingSize.Medium, SodaFlavor.DinoDew, 1.75)]
        [InlineData(ServingSize.Medium, SodaFlavor.DoctorDino, 1.75)]
        [InlineData(ServingSize.Large, SodaFlavor.LemonLime, 2.50)]
        [InlineData(ServingSize.Large, SodaFlavor.CherryCola, 2.50)]
        public void PriceShouldBeCorrect(ServingSize s, SodaFlavor f,  decimal p)
        {
            Plilosoda test = new Plilosoda() { Size = s, Flavor = f };
            Assert.Equal(p, test.Price);
        }

        /// <summary>
        /// Checks that calories are correct
        /// </summary>
        /// <param name="s">serving size</param>
        /// <param name="f">flavor</param>
        /// <param name="cals">calories</param>
        [Theory]
        [InlineData(ServingSize.Small, SodaFlavor.CherryCola, 100)]
        [InlineData(ServingSize.Small, SodaFlavor.Cola, 180)]
        [InlineData(ServingSize.Medium, SodaFlavor.DinoDew, 256)]
        [InlineData(ServingSize.Medium, SodaFlavor.DoctorDino, 192)]
        [InlineData(ServingSize.Large, SodaFlavor.LemonLime, 98)]
        [InlineData(ServingSize.Large, SodaFlavor.CherryCola, 240)]
        public void CaloriesShouldBeCorrect(ServingSize s, SodaFlavor f, uint cals)
        {
            Plilosoda test = new Plilosoda() { Size = s, Flavor = f };
            Assert.Equal(cals, test.Calories);
        }

        /// <summary>
        /// Checks that the serving size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Plilosoda test = new Plilosoda();
            test.Size = ServingSize.Large;
            Assert.Equal(ServingSize.Large, test.Size);
        }

        /// <summary>
        /// Checks that the flavor can be changed
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Plilosoda test = new Plilosoda();
            test.Flavor = SodaFlavor.DinoDew;
            Assert.Equal(SodaFlavor.DinoDew, test.Flavor);
        }

        /// <summary>
        /// Checks that INotifyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            Plilosoda test = new Plilosoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }
    }
}
