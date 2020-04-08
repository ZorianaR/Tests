using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Linq;
using TestForm.Framework;
using TestForm.ServiceForm;
using System.Threading;

namespace TestForm.Framework
{
    public static class Wait
    {
        public static bool WaitFor(Func<bool> func, int millisecondsTimeout = 250, int waitInterval = 50)
        {
            DateTime start = DateTime.Now;
            do
            {
                if (func())
                    return true;
                Thread.Sleep(waitInterval);


            } while (DateTime.Now - start < TimeSpan.FromMilliseconds(millisecondsTimeout));
            return false;
        }
    }
}
