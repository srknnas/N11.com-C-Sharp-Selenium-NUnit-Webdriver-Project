using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Keytorc_v2
{
    class LoginPage
    {
        //Initialize my object in the page
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement login;
    }
}
