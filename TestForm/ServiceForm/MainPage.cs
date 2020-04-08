using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Linq;
using TestForm.Framework;
using TestForm.ServiceForm;

namespace TestForm.ServiceForm
{
    public class Headr : Base
    {
        private static readonly By contactButton = By.Id("contact-link");
        private static readonly By SignInButton = By.ClassName("header_user_info");
        public Headr(IWebDriver driver) : base(driver)
        { }
        public AuthentificationPage ClickOnSignIn()
        {
            Driver.FindElement(SignInButton).Click();
            return new AuthentificationPage(Driver);
        }
        public ControllerPage ClickOnContactUs()
        {
            Driver.FindElement(contactButton).Click();
            return new ControllerPage(Driver);
        }
    }
}
