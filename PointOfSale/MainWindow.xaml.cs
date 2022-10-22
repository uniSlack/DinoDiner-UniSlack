using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using System;
using System.Collections.Generic;
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
using System.Collections.Specialized;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Holds the current itemCustomization menu
        /// </summary>
        private ItemCustomizationControl? itemCustomization { get; set; }

        /// <summary>
        /// used to insure unique order numbers
        /// </summary>
        private int _nextOrderNumber = 1;

        public MainWindow()
        {
            this.DataContext = new Order( _nextOrderNumber);
            _nextOrderNumber++;
            InitializeComponent();
            foreach (UIElement e in SelectionControl.MenuSelectionGrid.Children)
            {
                if (e is Button b)
                {
                    b.Click += this.OnClick;
                }
            }
            if(DataContext is Order dco)
            {
                dco.CollectionChanged += OrderSummary.UpdateOrderList;
                OrderSummary.DateTextBlock.Text = dco.PlacedAt.ToString();
                OrderSummary.OrderNameTextBlock.Text = $"Order #{dco.Number}";
                OrderSummary.OrderListView.SelectionChanged += OnListViewSelection;
            }
        }

        /// <summary>
        /// Called when the ordersummary list view selection changes, opening an itemcustomization screen for the select item
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        public void OnListViewSelection(object sender, EventArgs e) 
        {
            if(sender is ListView v)
            {
                if(v.SelectedItem is DinoDiner.Data.MenuMangement.MenuItem selectedItem)
                {
                    //closes any old itemCustomization menus
                    MainWindowGrid.Children.Remove(itemCustomization);
                    SelectionControl.Visibility = Visibility.Visible;

                    itemCustomization = new ItemCustomizationControl(selectedItem);
                    Grid.SetColumn(itemCustomization, 0);
                    Grid.SetColumnSpan(itemCustomization, 3);
                    MainWindowGrid.Children.Add(itemCustomization);
                    SelectionControl.Visibility = Visibility.Hidden;
                    itemCustomization.DataContext = selectedItem;
                }
            }
        }

        /// <summary>
        /// A click event primarily used for item selection buttons, in a WIP phase
        /// </summary>
        /// <param name="sender">button that was clicked on</param>
        /// <param name="e">event args</param>
        public void OnClick(object sender, EventArgs e)
        {
            if (sender is Button senderButton)
            {
                DinoDiner.Data.MenuMangement.MenuItem selectedItem = CreateMenuItemFromButton(senderButton);
                if(this.DataContext is Order dc)
                {
                    dc.Add(selectedItem);
                }
                itemCustomization = new ItemCustomizationControl(selectedItem);
                selectedItem.PropertyChanged += OrderSummary.UpdateOrderListFromProp;
                Grid.SetColumn(itemCustomization, 0);
                Grid.SetColumnSpan(itemCustomization, 3);
                MainWindowGrid.Children.Add(itemCustomization);
                SelectionControl.Visibility = Visibility.Hidden;
                itemCustomization.DataContext = selectedItem;
            }
        }

        /// <summary>
        /// A helper method to construct the corresponding menu item for each button
        /// </summary>
        /// <param name="b">button that was clicked on</param>
        /// <returns>menu item as an object</returns>
        private Data.MenuMangement.MenuItem CreateMenuItemFromButton(Button b)
        {
            ///TODO should probably add the item to a global list so that it can be displayed and tracked
            switch (b.Name)
            {
                case "PrehistroicPBJButton": return new PrehistoricPBJ();
                case "AllosaurusAllAmericanButton": return new AllosaurusAllAmericanBurger();
                case "CarnotaurusCheeseburgerButton": return new CarnotaurusCheeseburger();
                case "DeinonychusDoubleButton": return new DeinonychusDouble();
                case "TRexTripleButton": return new TRexTriple();
                case "DinoNuggetsButton": return new DinoNuggets();
                case "PterodactylWingsButton": return new PterodactylWings();
                case "VelociWraptorButton": return new VelociWraptor();
                case "FryceritopsButton": return new Fryceritops();
                case "MeteorMacAndCheeseButton": return new MeteorMacAndCheese();
                case "MezzorellaSticksButton": return new MezzorellaSticks();
                case "TriceritotsButton": return new Triceritots();
                case "BrontowurstButton": return new Brontowurst();
                case "PlilosodaButton": return new Plilosoda();
                case "CretaceousCoffeeButton": return new CretaceousCoffee();
                default:    throw new ArgumentException($"Button name: {b.Name}, was unknown in CreateMenuItemFromButton");
            }
        }

        /// <summary>
        /// A click event used on the add more items button to close the item selection menu 
        /// </summary>
        /// <param name="sender">sender button</param>
        /// <param name="e">event args</param>
        public void OnAddMoreItemsClick(object sender, EventArgs e)
        {
            if (sender is Button senderButton)
            {
                MainWindowGrid.Children.Remove(itemCustomization);
                SelectionControl.Visibility = Visibility.Visible;
            }
        }


        /// <summary>
        /// A click event used to cancel and create a new order
        /// </summary>
        /// <param name="sender">sender button</param>
        /// <param name="e">event args</param>
        public void OnCancelOrderClick(object sender, EventArgs e)
        {
            if (sender is Button senderButton)
            {
                Order dco = new Order(_nextOrderNumber);
                _nextOrderNumber++;
                this.DataContext = null; 
                this.DataContext = dco;

                //Should be static and only update with a new order
                OrderSummary.DateTextBlock.Text = dco.PlacedAt.ToString();
                OrderSummary.OrderNameTextBlock.Text = $"Order #{dco.Number}";
                dco.CollectionChanged += OrderSummary.UpdateOrderList;
                OrderSummary.UpdateOrderList(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }
    }
}
