﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado:Coffee,Milk
    {
        public Cortado(int discount) : base(discount)
        {
        }

        public int mlMilk()
        {
            return 40;
        }

        public override int price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
