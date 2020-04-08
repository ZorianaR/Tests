using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Linq;
using TestForm.Framework;
using TestForm.ServiceForm;




namespace TestForm
{
    [TestFixture]
    public class BaseTest
    {
        private readonly IWebDriver driver;
        private static readonly TimeSpan ImplicitWait = TimeSpan.FromSeconds(3);
        private Headr headr;

        private WebDriverWait wait;


        public BaseTest()
        {
            driver = new ChromeDriver(/*Directory.GetCurrentDirectory()*/);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = ImplicitWait;
            driver.Navigate().GoToUrl(Settings.url);
            headr = new Headr(driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => driver.Quit();


        [Test]
        public void TestForm()
        {

            ControllerPage controllerPage = headr.ClickOnContactUs();
            bool isFormWork = controllerPage
                              .ChooseSubject()
                              .EnterEmail("test@test.com")
                              .EnterMassage("Something")
                              .PressSend().IsFormOk();
            Assert.That(isFormWork, "Form isn't work with correct datas");

        }
        [Test]
        public void TestRetrievePassword()
        {
            AuthentificationPage authntificationPage = headr.ClickOnSignIn();
            bool isEmailOk = authntificationPage
                           .ClickOnForgotPassword()
                           .PutEmail("test@test.com")
                           .ClickRetrievePassword()
                           .IsEmailOk();
            Assert.That(isEmailOk, "Email not Ok");   

        }
    }
}

