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
    public class Triceritots : Side
    {
        /// <summary>
        /// Name of the the tater tots
        /// </summary>
        public override string Name { get { return $"{Size} Triceritots"; } }

        /// <summary>
        /// Price of the order based on the size
        /// </summary>
        public override uint Calories
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
