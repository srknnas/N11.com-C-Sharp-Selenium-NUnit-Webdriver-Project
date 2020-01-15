using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Keytorc_v2
{
    class MainPage
    {
        //Initialize my object in the page
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "btnSignIn")]
        public IWebElement singIn;

        [FindsBy(How = How.Id, Using = "searchData")]
        public IWebElement searchData;

        [FindsBy(How = How.ClassName, Using = "searchBtn")]
        public IWebElement searchBtn;

        [FindsBy(How = How.XPath, Using = ".//*[@id='view']")]
        public IWebElement samsungControl;

        [FindsBy(How = How.CssSelector, Using = "h3.productName")]
        public IWebElement productName;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[2]/div[4]/a[2]")]
        public IWebElement secondPage;

        [FindsBy(How = How.CssSelector, Using = "div.pagination>a:nth-child(3)")]
        public IWebElement secondPageActive;

        [FindsBy(How = How.XPath, Using = ".//*[@id='contentListing']/div/div/div[2]/section/div[2]/ul/li[2]/div/div[1]/a/h3")]
        public IWebElement addFavoriteText;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[2]/section[1]/div[2]/ul/li[2]/div/div[1]/span")]
        public IWebElement addFavorite;

        [FindsBy(How = How.XPath, Using = "//*[@class='myAccountMenu hOpenMenu']/div[1]/a[2]")]
        public IWebElement myFavoriteButton;
    }
}
