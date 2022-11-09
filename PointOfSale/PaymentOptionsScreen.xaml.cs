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
using RoundRegister;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        /// <summary>
        /// A private list of all the possible denominations of bills contatined in the register
        /// </summary>
        private List<uint> _bills = new List<uint>() {100, 50, 20, 10, 5, 2, 1};

        public PaymentOptionsScreen()
        {
            InitializeComponent();
            foreach(uint b in _bills)
            {
                CurrencyControl c = new CurrencyControl(b);
                PaymentScreenGrid.Children.Add(c);
                Grid.SetRow(c, _bills.IndexOf(b));
                Grid.SetColumn(c, 0);
            }    
        }
    }
}
