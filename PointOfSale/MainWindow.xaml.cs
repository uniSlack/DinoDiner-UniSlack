using DinoDiner.Data.Entrees;
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
                ItemCustomizationControl itemCustomization = new ItemCustomizationControl(new AllosaurusAllAmericanBurger());
                Grid.SetColumn(itemCustomization, 0);
                Grid.SetColumnSpan(itemCustomization, 3);
                MainWindowGrid.Children.Add(itemCustomization);
                SelectionControl.Visibility = Visibility.Hidden;
            }
        }
    }
}
