using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Page
{
    class IkeaPage : BasePage
    {
        private const string PageAddress = "https://www.ikea.lt/lt";

        private IWebElement _pasirinktiMenuProducts => Driver.FindElement(By.Id("navbarDropdownProducts"));
        private IWebElement _pasirinktiAntklodes => Driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li.headerMenuProducts__menu--item.nav-item.dropdown.productsMenu.show > div > div > div > div.col-lg-9.pl-0.products > a:nth-child(1) > span"));
        private IWebElement _isskleistiDydziuFiltra => Driver.FindElement(By.Id("sizeFilter"));
        private IWebElement _pazymetiDydis => Driver.FindElement(By.CssSelector("#filterSelectors > div > div > nav > div > div.filterContainerMultiple > div:nth-child(3) > ul > li.basicSizes > ul > li:nth-child(1) > span.icheck.icheck_minimal > div"));
        private IWebElement _pasirinktiPreke => Driver.FindElement(By.CssSelector("#contentWrapper > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(2) > div > div.card-header > a > div.productImg"));
        private IWebElement _paskaustiIPirkiniuKrepselyKlavisa => Driver.FindElement(By.ClassName("addToCart btn btn-yellow  btn-block btn-icon text-white"));
        private IWebElement _spaudziamPerziuretiPirkiniuKrepseliKlavisa => Driver.FindElement(By.ClassName("goToCart btn btn-yellow  btn-icon text-white"));
        private IWebElement _gautasAnklodesRezultatas => Driver.FindElement(By.ClassName("#cart > div:nth-child(2) > span:nth-child(1)"));
       
        public IkeaPage(IWebDriver webdriver) : base(webdriver) { }

        public IkeaPage IeitiIPuslapi()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public IkeaPage IsskleistiPrekiuJuosta()
        {
            _pasirinktiMenuProducts.Click();

            return this;
        }
        public IkeaPage PasirinktiAntklode()
        {
            _pasirinktiAntklodes.Click();

            return this;
        }
        public IkeaPage IsskleistiDydziuFiltra()
        {
            _isskleistiDydziuFiltra.Click();

            return this;
        }
        public IkeaPage PazymetiDydi150x200()
        {
            _pazymetiDydis.Click();

            return this;
        }
        public IkeaPage PasirinktiPreke()
        {
            _pasirinktiPreke.Click();

            return this;
        }
        public IkeaPage IdetiIPirkiniuKrepseli()
        {
            _paskaustiIPirkiniuKrepselyKlavisa.Click();

            return this;
        }
        public IkeaPage PerziuretiPirkiniuKrepseli()
        {
            _spaudziamPerziuretiPirkiniuKrepseliKlavisa.Click();

            return this;
        }
        public IkeaPage PatikrintiRezultata(string result)
        {
            Assert.AreEqual(result, _gautasAnklodesRezultatas.GetAttribute("value"), "Prekiu kiekis nesutampa");

            return this;
        }
        public IkeaPage AcceptCookies()
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
