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

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //TODO temp solution
        private ItemCustomizationControl? itemCustomization { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement e in SelectionControl.MenuSelectionGrid.Children)
            {
                if (e is Button b)
                {
                    b.Click += this.OnClick;
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
                itemCustomization = new ItemCustomizationControl(CreateMenuItemFromButton(senderButton));
                Grid.SetColumn(itemCustomization, 0);
                Grid.SetColumnSpan(itemCustomization, 3);
                MainWindowGrid.Children.Add(itemCustomization);
                SelectionControl.Visibility = Visibility.Hidden;
                itemCustomization.DataContext = new PrehistoricPBJ();
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
        /// A helper method to construct the corresponding menu item for each button
        /// </summary>
        /// <param name="b">button that was clicked on</param>
        /// <returns>menu item as an object</returns>
        private object CreateMenuItemFromButton(Button b)
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
    }
}
