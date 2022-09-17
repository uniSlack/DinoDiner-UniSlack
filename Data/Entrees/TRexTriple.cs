using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a burger with three patties
    /// </summary>
    public class TRexTriple : Burger
    {
        /// <summary>
        /// The name of the Burger
        /// </summary>
        public override string Name { get { return "T-Rex Triple"; }  }

        /// <summary>
        /// Constructs the T-Rex Triple
        /// </summary>
        TRexTriple()
        {
            Patties = 3;
            Ketchup = true;
            Mayo = true;
            Pickle = true;
            Onion = true;
            Lettuce = true;
            Tomato = true;
        }
    }
}
