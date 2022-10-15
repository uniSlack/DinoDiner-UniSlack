using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class for burgers
    /// </summary>
    public abstract class Burger : Entree
    {
        /// <summary>
        /// private backing var
        /// </summary>
        private uint _patties;
        /// <summary>
        /// How many patties are on the burger
        /// </summary>
        public uint Patties
        {
            get { return _patties; }
            set
            {
                _patties = value;
                OnPropertyChanged("Patties");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _ketchup;
        /// <summary>
        /// A bool that is true if the burger has Ketchup on it
        /// </summary>
        public bool Ketchup
        {
            get { return _ketchup; }
            set
            {
                _ketchup = value;
                OnPropertyChanged("Ketchup");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _mustard;
        /// <summary>
        /// A bool that is true if the burger has Mustard on it
        /// </summary>
        public bool Mustard
        {
            get { return _mustard; }
            set
            {
                _mustard = value;
                OnPropertyChanged("Mustard");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _pickle;
        /// <summary>
        /// A bool that is true if the burger has Pickle on it
        /// </summary>
        public bool Pickle
        {
            get { return _pickle; }
            set
            {
                _pickle = value;
                OnPropertyChanged("Pickle");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _mayo;
        /// <summary>
        /// A bool that is true if the burger has Mayo on it
        /// </summary>
        public bool Mayo
        {
            get { return _mayo; }
            set
            {
                _mayo = value;
                OnPropertyChanged("Mayo");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _bbq;
        /// <summary>
        /// A bool that is true if the burger has BBq on it
        /// </summary>
        public bool BBQ
        {
            get { return _bbq; }
            set
            {
                _bbq = value;
                OnPropertyChanged("BBQ");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _onion;
        /// <summary>
        /// A bool that is true if the burger has Onion on it
        /// </summary>
        public bool Onion
        {
            get { return _onion; }
            set
            {
                _onion = value;
                OnPropertyChanged("Onion");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _tomato;
        /// <summary>
        /// A bool that is true if the burger has Tomato on it
        /// </summary>
        public bool Tomato
        {
            get { return _tomato; }
            set
            {
                _tomato = value;
                OnPropertyChanged("Tomato");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _lettuce;
        /// <summary>
        /// A bool that is true if the burger has Lettuce on it
        /// </summary>
        public bool Lettuce
        {
            get { return _lettuce; }
            set
            {
                _lettuce = value;
                OnPropertyChanged("Lettuce");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _americanCheese;
        /// <summary>
        /// A bool that is true if the burger has AmericanCheese on it
        /// </summary>
        public bool AmericanCheese
        {
            get { return _americanCheese; }
            set
            {
                _americanCheese = value;
                OnPropertyChanged("AmericanCheese");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _swissCheese;
        /// <summary>
        /// A bool that is true if the burger has SwissCheese on it
        /// </summary>
        public bool SwissCheese
        {
            get { return _swissCheese; }
            set
            {
                _swissCheese = value;
                OnPropertyChanged("SwissCheese");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _bacon;
        /// <summary>
        /// A bool that is true if the burger has Bacon on it
        /// </summary>
        public bool Bacon
        {
            get { return _bacon; }
            set
            {
                _bacon = value;
                OnPropertyChanged("Bacon");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// private backing var
        /// </summary>
        private bool _mushrooms;
        /// <summary>
        /// A bool that is true if the burger has Mushrooms on it
        /// </summary>
        public bool Mushrooms
        {
            get { return _mushrooms; }
            set
            {
                _mushrooms = value;
                OnPropertyChanged("Mushrooms");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// The price of the burger based on the toppings and number of patties
        /// </summary>
        public override decimal Price
        {
            get
            {
                decimal p = 1.50m * Patties;
                if (Ketchup) p += .20m;
                if (Mustard) p += .20m;
                if (Pickle) p += .20m;
                if (Mayo) p += .20m;
                if (BBQ) p += .10m;
                if (Onion) p += .40m;
                if (Tomato) p += .40m;
                if (Lettuce) p += .30m;
                if (AmericanCheese) p += .25m;
                if (SwissCheese) p += .25m;
                if (Bacon) p += .50m;
                if (Mushrooms) p += .40m;
                return p;
            }
        }

        /// <summary>
        /// The number of calories in the burger based on the the toppings and number of patties
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint c = 204 * Patties;
                if (Ketchup) c += 19;
                if (Mustard) c += 3;
                if (Pickle) c += 7;
                if (Mayo) c += 94;
                if (BBQ) c += 29;
                if (Onion) c += 44;
                if (Tomato) c += 22;
                if (Lettuce) c += 5;
                if (AmericanCheese) c += 104;
                if (SwissCheese) c += 106;
                if (Bacon) c += 43;
                if (Mushrooms) c += 4;
                return c;
            }
        }
    }
}
