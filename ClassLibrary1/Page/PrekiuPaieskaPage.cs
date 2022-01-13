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
        private IWebElement _gautasDviguliuLovuRėmaiRezultatas => Driver.FindElement(By.ClassName("display-5 heroTit"));
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
    }
}

