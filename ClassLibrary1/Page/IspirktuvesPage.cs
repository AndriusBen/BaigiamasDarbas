using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Page
{
    class IspirktuvesPage : BasePage
    {
        private const string PageAddress = "https://www.ikea.lt/lt";

        private IWebElement _spaudziamMygtuka => Driver.FindElement(By.Id("sale"));
        private IWebElement _spaudziam10Mygtuka => Driver.FindElement(By.CssSelector("#categories > div > div:nth-child(3)"));
       
        private IWebElement _gautasRezultatas => Driver.FindElement(By.CssSelector("#contentWrapper > section > div"));

        public IspirktuvesPage(IWebDriver webdriver) : base(webdriver) { }

        public IspirktuvesPage IeitiIPuslapi()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }
        public IspirktuvesPage ZiuretiPasiulymusMygtuka()
        {
            _spaudziamMygtuka.Click();

            return this;
        }
        public IspirktuvesPage PrekesIki10()
        {
            _spaudziam10Mygtuka.Click();

            return this;
        }       
        public IspirktuvesPage PatikrintiRezultata(string result)
        {
            Assert.AreEqual(result, _gautasRezultatas.GetAttribute("value"), "Prekiu kiekis nesutampa");

            return this;
        }
        public IspirktuvesPage AcceptCookies()
        {
            Cookie mycookies = new Cookie("CookieConsent",
                "{stamp:%27EgIs2km8qQ+mxBiKZDFHDZOY7ZQjIhC5WfrCLtaIOGGd+zd/QCrQsQ==%27%2Cnecessary:true%2Cpreferences:false%2Cstatistics:false%2Cmarketing:false%2Cver:1%2Cutc:1642168344062%2Cregion:%27lt%27}",
                "www.ikea.lt",
                "/",
                DateTime.Now.AddDays(5));

            Driver.Manage().Cookies.AddCookie(mycookies);
            Driver.Navigate().Refresh();

            return this;
        }



    }
}
