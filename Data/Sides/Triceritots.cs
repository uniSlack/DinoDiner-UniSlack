using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class that represents a customizable order of Triceritots
    /// </summary>
    internal class Triceritots
    {
        /// <summary>
        /// Name of the the tater tots
        /// </summary>
        public string Name { get { return $"{Size} Triceritots"; } }

        /// <summary>
        /// Size of the order
        /// </summary>
        public ServingSize Size { get; set; }

        /// <summary>
        /// Price of the order based on the size
        /// </summary>
        public decimal Price
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
        /// Price of the order based on the size
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case ServingSize.Small: return 351;
                    case ServingSize.Medium: return 409;
                    case ServingSize.Large:
                    default: return 583;
                }
            }
        }
    }
}
