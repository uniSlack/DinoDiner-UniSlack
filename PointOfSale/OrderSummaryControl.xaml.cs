using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Data.MenuMangement;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
            OrderListView.FontSize = 12;
        }

        /// <summary>
        /// Called when the collection changes, used to update the OrderListView
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        public void UpdateOrderList(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(DataContext is Order dco)
            {
                OrderListView.ItemsSource = null; //forces list to update, it would not before
                OrderListView.ItemsSource = dco.OrderItems;
                
            }
        }

        /// <summary>
        /// Called when a property of the collectiong changes, used to update the OrderListView
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        public void UpdateOrderListFromProp(object sender, PropertyChangedEventArgs e)
        {
            if (DataContext is Order dco)
            {
                OrderListView.ItemsSource = null; //forces list to update, it would not before
                OrderListView.ItemsSource = dco.OrderItems;
            }
        }
        
        /// <summary>
        /// Removes the selected item from the order
        /// </summary>
        /// <param name="sender">sender object, should be list view</param>
        /// <param name="e">Event args</param>
        public void RemoveSelectedItem(object sender, EventArgs e)
        {
            if (sender is Button b && b.Name == "RemoveItemButton")
            {
                if(this.DataContext is Order o)
                {
                    if (OrderListView.SelectedItem is DinoDiner.Data.MenuMangement.MenuItem item)
                    {
                        o.Remove(item);
                    }
                }
            }
        }
    }
}
