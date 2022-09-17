using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class representing a customizable order of Meteor Mac and Cheese
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// Name of the the Mac and Cheese
        /// </summary>
        public override string Name { get { return $"{Size} Meteor Mac & Cheese"; } }

        /// <summary>
        /// Price of the order based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case ServingSize.Small: return 425;
                    case ServingSize.Medium: return 510;
                    case ServingSize.Large:
                    default: return 700;
                }
            }
        }
    }
}
