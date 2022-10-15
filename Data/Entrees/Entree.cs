﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class for all entrees sold at DinoDiner
    /// </summary>
    public abstract class Entree : INotifyPropertyChanged
    {
        /// <summary>
        /// An event triggered when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// A helper method to allow inherited classes to access PropertyChanged
        /// </summary>
        /// <param name="propertyName">The exact name of the property that has changed</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// The name of the Entree
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The price of the Entree
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the Entree
        /// </summary>
        public abstract uint Calories { get; }
    }
}
