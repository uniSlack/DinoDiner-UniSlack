using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a customizable serving of Pterodactyl Wings
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Name of the Chicken Wings
        /// </summary>
        public override string Name { get {if(Sauce == WingSauce.HoneyGlaze) { return "Honey Glazed Pterodactyl Wings"; } ; return $"{Sauce} Pterodactyl Wings"; } }

        /// <summary>
        /// Sauce on the Pterodactyl Wings
        /// </summary>
        public  WingSauce Sauce { get; set; } = WingSauce.Buffalo;

        /// <summary>
        /// Price of the Pterodactyl Wings
        /// </summary>
        public override decimal Price { get; } = 8.95m;

        /// <summary>
        /// Calories in the Pterodactyl Wings calculated based on the sauce
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Sauce)
                {
                    case WingSauce.Buffalo: return 360;
                    case WingSauce.Teriyaki: return 342;
                    case WingSauce.HoneyGlaze: 
                    default: return (359);
                }
            }
        }
    }
}
