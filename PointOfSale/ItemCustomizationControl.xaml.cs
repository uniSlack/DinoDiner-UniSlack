using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeCustomizationControl.xaml
    /// </summary>
    public partial class ItemCustomizationControl : UserControl
    {

        private int row = 1;
        private int col = 0;
        /// <summary>
        /// Intializes the ItemCustomizationControl, dynamically creates controls for a given object, checkboxes for bool properties and combo boxes for enum based properties
        /// </summary>
        public ItemCustomizationControl(dynamic customizedItem)
        {
            InitializeComponent();

            // To be set on an event call that creates this screen (or maybe data context?)
            //dynamic customizedItem = some input


            // For temp testing as events are not set up yet, just switch what is commented out to see examples.
            //dynamic customizedItem;
            //customizedItem = new AllosaurusAllAmericanBurger();
            //customizedItem = new Brontowurst();
            //customizedItem = new Fryceritops();
            //customizedItem = new Plilosoda();
            //customizedItem = new PterodactylWings();

            Type menuItemType = customizedItem.GetType();

            EntreeCustomizationNameTextBlock.Text = $"{customizedItem.Name} ({customizedItem.Calories} cals) [TEMP TILL BINDING]";

            PropertyInfo[] properties = menuItemType.GetProperties();
            
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(bool))
                {
                    CheckBox cb = new CheckBox();
                    cb.Content = property.Name;
                    cb.Name = $"{property.Name}CheckBox";
                    addToGrid(cb);
                }
            }
            if (customizedItem is Burger)
            {
                TextBlock pattiesLabel = new TextBlock();
                pattiesLabel.Text = "# of Patties:";
                ComboBox pattiesComboBox = new ComboBox();
                pattiesComboBox.ItemsSource = new int[5] { 0, 1, 3, 3, 4 };
                addToGrid(pattiesLabel);
                addToGrid(pattiesComboBox);
            }
            if (customizedItem is Side || customizedItem is Drink)
            {
                TextBlock sizeLabel = new TextBlock();
                sizeLabel.Text = "Size:";
                ComboBox sizeComboBox = new ComboBox();
                sizeComboBox.ItemsSource = new ServingSize[3] { ServingSize.Large, ServingSize.Medium, ServingSize.Small };
                addToGrid(sizeLabel);
                addToGrid(sizeComboBox);
            }
            if (customizedItem is Plilosoda)
            {
                TextBlock flavorLabel = new TextBlock();
                flavorLabel.Text = "Flavor:";
                ComboBox flavorComboBox = new ComboBox();
                EntreeCustomizationGrid.Children.Add(flavorComboBox);
                flavorComboBox.ItemsSource = new SodaFlavor[5] { SodaFlavor.CherryCola, SodaFlavor.Cola, SodaFlavor.DinoDew, SodaFlavor.DoctorDino, SodaFlavor.LemonLime };
                addToGrid(flavorLabel);
                addToGrid(flavorComboBox);
            }
            if (customizedItem is PterodactylWings)
            {
                TextBlock sauceLabel = new TextBlock();
                sauceLabel.Text = "Sauce:";
                ComboBox sauceComboBox = new ComboBox();
                sauceComboBox.ItemsSource = new WingSauce[3] { WingSauce.Buffalo, WingSauce.HoneyGlaze, WingSauce.Teriyaki };
                addToGrid(sauceLabel);
                addToGrid(sauceComboBox);
            }
        }


        /// <summary>
        /// A helper method to add a UIElement to the grid and update the apropriate parameters
        /// </summary>
        /// <param name="menuItem">The item to add</param>
        private void addToGrid(UIElement menuItem)//, int row, int col)
        {
            EntreeCustomizationGrid.Children.Add(menuItem);
            Grid.SetRow(menuItem, row);
            Grid.SetColumn(menuItem, col);
            row++;
            if (row > 8)
            {
                row = 1;
                col++;
            }
        }
    }
}
