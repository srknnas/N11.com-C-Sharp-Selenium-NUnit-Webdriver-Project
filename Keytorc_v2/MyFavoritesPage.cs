using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.ObjectModel;

namespace Keytorc_v2
{
    class MyFavoritesPage
    {
        //Initialize my object in the page
        public MyFavoritesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id=\"view\"]/ul/li")]
        public IList<IWebElement> myFavoriteList;

        [FindsBy(How = How.XPath, Using = ".//div[@id='view']/ul/li[1]/div/div[3]/span")]
        public IWebElement removeFavoriteButton;

        [FindsBy(How = How.XPath, Using = ".//div[@class='btnHolder']")]
        public IWebElement removeFavoriteButtonOk;
    }
}
