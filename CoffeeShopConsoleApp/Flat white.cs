using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Flat_white : Coffee
    {
        public Flat_white(int discount) : base(discount)
        {
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
