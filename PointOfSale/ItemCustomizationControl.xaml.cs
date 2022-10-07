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
        /// <summary>
        /// Intializes the ItemCustomizationControl, dynamically creates controls for a given object, checkboxes for bool properties and combo boxes for enum based properties
        /// </summary>
        public ItemCustomizationControl()
        {
            InitializeComponent();

            // To be set on an event call that creates this screen (or maybe data context?)
            //dynamic customizedItem = some input


            // For temp testing as events are not set up yet, just switch what is commented out to see examples.
            dynamic customizedItem;
            customizedItem = new AllosaurusAllAmericanBurger();
            //customizedItem = new Brontowurst();
            //customizedItem = new Fryceritops();
            //customizedItem = new Plilosoda();
            //customizedItem = new PterodactylWings();

            Type menuItemType = customizedItem.GetType();

            EntreeCustomizationNameTextBlock.Text = $"{customizedItem.Name} ({customizedItem.Calories} cals)";

            PropertyInfo[] properties = menuItemType.GetProperties();
            int row = 1;
            int col = 0;
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(bool))
                {
                    CheckBox cb = new CheckBox();
                    cb.Content = property.Name;
                    cb.Name = $"{property.Name}CheckBox";
                    EntreeCustomizationGrid.Children.Add(cb);
                    Grid.SetRow(cb, row);
                    Grid.SetColumn(cb, col);
                    row++;
                    if (row > 8)
                    {
                        row = 1;
                        col++;
                    }
                }
            }
            if (customizedItem is Burger)
            {
                ComboBox pattiesComboBox = new ComboBox();
                EntreeCustomizationGrid.Children.Add(pattiesComboBox);
                pattiesComboBox.ItemsSource = new int[5] { 0, 1, 3, 3, 4 };
                Grid.SetRow(pattiesComboBox, row);
                Grid.SetColumn(pattiesComboBox, col);
                row++;
                if (row > 8)
                {
                    row = 1;
                    col++;
                }
            }
            if (customizedItem is Side || customizedItem is Drink)
            {
                ComboBox sizeComboBox = new ComboBox();
                EntreeCustomizationGrid.Children.Add(sizeComboBox);
                sizeComboBox.ItemsSource = new ServingSize[3] { ServingSize.Large, ServingSize.Medium, ServingSize.Small };
                Grid.SetRow(sizeComboBox, row);
                Grid.SetColumn(sizeComboBox, col);
                row++;
                if (row > 8)
                {
                    row = 1;
                    col++;
                }
            }
            if (customizedItem is Plilosoda)
            {
                ComboBox flavorComboBox = new ComboBox();
                EntreeCustomizationGrid.Children.Add(flavorComboBox);
                flavorComboBox.ItemsSource = new SodaFlavor[5] { SodaFlavor.CherryCola, SodaFlavor.Cola, SodaFlavor.DinoDew, SodaFlavor.DoctorDino, SodaFlavor.LemonLime };
                Grid.SetRow(flavorComboBox, row);
                Grid.SetColumn(flavorComboBox, col);
                row++;
                if (row > 8)
                {
                    row = 1;
                    col++;
                }
            }
            if (customizedItem is PterodactylWings)
            {
                ComboBox sauceComboBox = new ComboBox();
                EntreeCustomizationGrid.Children.Add(sauceComboBox);
                sauceComboBox.ItemsSource = new WingSauce[3] { WingSauce.Buffalo, WingSauce.HoneyGlaze, WingSauce.Teriyaki };
                Grid.SetRow(sauceComboBox, row);
                Grid.SetColumn(sauceComboBox, col);
                row++;
                if (row > 8)
                {
                    row = 1;
                    col++;
                }
            }
        }
    }
}
