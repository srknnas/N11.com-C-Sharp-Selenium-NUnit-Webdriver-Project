using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Keytorc_v2
{
    class WishListsPage
    {
        //Initialize my object in the page
        public WishListsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//div[@class='listItemWrap']/a/h4")]
        public IWebElement myFavoriteLink;
    }
}
