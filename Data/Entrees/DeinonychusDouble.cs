using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Deinonychus Double 
    /// </summary>
    public class DeinonychusDouble : Burger
    {
        /// <summary>
        /// Name of the double cheeseburger
        /// </summary>
        public override string Name { get { return "Deinonychus Double"; } }

        /// <summary>
        /// Constructs the Deinonychus Double
        /// </summary>
        public DeinonychusDouble()
        {
            Patties = 2;
            BBQ = true;
            Pickle = true;
            Onion = true;
            Mushrooms = true;
            SwissCheese = true;
        }
    }
}
