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
        /// An event triggered when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// A helper method to allow inherited classes to access PropertyChanged
        /// </summary>
        /// <param name="propertyName">The exact name of the property that has changed</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (propertyName != "Price" && propertyName != "Calories" && propertyName != "Name")
            {
                if (!this.SpecialInstructions.Contains(propertyName))
                {
                    //further logic to add "Hold" or "Add" to instructions
                    if (this.GetType().GetProperty(propertyName).GetValue(this) is bool value)
                    {
                        if (value) this.SpecialInstructions.Add($"Add {propertyName}");
                        else this.SpecialInstructions.Add($"Hold {propertyName}");

                    }
                }
            }
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
