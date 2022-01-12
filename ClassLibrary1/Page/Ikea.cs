using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Page
{
    public class Ikea : BasePage
    {
        private const string PageAddress = "https://www.ikea.lt/lt";

        private IWebElement _pasirinktiMenuProducts => driver.FindElement(By.Id("navbarDropdownProducts"));
        private IWebElement _pasirinktiAntklodes => driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li.headerMenuProducts__menu--item.nav-item.dropdown.productsMenu.show > div > div > div > div.col-lg-9.pl-0.products > a:nth-child(1) > span"));
        private IWebElement _isskleistiDydziuFiltra => driver.FindElement(By.Id("sizeFilter"));
        private IWebElement _pazymetiDydis => driver.FindElement(By.CssSelector("#filterSelectors > div > div > nav > div > div.filterContainerMultiple > div:nth-child(3) > ul > li.basicSizes > ul > li:nth-child(2) > span.icheck.icheck_minimal > div"));
        private IWebElement _pasirinktiPreke => driver.FindElement(By.CssSelector("#contentWrapper > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(2) > div > div.card-header > a > div.productImg"));
        private IWebElement _paskaustiIPirkiniuKrepselyKlavisa => driver.FindElement(By.ClassName("addToCart btn btn-yellow  btn-block btn-icon text-white"));
        private IWebElement _spaudziamPerziuretiPirkiniuKrepseliKlavisa => driver.FindElement(By.ClassName("goToCart btn btn-yellow  btn-icon text-white"));
        private IWebElement _gautasAnklodesRezultatas => driver.FindElement(By.ClassName("#cart > div:nth-child(2) > span:nth-child(1)"));
        private IWebElement _pasirinktiDviguliuLovuRemai => driver.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li.headerMenuProducts__menu--item.nav-item.dropdown.productsMenu.show > div > div > div > div.col-lg-9.pl-0.products > a:nth-child(13) > span"));
        private IWebElement _gautasDviguliuLovuRėmaiRezultatas => driver.FindElement(By.ClassName("display-5 heroTit"));
        public Ikea(IWebDriver webdriver) : base(webdriver) { }

        public Ikea IsskleistiPrekiuJuosta()
        {
            _pasirinktiMenuProducts.Click();

            return this;
        }
        public Ikea PasirinktiAntklode()
        {
            _pasirinktiAntklodes.Click();

            return this;
        }
        public Ikea IsskleistiDydziuFiltra()
        {
            _isskleistiDydziuFiltra.Click();

            return this;
        }
        public Ikea PazymetiDydi150x200()
        {
            _pazymetiDydis.Click();

            return this;
        }
        public Ikea PasirinktiPreke()
        {
            _pasirinktiPreke.Click();

            return this;
        }
        public Ikea IdetiIPirkiniuKrepseli()
        {
            _paskaustiIPirkiniuKrepselyKlavisa.Click();

            return this;
        }
        public Ikea PerziuretiPirkiniuKrepseli()
        {
            _spaudziamPerziuretiPirkiniuKrepseliKlavisa.Click();

            return this;
        }
        public Ikea PatikrintiRezultata(string result)
        {
            Assert.AreEqual(result, _gautasAnklodesRezultatas.GetAttribute("value"), "Prekiu kiekis nesutampa");

            return this;
        }
        public Ikea PasirinktiDviguluLovuRemai()
        {
            _pasirinktiDviguliuLovuRemai.Click();

            return this;
        }
        public Ikea PatikrintiDviguliuLovuRemaiRezultata(string result)
        {
            Assert.AreEqual(result, _gautasDviguliuLovuRėmaiRezultatas.GetAttribute("value"), "Prekiu kiekis nesutampa");

            return this;
        }
    }
}
