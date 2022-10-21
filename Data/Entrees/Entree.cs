using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DinoDiner.Data.MenuMangement;
using System.Reflection;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class for all entrees sold at DinoDiner
    /// </summary>
    public abstract class Entree : MenuItem, INotifyPropertyChanged
    {
        
    }
}
