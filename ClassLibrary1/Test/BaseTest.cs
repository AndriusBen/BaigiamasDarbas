using ClassLibrary1.Drivers;
using ClassLibrary1.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    public class BaseTest
    {
        protected static IWebDriver Driver;

        public static IkeaPage basePage;
        public static PrekiuPaieskaPage prekiuPaieskaPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            basePage = new IkeaPage(Driver);
            prekiuPaieskaPage = new PrekiuPaieskaPage(Driver);
        }

        //[TearDown]
        //public static void TakeScreeshot()
        //{
        //    if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
        //    {
        //       Screenshot.TakeScreenshot(driver);
        //    }                
        //}

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();

        }
    }
}
