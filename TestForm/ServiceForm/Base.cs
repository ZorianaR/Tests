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
    public abstract class Base
    {
        protected readonly IWebDriver Driver;
        protected Base(IWebDriver driver) => Driver = driver;

    }
}
