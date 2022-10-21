using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DinoDiner.Data.MenuMangement;
using System.Reflection;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class for all entrees sold at DinoDiner
    /// </summary>
    public abstract class Entree : MenuItem, INotifyPropertyChanged
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
                    //further logic to add "hold" or "add" to instructions
                    if(this.GetType().GetProperty(propertyName).GetValue(this) is bool value)
                    {
                        if(value) this.SpecialInstructions.Add($"Add {propertyName}");
                        else this.SpecialInstructions.Add($"Hold {propertyName}");

                    }
                }
            }
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
