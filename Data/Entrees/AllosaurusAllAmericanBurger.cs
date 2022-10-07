using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing an Allosaurus All-American Burger
    /// </summary>
    public class AllosaurusAllAmericanBurger : Burger
    {
        /// <summary>
        /// The name of the burger
        /// </summary>
        public override string Name { get { return "Allosaurus All-American Burger"; } }

        /// <summary>
        /// Constructs the Allosaurus All-American Burger
        /// </summary>
        public AllosaurusAllAmericanBurger()
        {
            Patties = 1;
            Ketchup = true;
            Mustard = true;
            Pickle = true;
        }
    }
}
