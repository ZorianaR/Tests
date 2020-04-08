using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Linq;
using TestForm.Framework;
using TestForm.ServiceForm;

namespace TestForm.Framework
{
    public static class Settings
    {
        public static readonly string url = "http://automationpractice.com/index.php";
        public static readonly TimeSpan ImplicitWait = TimeSpan.FromSeconds(3);
        public static readonly string Driver = "Chrome";
    }
}
