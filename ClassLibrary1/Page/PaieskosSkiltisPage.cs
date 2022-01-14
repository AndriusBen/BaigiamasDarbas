using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Page
{
    class PaieskosSkiltisPage : BasePage
    {
         private const string PageAddress = "https://www.ikea.lt/lt";
         private IWebElement _reiksmesIvestis => Driver.FindElement(By.Id("close-wrapper"));         
         private IWebElement _paieskosMygtukas => Driver.FindElement(By.Id("input-group-append"));
         private IWebElement _gautasRezultatas => Driver.FindElement(By.Id("mb-0 mb-sm-0 pr-0 pr-sm-0"));

         public PaieskosSkiltisPage(IWebDriver webdriver) : base(webdriver) { }

         public PaieskosSkiltisPage IeitiIPuslapi()
         {
            if (Driver.Url != PageAddress)
            {
                  Driver.Url = PageAddress;
            }

            return this;
         }

        public PaieskosSkiltisPage IvedamasIeskomasObjektas(string ieskomasObjektas)
        {
            _reiksmesIvestis.Clear();
            _reiksmesIvestis.SendKeys(ieskomasObjektas);

            return this;
        }              
        public PaieskosSkiltisPage SpaudziamPaieskosMygtuka()
        {
            _paieskosMygtukas.Click();

            return this;
        }

        public PaieskosSkiltisPage GaunamasPaieskosRezultatas(string result)
        {
            Assert.AreEqual(result, _gautasRezultatas.GetAttribute("value"), "Calculation is Incorrect");

            return this;
        }
       
    }
}
