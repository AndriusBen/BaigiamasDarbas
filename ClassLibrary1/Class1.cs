using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://www.ikea.lt/";
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }

        [TestCase("stalas", TestName = "stalas")]
        //[TestCase("5", "25.5", true, "30", TestName = "5 + 25,5 = -30")]
        //[TestCase("1.99", "0.959", false, "2.949", TestName = "1,99 + 0,959 = 2,949")]
        //[TestCase("-1", "-9.99", true, "-10", TestName = "-1 + -9,99 = -10")]
        public static void TestSumBlock(string firstInputValue, string result)
        {
            IWebElement firstInput = _driver.FindElement(By.Id("close-wrapper"));
            
            firstInput.Clear();
            firstInput.SendKeys(firstInputValue);
           
           
            IWebElement calculateButton = _driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > div.d-none.d-lg-block.m-0.searcher > div > div"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.ClassName("see-hfb"));
            Assert.AreEqual(result, actualResult.GetAttribute("value"), "Sum is Incorrect");
        }
        public static void AcceptCookies()
        {
            Cookie mycookies = new Cookie("CookieConsent",
                "{stamp:%27EgIs2km8qQ+mxBiKZDFHDZOY7ZQjIhC5WfrCLtaIOGGd+zd/QCrQsQ==%27%2Cnecessary:true%2Cpreferences:false%2Cstatistics:false%2Cmarketing:false%2Cver:1%2Cutc:1642168344062%2Cregion:%27lt%27}",
                "www.ikea.lt",
                "/",
                DateTime.Now.AddDays(5));

            _driver.Manage().Cookies.AddCookie(mycookies);
            _driver.Navigate().Refresh();

            //return this;
        }
    }
}
