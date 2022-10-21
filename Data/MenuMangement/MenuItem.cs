using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.MenuMangement
{
    /// <summary>
    /// A base class for every Menu Item
    /// </summary>
    public abstract class MenuItem
    {
        /// <summary>
        /// The name of the item
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The price of the item
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Any special insturctions for a menu item, nullable
        /// </summary>
        public ICollection<String> SpecialInstructions { get; set; } = new List<String>();

        /// <summary>
        /// Gives the name of the object
        /// </summary>
        /// <returns>the name</returns>
        public override string ToString()
        {
            return Name;
        }

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
                if (this.GetType().GetProperty(propertyName).GetValue(this) is bool value)
                {
                    if (value)
                    {
                        if (this.SpecialInstructions.Contains($"Hold {propertyName}"))          SpecialInstructions.Remove($"Hold {propertyName}"); //removes any holds
                        if (!this.SpecialInstructions.Contains($"Add {propertyName}"))          SpecialInstructions.Add($"Add {propertyName}");     //new add if no duplicates
                    }
                    else
                    {
                        if (this.SpecialInstructions.Contains($"Add {propertyName}"))   SpecialInstructions.Remove($"Add {propertyName}");        //removes any adds
                        if (!this.SpecialInstructions.Contains($"Hold {propertyName}")) SpecialInstructions.Add($"Hold {propertyName}");      //new hold if no duplicates
                    }
                }
            }
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
