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
    public class ControllPassword:Base
    {

        private static readonly By email = By.Id("email");
        private static readonly By submit = By.XPath("//*[@id='form_forgotpassword']/fieldset/p/button/span/i");
        private static readonly By isEmailOkdiv = By.ClassName("alert-success");
        public  ControllPassword(IWebDriver driver): base(driver) { }
        
        public ControllPassword PutEmail(string _email)
        {
            Driver.FindElement(email).Click();
            Driver.FindElement(email).Clear();
            Driver.FindElement(email).SendKeys(_email);
            return this;
        }
        public ControllPassword ClickRetrievePassword()
        {
            Driver.FindElement(submit).Click();
            return this;
        }
        public bool IsEmailOk()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(isEmailOkdiv).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isOk;
        }
    }
}
