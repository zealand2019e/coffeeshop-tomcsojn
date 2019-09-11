using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class PriceTests
    {
        [TestMethod]
        public void test_price_cortado()
        {
            Cortado ins = new Cortado(0);

            int price = ins.price();

            Assert.AreEqual(25, price);
        }
        [TestMethod]
        public void test_price_fwhite()
        {
            Flat_white ins = new Flat_white(0);

            int price = ins.price();

            Assert.AreEqual(20, price);
        }
        [TestMethod]
        public void test_price_latte()
        {
            Latte ins = new Latte(0);

            int price = ins.price();

            Assert.AreEqual(40, price);
        }
        [TestMethod]
        public void test_price_bcoffe()
        {
            Black_coffee ins = new Black_coffee(0);

            int price = ins.price();

            Assert.AreEqual(20, price);
        }

    }

    [TestClass]
    public class strenghtTest
    {
        [TestMethod]
        public void test_strenght_cortado()
        {
            Cortado ins = new Cortado(0);

            string strenght = ins.Strength();

            Assert.AreEqual("Medium", strenght);
        }
        [TestMethod]
        public void test_strenght_fwhite()
        {
            Flat_white ins = new Flat_white(0);

            string strenght = ins.Strength();

            Assert.AreEqual("Medium", strenght);
        }
        [TestMethod]
        public void test_strenght_latte()
        {
            Latte ins = new Latte(0);

            string strenght = ins.Strength();

            Assert.AreEqual("Weak", strenght);
        }
        [TestMethod]
        public void test_strenght_bcoffe()
        {
            Black_coffee ins = new Black_coffee(0);

            string strenght = ins.Strength();

            Assert.AreEqual("Strong", strenght);
        }
    }
    [TestClass]
    public class testexception
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void test_cortado()
        {
            Cortado ins = new Cortado(7);

            string strenght = ins.Strength();

            Assert.AreEqual("Medium", strenght);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void test_fwhite()
        {
            Flat_white ins = new Flat_white(7);

            string strenght = ins.Strength();

            Assert.AreEqual("Medium", strenght);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void test_latte()
        {
            Latte ins = new Latte(7);

            string strenght = ins.Strength();

            Assert.AreEqual("Weak", strenght);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void test_bcoffe()
        {
            Black_coffee ins = new Black_coffee(6);

            string strenght = ins.Strength();

            Assert.AreEqual("Strong", strenght);
        }
    }
    }
