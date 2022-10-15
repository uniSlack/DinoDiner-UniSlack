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

            Type menuItemType = customizedItem.GetType();


            Binding binding = new Binding("Name");
            binding.Source = customizedItem;
            BindingOperations.SetBinding(EntreeCustomizationNameTextBlock, TextBlock.TextProperty, binding);
            //EntreeCustomizationNameTextBlock.Text = $"{customizedItem.Name} ({customizedItem.Calories} cals) [TEMP TILL BINDING]";

            PropertyInfo[] properties = menuItemType.GetProperties();
            
            // Checks each property of the item and if the prop is a bool it generates a corresponding checkbox
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(bool))
                {
                    CheckBox cb = new CheckBox();
                    Binding b = new Binding(property.Name); // path parameter is the name of the data property we want to bind from
                    b.Source = customizedItem; // source is the object the bound property is from
                    cb.Content = property.Name; 
                    cb.Name = $"{property.Name}CheckBox";
                    BindingOperations.SetBinding(cb, CheckBox.IsCheckedProperty, b); // sets the object's property, isChecked, to binding b
                    addToGrid(cb);
                }
            }

            // Checks for non-bool properties that still need to be created
            if(customizedItem is DinoNuggets)
            {
                TextBlock nuggetsLabel = new TextBlock();
                nuggetsLabel.Text = "# of Nuggets:";
                ComboBox nuggetsComboBox = new ComboBox();

                Binding b = new Binding("Count");
                b.Source = customizedItem;
                BindingOperations.SetBinding(nuggetsComboBox, ComboBox.SelectedItemProperty, b);

                uint[] options = new uint[51];
                for (uint i = 0; i < 51; i++)
                {
                    options[i] = i;
                }
                nuggetsComboBox.ItemsSource = options;
                addToGrid(nuggetsLabel);
                addToGrid(nuggetsComboBox);
            }
            if (customizedItem is Burger)
            {
                TextBlock pattiesLabel = new TextBlock();
                pattiesLabel.Text = "# of Patties:";
                ComboBox pattiesComboBox = new ComboBox();

                Binding b = new Binding("Patties");
                b.Source = customizedItem;
                BindingOperations.SetBinding(pattiesComboBox, ComboBox.SelectedItemProperty, b);

                pattiesComboBox.ItemsSource = new int[5] { 0, 1, 2, 3, 4 };
                addToGrid(pattiesLabel);
                addToGrid(pattiesComboBox);
            }
            if (customizedItem is Side || customizedItem is Drink)
            {
                TextBlock sizeLabel = new TextBlock();
                sizeLabel.Text = "Size:";
                ComboBox sizeComboBox = new ComboBox();
                sizeComboBox.ItemsSource = new ServingSize[3] { ServingSize.Large, ServingSize.Medium, ServingSize.Small };

                Binding b = new Binding("Size");
                b.Source = customizedItem;
                BindingOperations.SetBinding(sizeComboBox, ComboBox.SelectedItemProperty, b);

                addToGrid(sizeLabel);
                addToGrid(sizeComboBox);
            }
            if (customizedItem is Plilosoda)
            {
                TextBlock flavorLabel = new TextBlock();
                flavorLabel.Text = "Flavor:";
                ComboBox flavorComboBox = new ComboBox();

                Binding b = new Binding("Flavor");
                b.Source = customizedItem;
                BindingOperations.SetBinding(flavorComboBox, ComboBox.SelectedItemProperty, b);

                flavorComboBox.ItemsSource = new SodaFlavor[5] { SodaFlavor.CherryCola, SodaFlavor.Cola, SodaFlavor.DinoDew, SodaFlavor.DoctorDino, SodaFlavor.LemonLime };
                addToGrid(flavorLabel);
                addToGrid(flavorComboBox);
            }
            if (customizedItem is PterodactylWings)
            {
                TextBlock sauceLabel = new TextBlock();
                sauceLabel.Text = "Sauce:";

                ComboBox sauceComboBox = new ComboBox();
                Binding b = new Binding("Sauce");
                b.Source = customizedItem;

                sauceComboBox.ItemsSource = new WingSauce[3] { WingSauce.Buffalo, WingSauce.HoneyGlaze, WingSauce.Teriyaki };
                BindingOperations.SetBinding(sauceComboBox, ComboBox.SelectedItemProperty, b);
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
