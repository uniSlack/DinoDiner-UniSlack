using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            //DataContext.Event += function to update list?
            InitializeComponent();
            OrderListView.FontSize = 12;
            //if (DataContext is Order dco)
            //{
            //    DateTextBlock.Text = dco.PlacedAt.ToString();
            //}
        }

        /// <summary>
        /// Called when the collection changes, used to update the OrderListView
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        public void UpdateOrderList(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Binding b = new Binding("OrderItems");
            //BindingOperations.SetBinding(OrderListView, ListView.ItemsSourceProperty, b);
            if(DataContext is Order dco)
            {
                OrderListView.ItemsSource = null; //forces list to update, it would not before
                //List<string> formattedSummary = new List<string>();
                //foreach(Data.MenuMangement.MenuItem item in dco.OrderItems)
                //{
                    
                //}
                OrderListView.ItemsSource = dco.OrderItems;
                //TODO clean this up, its a bit of a bandaid solution
            }
        }
    }
}
