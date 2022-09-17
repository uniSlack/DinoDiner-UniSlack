using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Carnotaurus Cheeseburger
    /// </summary>
    public class CarnotaurusCheeseburger : Burger
    {
        /// <summary>
        /// The name of the cheeseburger
        /// </summary>
        public override string Name { get { return "Carnoaurus Cheeseburger"; } }

        /// <summary>
        /// Constructs the Carnotaurus Cheeseburger
        /// </summary>
        public CarnotaurusCheeseburger()
        {
            Patties = 1;
            Tomato = true;
            Ketchup = true;
            Pickle = true;
            AmericanCheese = true;
        }
    }
}
