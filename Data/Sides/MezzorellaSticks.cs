using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class that represents a customizable order of Mezzorella Sticks
    /// </summary>
    internal class MezzorellaSticks
    {
        /// <summary>
        /// Name of the the deep-fried mozzarella sticks
        /// </summary>
        public string Name { get { return $"{Size} Mezzorella Sticks"; } }

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
                    case ServingSize.Small: return 530;
                    case ServingSize.Medium: return 620;
                    case ServingSize.Large:
                    default: return 730;
                }
            }
        }
    }
}
