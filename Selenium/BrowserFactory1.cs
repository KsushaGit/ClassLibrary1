using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Selenium
{
    public enum BrowserType
    {
        Chrome,
        Ege,
        Firefox,
        IE

    }

    class BrowserFactory1
    {
        public static IWebDriver GetDriver(BrowserType browserType)
        {
            IWebDriver driver;

            switch(browserType)

            {
                case BrowserType.Chrome:
                    {
                        var options = new ChromeOptions();
                        var service = ChromeDriverService.CreateDefaultService();
                        driver = new ChromeDriver(service, options);
                        break;

                    }

                case BrowserType.IE:
                    {
                        var options = new InternetExplorerOptions();
                        var service = InternetExplorerDriverService.CreateDefaultService();
                        driver = new InternetExplorerDriver(service, options);
                        break;
                    }

                default:
                    {
                        throw new ArgumentException("Your browser is not supported");// excpб если какой-то другой браузер будет                     
                    }
            }

            return driver;
        }

    }
}
