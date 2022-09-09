using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a customizable brautwurst with fried peppers and onions served in a bun 
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// The name of the brautwurst
        /// </summary>
        public string Name { get; } = "Brontowurst";

        /// <summary>
        /// Price of the Brontowurst
        /// </summary>
        public decimal Price { get; } = 5.86m;

        /// <summary>
        /// The number of calories in the Brontowurst
        /// </summary>
        public uint Calories { get; } = 512;

        /// <summary>
        /// True if the Brontowurst has onions, defaulted to true
        /// </summary>
        public bool Onions { get; set; } = true;

        /// <summary>
        /// True if the Brontowurst has peppers, defaulted to true
        /// </summary>
        public bool Peppers { get; set; } = true;
    }
}
