using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Page
{
     class PrekiuPaieskaPage : BasePage
     {
        private const string PageAddress = "https://www.ikea.lt/lt";

        private IWebElement _pasirinktiMenuProducts => Driver.FindElement(By.Id("navbarDropdownProducts"));       
        private IWebElement _pasirinktiDviguliuLovuRemai => Driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li.headerMenuProducts__menu--item.nav-item.dropdown.productsMenu.show > div > div > div > div.col-lg-9.pl-0.products > a:nth-child(13) > span"));
        private IWebElement _gautasDviguliuLovuRėmaiRezultatas => Driver.FindElement(By.CssSelector("#contentWrapper > div.container.presentationContainer > div:nth-child(1) > div"));
        public PrekiuPaieskaPage(IWebDriver webdriver) : base(webdriver) { }

        public PrekiuPaieskaPage IeitiIPuslapi()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }               
        public PrekiuPaieskaPage PasirinktiDviguluLovuRemai()
        {
            _pasirinktiDviguliuLovuRemai.Click();

            return this;
        }
        public PrekiuPaieskaPage PatikrintiDviguliuLovuRemaiRezultata(string result)
        {
            Assert.AreEqual(result, _gautasDviguliuLovuRėmaiRezultatas.GetAttribute("value"), "Prekiu kiekis nesutampa");

            return this;
        }
        public PrekiuPaieskaPage AcceptCookies()
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

