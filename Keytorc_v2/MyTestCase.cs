using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace Keytorc_v2
{
    [TestFixture]

    class MyTestCase
    {
        
        Functions functions = new Functions();
        

        [Test, Order(1)]
        public void OpenMainPageTest()
        {
            Assert.AreEqual(true, functions.OpenMainPage());
            Thread.Sleep(10000);
        }

        [Test, Order(2)]
        public void LoginTest()
        {
            Assert.AreEqual(true, functions.Login());
            Thread.Sleep(2000);
        }

        [Test, Order(3)]
        public void SearchSamsungTest()
        {
            Assert.AreEqual(true, functions.SearchSamsung());
            Thread.Sleep(2000);
        }

        [Test, Order(4)]
        public void ControlSearchSamsungTest()
        {
            Assert.AreEqual(true, functions.ControlSearchSamsung());
            Thread.Sleep(2000);
        }

        [Test, Order(5)]
        public void SecondPageTest()
        {
            Assert.AreEqual(true, functions.SecondPage());
            Thread.Sleep(2000);
        }

        [Test, Order(6)]
        public void ControlSecondPageTest()
        {
            Assert.AreEqual(true, functions.SecondPageControl());
            Thread.Sleep(2000);
        }

        //[Test, Order(7)]
        //public void AddFavoriteTest()
        //{
        //    Assert.AreEqual(true, functions.AddFavorite());
        //    Thread.Sleep(2000);
        //}

        //[Test, Order(8)]
        //public void ClickMyFavoriteButtonOnMainTest()
        //{
        //    Assert.AreEqual(true, functions.ClickMyFavoriteButtonOnMain());
        //    Thread.Sleep(2000);
        //}

        //[Test, Order(9)]
        //public void ClickMyFavoriteLinkTest()
        //{
        //    Assert.AreEqual(true, functions.ClickMyFavoriteLink());
        //    Thread.Sleep(2000);
        //}

        //[Test, Order(10)]
        //public void ControlFavoriteProductInFavoriteListTest1()
        //{
        //    Assert.AreEqual(true, functions.ControlFavoriteProductInFavoriteList());
        //    Thread.Sleep(2000);
        //}

        //[Test, Order(11)]
        //public void RemoveFavoriteProductTest()
        //{
        //    Assert.AreEqual(true, functions.RemoveFavoriteProduct());
        //    Thread.Sleep(2000);
        //}

        //[Test, Order(12)]
        //public void ControlFavoriteProductInFavoriteListTest2()
        //{
        //    Assert.AreEqual(false, functions.ControlFavoriteProductInFavoriteList());
        //    Thread.Sleep(1000);
        //}
    }
}
