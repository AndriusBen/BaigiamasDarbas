using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Drivers
{
    class CustomDriver
    {
        public static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver();
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }
    }
}
