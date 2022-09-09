using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class that represents a customizable order of Fryceritops
    /// </summary>
    public class Fryceritops
    {
        /// <summary>
        /// Name of the French fries
        /// </summary>
        public string Name { get { return $"{Size} Fryceritops"; } }

        /// <summary>
        /// True if the Fryceritops have salt on them, defaults to true
        /// </summary>
        public bool Salt { get; set; } = true;

        /// <summary>
        /// True if the Fryceritops come with fry sauce, defaults to false
        /// </summary>
        public bool Sauce { get; set; } = false;

        /// <summary>
        /// Size of the order
        /// </summary>
        public ServingSize Size { get; set; }

        /// <summary>
        /// Price of the order based on the the size
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
                    default: return 5.00m;
                }
            }
        }

        /// <summary>
        /// Calories of the order based on the size and the sauce
        /// </summary>
        public uint Calories
        {
            get
            {
                uint tempCals;
                switch (Size)
                {
                    case ServingSize.Small: tempCals = 375; break;
                    case ServingSize.Medium: tempCals = 465; break;
                    case ServingSize.Large:
                    default: tempCals = 510; break;
                }
                if (Sauce) tempCals += 80;
                return tempCals;
            }
        }
    }
}
