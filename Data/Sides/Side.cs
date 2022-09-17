using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// Base class for sides
    /// </summary>
    public abstract class Side
    { 
        /// <summary>
        /// Name of the side
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Size of the order
        /// </summary>
        public ServingSize Size { get; set; }

        /// <summary>
        /// Price of the side based on the size
        /// </summary>
        public virtual decimal Price
        {
            get
            {
                switch (Size)
                {
                    case ServingSize.Small: return 3.50m;
                    case ServingSize.Medium: return 4.00m;
                    case ServingSize.Large:
                    default: return 5.25m;
                }
            }
        }

        /// <summary>
        /// The calories in the side
        /// </summary>
        public abstract uint Calories { get; }
    }
}
