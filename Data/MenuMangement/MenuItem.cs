using System;
using System.Collections.Generic;
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
    }
}
