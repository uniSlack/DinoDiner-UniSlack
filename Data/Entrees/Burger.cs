using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class for burgers
    /// </summary>
    public abstract class Burger : Entree
    {
        /// <summary>
        /// How many patties are on the burger
        /// </summary>
        public uint Patties { get; set; }
        
        /// <summary>
        /// A bool that is true if the burger has Ketchup on it
        /// </summary>
        public bool Ketchup { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Mustard on it
        /// </summary>
        public bool Mustard { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Pickle on it
        /// </summary>
        public bool Pickle { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Mayo on it
        /// </summary>
        public bool Mayo { get; set; }

        /// <summary>
        /// A bool that is true if the burger has BBq on it
        /// </summary>
        public bool BBQ { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Onion on it
        /// </summary>
        public bool Onion { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Tomato on it
        /// </summary>
        public bool Tomato { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Lettuce on it
        /// </summary>
        public bool Lettuce { get; set; }

        /// <summary>
        /// A bool that is true if the burger has AmericanCheese on it
        /// </summary>
        public bool AmericanCheese { get; set; }

        /// <summary>
        /// A bool that is true if the burger has SwissCheese on it
        /// </summary>
        public bool SwissCheese { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Bacon on it
        /// </summary>
        public bool Bacon { get; set; }

        /// <summary>
        /// A bool that is true if the burger has Mushrooms on it
        /// </summary>
        public bool Mushrooms { get; set; }

        /// <summary>
        /// The price of the burger based on the toppings and number of patties
        /// </summary>
        public override decimal Price
        {
            get
            {
                decimal p = 1.50m * Patties;
                if (Ketchup) p += .20m;
                if (Mustard) p += .20m;
                if (Pickle) p += .20m;
                if (Mayo) p += .20m;
                if (BBQ) p += .10m;
                if (Onion) p += .40m;
                if (Tomato) p += .40m;
                if (Lettuce) p += .30m;
                if (AmericanCheese) p += .25m;
                if (SwissCheese) p += .25m;
                if (Bacon) p += .50m;
                if (Mushrooms) p += .40m;
                return p;
            }
        }

        /// <summary>
        /// The number of calories in the burger based on the the toppings and number of patties
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint c = 204 * Patties;
                if (Ketchup) c += 19;
                if (Mustard) c += 3;
                if (Pickle) c += 7;
                if (Mayo) c += 94;
                if (BBQ) c += 29;
                if (Onion) c += 44;
                if (Tomato) c += 22;
                if (Lettuce) c += 5;
                if (AmericanCheese) c += 104;
                if (SwissCheese) c += 106;
                if (Bacon) c += 43;
                if (Mushrooms) c += 4;
                return c;
            }
        }
    }
}
