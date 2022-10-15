using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A class representing a Cretaceous Coffee
    /// </summary>
    public class CretaceousCoffee : Drink
    {
        /// <summary>
        /// The name of the coffe based on its size
        /// </summary>
        public override string Name { get { return $"{Size} Cretaceous Coffee"; } }

        /// <summary>
        /// The price of the Cretaceous Coffee
        /// </summary>
        public override decimal Price
        {
            get
            {
                switch (Size)
                {
                    case ServingSize.Small: return .75m;
                    case ServingSize.Medium: return 1.25m;
                    case ServingSize.Large:
                    default:    return 2.00m;
                }
            }
        }

        /// <summary>
        /// backing var
        /// </summary>
        private bool _cream = false;
        /// <summary>
        /// True if the Cretaceous Coffee has cream in it
        /// </summary>
        public bool Cream
        {
            get { return _cream; }
            set
            {
                _cream = value;
                OnPropertyChanged("Cream");
                OnPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Represents how many calories are in the coffee based on if it has cream in it
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Cream) return 64;
                else return 0;
            }
        }
    }
}
