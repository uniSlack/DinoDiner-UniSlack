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
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Name of the chicken nuggets
        /// </summary>
        public override string Name { get { return $"{Count} Dino Nuggets"; } }

        /// <summary>
        /// backing var
        /// </summary>
        public uint _count = 6;
        /// <summary>
        /// Count of the Dino Nuggets
        /// </summary>
        public uint Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged("Count");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Price of the Dino Nuggets calculated per nugget
        /// </summary>
        public override decimal Price { get { return (Count * .25m); } }

        /// <summary>
        /// Calories in the Dino Nuggers calculated per nugget
        /// </summary>
        public override uint Calories { get { return (Count * 61); } }
    }
}
