using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.MenuMangement;
using Microsoft.VisualBasic;

namespace DinoDiner.Data.MenuMangement
{
    /// <summary>
    /// A collection of MenuItems
    /// </summary>
    public class Order : ICollection, INotifyCollectionChanged, INotifyPropertyChanged//ObservableCollection<MenuItem>
    {
        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Notifies when the collection changes
        /// </summary>
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        /// <summary>
        /// Tells if the collection is synched
        /// </summary>
        bool ICollection.IsSynchronized { get { return false; } }

        /// <summary>
        /// Object for synchronization
        /// </summary>
        object ICollection.SyncRoot { get { return this; } }


        /// <summary>
        /// Copies this order to an array
        /// </summary>
        /// <param name="a">array to copy to</param>
        /// <param name="index">index to start pasting items to</param>
        void ICollection.CopyTo(Array a, int index)
        {
            foreach (MenuItem item in _orderItems)
            {
                a.SetValue(item, index);
                index++;
            }
        }

        /// <summary>
        /// Number of items in the order
        /// </summary>
        int ICollection.Count { get { return _orderItems.Count; } }

        //bool ICollection<MenuItem>.IsReadOnly { get; } = false;

        /// <summary>
        /// Gets the enumerator 
        /// </summary>
        /// <returns>a function</returns>
        public IEnumerator GetEnumerator()
        {
            return _orderItems.GetEnumerator();
        }

        /// <summary>
        /// gets the enumerator used for MenuItems
        /// </summary>
        /// <param name="test">an int</param>
        /// <returns>a function</returns>
        public IEnumerator<MenuItem> GetEnumerator(int test)
        {
            return _orderItems.GetEnumerator();
        }

        /// <summary>
        /// list of items in the order
        /// </summary>
        private List<MenuItem> _orderItems = new List<MenuItem>();

        /// <summary>
        /// Public list of the items in the order
        /// </summary>
        public List<MenuItem> OrderItems
        {
            get { return _orderItems; }
        }

        /// <summary>
        /// Adds a menu item to the collection
        /// </summary>
        /// <param name="item">item to add</param>
        public void Add(MenuItem item)
        {
            _orderItems.Add(item);
            this.CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Removes a menu item from the collection
        /// </summary>
        /// <param name="item">item to remove</param>
        /// <returns>true if the action passed</returns>
        public bool Remove(MenuItem item)
        {
            int index = _orderItems.IndexOf(item);
            _orderItems.Remove(item);
            this.CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            return true;
        }

        /// <summary>
        /// Sales tax percentage to be applied to the order
        /// </summary>
        public decimal SalesTaxRate { get; set; } = .09m;

        /// <summary>
        /// Total price of all items in the order, pre-tax
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal sum = 0;
                foreach (MenuItem item in this)
                {
                    sum += item.Price;
                }
                return sum;
            }
        }

        /// <summary>
        /// Total tax on the order
        /// </summary>
        public decimal Tax { get { return (Subtotal * SalesTaxRate); } }

        /// <summary>
        /// Total price of the order including tax
        /// </summary>
        public decimal Total { get { return Subtotal + Tax; } }

        /// <summary>
        /// Number of total calories in the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint sum = 0;
                foreach(MenuItem item in this)
                {
                    sum += item.Calories;
                }
                return sum;
            }
        }

        /// <summary>
        /// Unique number for the order to be identified by
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// The time the order was placed at
        /// </summary>
        public DateTime PlacedAt = DateTime.Now;

        public Order(int nextOrderNumber)
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }
    }
}
