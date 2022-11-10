using DinoDiner.Data.Drinks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Enums;
using DinoDiner.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.MenuMangement
{
    /// <summary>
    /// static class contatining default instatnces of all menu items, used for webpage display
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Holds all default entrees
        /// </summary>
        public static IEnumerable<MenuItem> Entrees { get; } =  new List<MenuItem>() 
        { 
            new AllosaurusAllAmericanBurger(),
            new Brontowurst(),
            new CarnotaurusCheeseburger(),
            new DeinonychusDouble(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new TRexTriple(),
            new VelociWraptor()
        };


        /// <summary>
        /// holds all sides in each of their three sizes
        /// </summary>
        public static IEnumerable<MenuItem> Sides { get; } = new List<MenuItem>()
        {
            new Fryceritops() {Size = ServingSize.Small},
            new Fryceritops() {Size = ServingSize.Medium},
            new Fryceritops() {Size = ServingSize.Large},
            new MeteorMacAndCheese() {Size = ServingSize.Small},
            new MeteorMacAndCheese() {Size = ServingSize.Medium},
            new MeteorMacAndCheese() {Size = ServingSize.Large},
            new MezzorellaSticks() {Size = ServingSize.Small},
            new MezzorellaSticks() {Size = ServingSize.Medium},
            new MezzorellaSticks() {Size = ServingSize.Large},
            new Triceritots() {Size = ServingSize.Small},
            new Triceritots() {Size = ServingSize.Medium},
            new Triceritots() {Size = ServingSize.Large},
        };

        /// <summary>
        /// holds the default drinks in each of their three sizes
        /// </summary>
        public static IEnumerable<MenuItem> Drinks { get; } = new List<MenuItem>()
        {
            new CretaceousCoffee() {Size = ServingSize.Small},
            new CretaceousCoffee() {Size = ServingSize.Large},
            new CretaceousCoffee() {Size = ServingSize.Medium},
            new Plilosoda() {Size = ServingSize.Small},
            new Plilosoda() {Size = ServingSize.Large},
            new Plilosoda() {Size = ServingSize.Medium},
        };

        /// <summary>
        /// Holds every meny item in its default state and in each available serving size
        /// </summary>
        public static IEnumerable<MenuItem> FullMenu { get; } = new List<MenuItem>().Concat(Entrees).Concat(Sides).Concat(Drinks);
    }
}
