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

        bool ICollection.IsSynchronized { get { return false; } }
        object ICollection.SyncRoot { get { return this; } }

        //void ICollection.Clear()
        //{
        //    foreach (MenuItem item in _order)
        //    {
        //        _order.Remove(item);
        //    }
        //}

        /// <summary>
        /// Checks for an item in the collection
        /// </summary>
        /// <param name="item">item to look for</param>
        /// <returns>true if the item was found</returns>
        //bool ICollection<MenuItem>.Contains(MenuItem item)
        //{
        //    if (_order.Contains(item))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

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

        public IEnumerator GetEnumerator()
        {
            return _orderItems.GetEnumerator();
        }

        public IEnumerator<MenuItem> GetEnumerator(int test)
        {
            return _orderItems.GetEnumerator();
        }

        /// <summary>
        /// list of items in the order
        /// </summary>
        private List<MenuItem> _orderItems = new List<MenuItem>();

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
            this.CollectionChanged?.Invoke(this, NotifyCollectionChangedEventArgs(OrderItems));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Removes a menu item from the collection
        /// </summary>
        /// <param name="item">item to remove</param>
        public bool Remove(MenuItem item)
        {
            _orderItems.Remove(item);
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
        /// used to insure unique order numbers
        /// </summary>
        private int _nextOrderNumber = 1;

        /// <summary>
        /// Unique number for the order to be identified by
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// The time the order was placed at
        /// </summary>
        public DateTime PlacedAt = DateTime.Now;

        public Order()
        {
            Number = _nextOrderNumber;
            _nextOrderNumber++;
            //this.CollectionChanged += CollectionChangedHelper;
            //this.PropertyChanged += PropertyChangedHelper;
        }

        ///// <summary>
        ///// A helper method to send out propety changed events when the inherited CollectionChanged Event fires
        ///// </summary>
        ///// <param name="sender">object that raised the event</param>
        ///// <param name="e">event args</param>
        //protected virtual void CollectionChangedHelper(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        //}

        ///// <summary>
        ///// A helper method to send out propety changed events when the inherited PropertyChanged Event fires
        ///// </summary>
        ///// <param name="sender">object that raised the event</param>
        ///// <param name="e">event args</param>
        ////protected virtual void PropertyChangedHelper(object sender, PropertyChangedEventArgs e)
        ////{
        ////    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        ////    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
        ////    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        ////    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        ////}


        ///// <summary>
        ///// An event triggered when a property is changed
        ///// </summary>
        //protected override event PropertyChangedEventHandler PropertyChanged;

        /////// <summary>
        /////// A helper method to allow inherited classes to access PropertyChanged
        /////// </summary>
        /////// <param name="propertyName">The exact name of the property that has changed</param>
        ////protected virtual void OnPropertyChanged(string propertyName)
        ////{
        ////    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        ////}
    }
}

public class Enumerator : IEnumerator
{
    private List<MenuItem> o;
    private int Cursor;

    public Enumerator(List<MenuItem> order)
    {
        this.o = order;
        Cursor = -1;
    }

    void IEnumerator.Reset()
    {
        Cursor = -1;
    }
    bool IEnumerator.MoveNext()
    {
        if (Cursor < o.Count)
            Cursor++;

        return (!(Cursor == o.Count));
    }
    object IEnumerator.Current
    {
        get
        {
            if ((Cursor < 0) || (Cursor == o.Count))
                throw new InvalidOperationException();
            return o[Cursor];
        }
    }
}
