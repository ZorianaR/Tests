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
    public class ControllerPage : Base
    {
        private static readonly By Email = By.Id("email");
        private static readonly By Massage = By.Id("message");
        private static readonly By IdContact = By.Id("id_contact");
        private static readonly By IsFormOkdiv = By.ClassName("alert-success");
        private static readonly By Submit = By.Id("submitMessage");

        public ControllerPage(IWebDriver driver) : base(driver) { }

        public ControllerPage ChooseSubject()
        {
            IWebElement selectElem = Driver.FindElement(IdContact);
            SelectElement select = new SelectElement(selectElem);
            //System.Collections.Generic.IList<OpenQA.Selenium.IWebElement> options = select.Options;
            select.SelectByText("Customer service");
            return this;
        }
        public ControllerPage EnterEmail(string email)
        {
            Driver.FindElement(Email).Click();
            Driver.FindElement(Email).Clear();
            Driver.FindElement(Email).SendKeys(email);
            return this;
        }
        public ControllerPage EnterMassage(string massage)
        {
            Driver.FindElement(Massage).Click();
            Driver.FindElement(Massage).Clear();
            Driver.FindElement(Massage).SendKeys(massage);
            return this;
        }
        public ControllerPage PressSend()
        {
            Driver.FindElement(Submit).Click();
            return this;
        }
        public bool IsFormOk()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(IsFormOkdiv).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isOk;
        }
    }
}
