using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Latte(1),
                new Cortado(2),
                new Black_coffee(3)

            };
            List<Milk> milks = new List<Milk>();
            {
                new Latte(2);
                new Cortado(2);
            }


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price()+"The strenght is: "+coffee.Strength());
            }

            Console.ReadKey();


        }
    }
}
