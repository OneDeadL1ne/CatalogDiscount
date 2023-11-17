using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CatalogDiscount.Models;

namespace UnitTestDiscount
{
    [TestClass]
    public class UnitTestDiscount
    {
        [TestMethod]
        public void TestDiscount_1()
        {
            //Arrange
            ProductClass product = new ProductClass("Холодильник", 20000, null);

            decimal discount = 16800;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_2()
        {
            //Arrange
            ProductClass product = new ProductClass("Зубная щетка", 5000, null);

            decimal discount = 4750;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_3()
        {
            //Arrange
            ProductClass product = new ProductClass("Носки", 900, null);

            decimal discount = 900;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_4()
        {
            //Arrange
            ProductClass product = new ProductClass("IPhone 15 Pro MAX 1Tb ", 150000, null);

            decimal discount = 126000;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_5()
        {
            //Arrange
            ProductClass product = new ProductClass("Каранташ",  50, null);

            decimal discount = 50;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_6()
        {
            //Arrange
            ProductClass product = new ProductClass("Кабель Baseus", 2300, null);

            decimal discount = 2277;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_7()
        {
            //Arrange
            ProductClass product = new ProductClass("Мышь", 3000, null);

            decimal discount = 2970;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_8()
        {
            //Arrange
            ProductClass product = new ProductClass("Умная станциая Алиса", 12500, null);

            decimal discount = 11500;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_9()
        {
            //Arrange
            ProductClass product = new ProductClass("Очки", 16700, null);

            decimal discount = 15364;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_10()
        {
            //Arrange
            ProductClass product = new ProductClass("Маркер для доски", 700, null);

            decimal discount = 700;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_11()
        {
            //Arrange
            ProductClass product = new ProductClass("Холодильник", 20000, null);

            decimal discount = 16800;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_12()
        {
            //Arrange
            ProductClass product = new ProductClass("Холодильник", 20000, null);

            decimal discount = 16800;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }

        [TestMethod]
        public void TestDiscount_13()
        {
            //Arrange
            ProductClass product = new ProductClass("Холодильник", 20000, null);

            decimal discount = 16800;
            //Act
            var test = ProductClass.Discount(product);

            //Assert
            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_14()
        {
            //Arrange
            ProductClass product = new ProductClass("Холодильник", 20000, null);

            decimal discount = 16800;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
        [TestMethod]
        public void TestDiscount_15()
        {
            //Arrange
            ProductClass product = new ProductClass("Холодильник", 20000, null);

            decimal discount = 16800;
            //Act

            var test = ProductClass.Discount(product);

            //Assert

            Assert.AreEqual(discount, test);
        }
    }
}
