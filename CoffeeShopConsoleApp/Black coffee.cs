using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Black_coffee:Coffee
    {
        public Black_coffee(int discount) : base(discount)
        {
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
