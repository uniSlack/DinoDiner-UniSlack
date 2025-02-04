﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a customizable brautwurst with fried peppers and onions served in a bun 
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// The name of the brautwurst
        /// </summary>
        public override string Name { get; } = "Brontowurst";

        /// <summary>
        /// Price of the Brontowurst
        /// </summary>
        public override decimal Price { get; } = 5.86m;

        /// <summary>
        /// The number of calories in the Brontowurst
        /// </summary>
        public override uint Calories { get; } = 512;

        /// <summary>
        /// backing var
        /// </summary>
        private bool _onions = true;
        /// <summary>
        /// True if the Brontowurst has onions, defaulted to true
        /// </summary>
        public bool Onions
        {
            get { return _onions; }
            set
            {
                _onions = value;
                OnPropertyChanged("Onions");
            }
        }

        /// <summary>
        /// backing var
        /// </summary>
        private bool _peppers = true;
        /// <summary>
        /// True if the Brontowurst has peppers, defaulted to true
        /// </summary>
        public bool Peppers
        {
            get { return _peppers; }
            set
            {
                _peppers = value;
                OnPropertyChanged("Peppers");
            }
        }
    }
}
