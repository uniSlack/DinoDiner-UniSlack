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
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Name of the the deep-fried mozzarella sticks
        /// </summary>
        public override string Name { get { return $"{Size} Mezzorella Sticks"; } }

        /// <summary>
        /// Price of the order based on the size
        /// </summary>
        public override uint Calories
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
