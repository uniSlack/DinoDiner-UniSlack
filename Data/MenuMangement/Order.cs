using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.MenuItems;
using DinoDiner.Data.MenuMangement;
using Microsoft.VisualBasic;

namespace DinoDiner.Data.MenuMangement
{
    /// <summary>
    /// A collection of MenuItems
    /// </summary>
    public class Order : ICollection<MenuItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Notifies when the collection changes
        /// </summary>
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        void ICollection<MenuItem>.Clear()
        {
            foreach(MenuItem item in _order)
            {
                _order.Remove(item);
            }
        }

        /// <summary>
        /// Checks for an item in the collection
        /// </summary>
        /// <param name="item">item to look for</param>
        /// <returns>true if the item was found</returns>
        bool ICollection<MenuItem>.Contains(MenuItem item)
        {
            if (_order.Contains(item))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Copies this order to a menu item array
        /// </summary>
        /// <param name="a">array to copy to</param>
        /// <param name="index">index to start pasting items to</param>
        void ICollection<MenuItem>.CopyTo(MenuItem[] a, int index)
        {
            //for (; index < _order.Count(); index++)
            foreach(MenuItem item in _order)
            {
                a.SetValue(item, index);
                index++;
            }
        }

        /// <summary>
        /// Number of items in the order
        /// </summary>
        int ICollection<MenuItem>.Count { get { return _order.Count; } }

        bool ICollection<MenuItem>.IsReadOnly { get; } = false;

        void ICollection<MenuItem>.GetEnumerator(MenuItem item)
        {

        }









        /// <summary>
        /// list of items in the order
        /// </summary>
        private List<MenuItem> _order = null;

        /// <summary>
        /// Adds a menu item to the collection
        /// </summary>
        /// <param name="item">item to add</param>
        public void Add(MenuItem item)
        {
            _order.Add(item);
        }

        /// <summary>
        /// Removes a menu item from the collection
        /// </summary>
        /// <param name="item">item to remove</param>
        public bool Remove(MenuItem item)
        {
            _order.Remove(item);
            return true;
        }

        /// <summary>
        /// Sales tax percentage to be applied to the order
        /// </summary>
        public decimal SalesTaxRate { get; set; } = .09m; 
        
        /// <summary>
        /// Total price of all items in the order, pre-tax
        /// </summary>
        public decimal Subtotal { get; }

        /// <summary>
        /// Total tax on the order
        /// </summary>
        public decimal Tax { get { return (Subtotal * SalesTaxRate); } }

        /// <summary>
        /// Total price of the order including tax
        /// </summary>
        public decimal Total { get { return Subtotal + Tax; } }

        /// <summary>
        /// used to insure unique order numbers
        /// </summary>
        private int _nextOrderNumber = 1;

        /// <summary>
        /// Unique number for the order to be identified by
        /// </summary>
        public int Number { get; }

        public Order()
        {
            Number = _nextOrderNumber;
            _nextOrderNumber++;
        }

        /// <summary>
        /// The time the order was placed at
        /// </summary>
        public DateTime PlacedAt = DateTime.Now;
    }
}
