using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a customizeable Veloci-Wraptor
    /// </summary>
    public class VelociWraptor : Entree
    {
        /// <summary>
        /// Name of the Caesar chicken wrap
        /// </summary>
        public override string Name { get; } = "Veloci-Wraptor";

        /// <summary>
        /// Price of the Veloci-Wraptor
        /// </summary>
        public override decimal Price { get; } = 6.25m;

        /// <summary>
        /// Calories in the Veloci-Wraptor based on if it has dressing/cheese
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint tempCals = 732;
                if (!Dressing) tempCals -= 94;
                if (!Cheese) tempCals -= 22;
                return tempCals;
            }
        }

        /// <summary>
        /// backing var
        /// </summary>
        private bool _dressing = true;
        /// <summary>
        /// True if the Veloci-Wraptor has dressing on it, defaults to true
        /// </summary>
        public bool Dressing
        {
            get { return _dressing; }
            set
            {
                _dressing = value;
                OnPropertyChanged("Dressing");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// backing var
        /// </summary>
        private bool _cheese = true;
        /// <summary>
        /// True if the Veloci-Wraptor has cheese on it, defaults to true
        /// </summary>
        public bool Cheese
        {
            get { return _cheese; }
            set
            {
                _cheese = value;
                OnPropertyChanged("Cheese");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }
    }
}
