using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DinoDiner.Data.MenuMangement;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A base class for all drinks
    /// </summary>
    public abstract class Drink: MenuItem, INotifyPropertyChanged
    {
        

        /// <summary>
        /// backing var
        /// </summary>
        private ServingSize _size;
        /// <summary>
        /// Size of the order
        /// </summary>
        public ServingSize Size
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("Name");
            }
        }
    }
}
