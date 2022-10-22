using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.MenuMangement;

namespace DataTest
{
    /// <summary>
    /// Tests for the collection class Order.cs
    /// </summary>
    public class OrderUnitTests
    {
        /// <summary>
        /// Test that an item is actually added
        /// </summary>
        [Fact]
        public void AddingItemsWorks()
        {
            var test = new Order(0);
            Brontowurst b = new Brontowurst();
            test.Add(b);
            Assert.Equal(b, test.OrderItems[0]);
        }

        /// <summary>
        /// Test that an item is removed when Remove is called
        /// </summary>
        [Fact]
        public void RemovingItemsWorks()
        {
            var test = new Order(0);
            Brontowurst b = new Brontowurst();
            test.Add(b);
            Assert.Equal(b, test.OrderItems[0]);
            test.Remove(b);
            Assert.Empty(test);
        }

        /// <summary>
        /// Checks that INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Order test = new Order(0);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(test);
        }

        /// <summary>
        /// Checks that INotifyCollectionChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            Order test = new Order(0);
            Assert.IsAssignableFrom<INotifyCollectionChanged>(test);
        }

        [Fact]
        public void ShouldFireCollectionChangedWhenAdd()
        {
            var test = new Order(0);
            Assert.PropertyChanged(test, "Subtotal", () =>
            {
                test.Add(new Brontowurst());
            });
            Assert.PropertyChanged(test, "Total", () =>
            {
                test.Add(new Brontowurst());
            });
            Assert.PropertyChanged(test, "Tax", () =>
            {
                test.Add(new Brontowurst());
            });
            Assert.PropertyChanged(test, "Calories", () =>
            {
                test.Add(new Brontowurst());
            });
        }
    }
}
