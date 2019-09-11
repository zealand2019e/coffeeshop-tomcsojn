using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            return 20-discount;
        }
        public abstract string Strength();
        int _disc;
        public int discount { get {return _disc; } set { if (value > 5) throw new ArgumentException(); else _disc = value; } }

        protected Coffee(int discount)
        {
            this.discount = discount;
        }
    }
}
