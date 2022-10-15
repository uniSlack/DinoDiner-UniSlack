using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Sides
{
    /// <summary>
    /// A class that represents a customizable order of Fryceritops
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Name of the French fries
        /// </summary>
        public override string Name { get { return $"{Size} Fryceritops"; } }


        /// <summary>
        /// backing variable
        /// </summary>
        private bool _salt = true;
        /// <summary>
        /// True if the Fryceritops have salt on them, defaults to true
        /// </summary>
        public bool Salt
        {
            get { return _salt; }
            set
            {
                _salt = value;
                OnPropertyChanged("Salt");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// backing var
        /// </summary>
        private bool _sauce = false;
        /// <summary>
        /// True if the Fryceritops come with fry sauce, defaults to false
        /// </summary>
        public bool Sauce
        {
            get { return _sauce; }
            set
            {
                _sauce = value;
                OnPropertyChanged("Sauce");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Price of the order based on the the size
        /// </summary>
        public override decimal Price
        {
            get
            {
                switch (Size)
                {
                    case ServingSize.Small: return 3.50m;
                    case ServingSize.Medium: return 4.00m;
                    case ServingSize.Large:
                    default: return 5.00m;
                }
            }
        }

        /// <summary>
        /// Calories of the order based on the size and the sauce
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint tempCals;
                switch (Size)
                {
                    case ServingSize.Small: tempCals = 375; break;
                    case ServingSize.Medium: tempCals = 465; break;
                    case ServingSize.Large:
                    default: tempCals = 510; break;
                }
                if (Sauce) tempCals += 80;
                return tempCals;
            }
        }
    }
}
