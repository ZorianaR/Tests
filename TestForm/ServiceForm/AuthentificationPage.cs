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
   public class AuthentificationPage:Base
    {
        private static readonly By lostPassword = By.XPath("//*[@id='login_form']/div/p[1]/a");
        public AuthentificationPage(IWebDriver driver) : base(driver) { }
        public ControllPassword ClickOnForgotPassword()
        {
            Driver.FindElement(lostPassword).Click();
            return new ControllPassword(Driver);
        }
    }
}
