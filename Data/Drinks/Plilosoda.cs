using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// Class that represents a Plilosoda
    /// </summary>
    public class Plilosoda : Drink
    {
        /// <summary>
        /// The flavor of the Plilosoda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// A private method for sorting the SodaFlavor enum into a string with spaces for the name property
        /// </summary>
        /// <returns>the Flavor as a string with spaces</returns>
        private string FlavorString()
        {
            switch (Flavor)
            {
                case (SodaFlavor.Cola): return "Cola";
                case (SodaFlavor.CherryCola): return "Cherry Cola";
                case (SodaFlavor.DoctorDino): return "Doctor Dino";
                case (SodaFlavor.LemonLime): return "Lemon-Lime";
                case (SodaFlavor.DinoDew):
                default: return "Dino Dew";
            }
        }

        /// <summary>
        /// The name of the Pilosoda based on serving size and the flavor
        /// </summary>
        public override string Name { get { return $"{Size} {FlavorString()} Pilosoda"; } }

        /// <summary>
        /// Represents the cost of the soda, based on size
        /// </summary>
        public override decimal Price
        {
            get
            {
                switch (Size)
                {
                    case ServingSize.Small: return 1.00m;
                    case ServingSize.Medium: return 1.75m;
                    case ServingSize.Large:
                    default: return 2.50m;
                }
            }
        }

        /// <summary>
        /// Represents the calories in the soda, based on size and flavor
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size, Flavor)
                {
                    case (ServingSize.Small, SodaFlavor.Cola)       : return 180;
                    case (ServingSize.Small, SodaFlavor.CherryCola) : return 100;
                    case (ServingSize.Small, SodaFlavor.DoctorDino) : return 120;
                    case (ServingSize.Small, SodaFlavor.LemonLime)  : return 41;
                    case (ServingSize.Small, SodaFlavor.DinoDew)    : return 141;
                    case (ServingSize.Medium, SodaFlavor.Cola)          : return 288;
                    case (ServingSize.Medium, SodaFlavor.CherryCola)    : return 160;
                    case (ServingSize.Medium, SodaFlavor.DoctorDino)    : return 192;
                    case (ServingSize.Medium, SodaFlavor.LemonLime)     : return 66;
                    case (ServingSize.Medium, SodaFlavor.DinoDew)       : return 256;
                    case (ServingSize.Large, SodaFlavor.Cola)       : return 431;
                    case (ServingSize.Large, SodaFlavor.CherryCola) : return 240;
                    case (ServingSize.Large, SodaFlavor.DoctorDino) : return 288;
                    case (ServingSize.Large, SodaFlavor.LemonLime)  : return 98;
                    case (ServingSize.Large, SodaFlavor.DinoDew)    :
                    default: return 338;

                }
            }
        }
    }
}
