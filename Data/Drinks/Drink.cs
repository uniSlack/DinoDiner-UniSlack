using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A base class for all drinks
    /// </summary>
    public abstract class Drink: INotifyPropertyChanged
    {
        /// <summary>
        /// An event triggered when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// A helper method to allow inherited classes to access PropertyChanged
        /// </summary>
        /// <param name="propertyName">The exact name of the property that has changed</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Name of the drink
        /// </summary>
        public abstract string Name { get; }

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

        /// <summary>
        /// Price of the drink based on the size
        /// </summary>
        public abstract decimal Price { get; }
        
        /// <summary>
        /// The calories in the drink
        /// </summary>
        public abstract uint Calories { get; }
    }
}
