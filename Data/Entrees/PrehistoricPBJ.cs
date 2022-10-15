namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Prehistoric PBJ sandwich
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// The name of the PBJ
        /// </summary>
        public override string Name { get; } = "Prehistoric PBJ";

        /// <summary>
        /// private backing variable
        /// </summary>
        private bool _peanutButter = true;
        /// <summary>
        /// Indicates if the PBJ was made with peanut butter
        /// </summary>
        public bool PeanutButter 
        { 
            get { return _peanutButter; }
            set
            {
                _peanutButter = value;
                OnPropertyChanged("PeanutButter");
                OnPropertyChanged("Calories");
            } 
        }

        /// <summary>
        /// backing var
        /// </summary>
        private bool _jelly = true;
        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool Jelly 
        {
            get { return _jelly; }
            set
            {
                _jelly = value;
                OnPropertyChanged("Jelly");
                OnPropertyChanged("Calories");
            } 
        }

        /// <summary>
        /// backing var
        /// </summary>
        private bool _toasted = true;
        /// <summary>
        /// Indicates the PBJ is served toasted
        /// </summary>
        public bool Toasted
        {
            get { return _toasted; }
            set
            {
                _toasted = value;
                OnPropertyChanged("Toasted");
            }
        }

        /// <summary>
        /// The price of the PBJ
        /// </summary>
        public override decimal Price { get; } = 3.75m;

        /// <summary>
        /// The calories of the PBJ
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 148;
                if (PeanutButter) calories += 188;
                if (Jelly) calories += 62;
                return calories;
            }
        }
    }
}