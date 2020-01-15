using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;

namespace Keytorc_v2
{
    class Functions
    {
        static string favoriteProduct;
        public static IWebDriver driver = new FirefoxDriver();
        LoginPage loginPage = new LoginPage(driver);
        MainPage mainPage = new MainPage(driver);
        WishListsPage wishListPage = new WishListsPage(driver);
        MyFavoritesPage myFavoritesPage = new MyFavoritesPage(driver);

        public bool OpenMainPage()
        {
            try
            {
                string url = @"https://www.n11.com/";
                driver.Navigate().GoToUrl(url);

                string expectedTitle = "n11.com - Alışverişin Uğurlu Adresi";
                string title = driver.Title;

                if (title == expectedTitle)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }            
        }

        public bool Login()
        {
            try
            {
                mainPage.singIn.Click();
                loginPage.username.SendKeys("srkn.nas@gmail.com");
                loginPage.password.SendKeys("a12345678");
                loginPage.login.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SearchSamsung()
        {
            try
            {
                mainPage.searchData.SendKeys("Samsung");
                mainPage.searchBtn.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ControlSearchSamsung()
        {
            try
            {
                bool _samsungControl;
                string samsung;
                _samsungControl = mainPage.samsungControl.Displayed;
                samsung = mainPage.productName.Text;
                if (_samsungControl == true && samsung.Contains("Samsung"))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SecondPage()
        {
            try
            {
                mainPage.secondPage.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SecondPageControl()
        {
            bool activeControl = false;
            try
            {
                activeControl = mainPage.secondPageActive.GetAttribute("class").Contains("active");
                return activeControl;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddFavorite()
        {
            try
            {
                favoriteProduct = mainPage.addFavoriteText.Text;
                mainPage.addFavorite.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ClickMyFavoriteButtonOnMain()
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", mainPage.myFavoriteButton);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ClickMyFavoriteLink()
        {
            try
            {
                wishListPage.myFavoriteLink.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ControlFavoriteProductInFavoriteList()
        {
            try
            {
                List<string> matchingLinks = new List<string>();

                // Assume "driver" is a valid IWebDriver.
                IList<IWebElement> links = myFavoritesPage.myFavoriteList;

                // You could probably use LINQ to simplify this, but here is
                // the foreach solution
                foreach (IWebElement link in links)
                {
                    string text = link.FindElement(By.XPath("//*[@class='pro']/a/h3")).Text;
                    if (favoriteProduct == text)
                        return true;
                    else
                        return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveFavoriteProduct()
        {
            try
            {
                //Remove Favorite
                myFavoritesPage.removeFavoriteButton.Click();
                //Press Ok Button
                myFavoritesPage.removeFavoriteButtonOk.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
