using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A base class for all drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Name of the drink
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Size of the order
        /// </summary>
        public ServingSize Size { get; set; }

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
