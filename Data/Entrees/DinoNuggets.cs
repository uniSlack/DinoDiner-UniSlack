using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class represeting a customizable serving of Dino Nuggets
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Name of the chicken nuggets
        /// </summary>
        public string Name { get { return $"{Count} Dino Nuggets"; } }

        /// <summary>
        /// Count of the Dino Nuggets
        /// </summary>
        public uint Count { get; set; } = 6;

        /// <summary>
        /// Price of the Dino Nuggets calculated per nugget
        /// </summary>
        public decimal Price { get { return (Count * .25m); } }

        /// <summary>
        /// Calories in the Dino Nuggers calculated per nugget
        /// </summary>
        public uint Calories { get { return (Count * 61); } }
    }
}
