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
using ClassLibrary1.Tools;

namespace ClassLibrary1.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static IkeaPage basePage;
        public static PrekiuPaieskaPage prekiuPaieskaPage;
        public static IspirktuvesPage ispirktuvesPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            basePage = new IkeaPage(Driver);
            prekiuPaieskaPage = new PrekiuPaieskaPage(Driver);
            ispirktuvesPage = new IspirktuvesPage(Driver);
        }

        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Screenshot1.TakeScreenshot(Driver);
            }
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();

        }
    }
}
