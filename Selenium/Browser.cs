using ClassLibrary1.helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Selenium
{
    public class Browser
    {
        private static IWebDriver _driver;
        private string _browserName;
        private BrowserType _type;
        private static Browser _instance;



        private void InitBrowser()

        {
            _browserName = Utills.GetConfigurationValue("BrowserType");
            Enum.TryParse(_browserName, out _type);
            _driver = BrowserFactory1.GetDriver(_type);
        }

        internal static void WindowsMaximize()
        {
            _driver.Manage().Window.Maximize();
        }

        public Browser() // конструктор браузера
        {
            InitBrowser();
        }

        public static Browser GetInstance() => _instance ?? (_instance = new Browser()); // если констурктор не был вызван, то иснтанс -нул и создается новый класс браузера
        public static IWebDriver Driver => _driver;
        public static void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void WindowsMaximize(string url)
        {
            Driver.Manage().Window.Maximize();
        }


        public static void CleanUpDriver()
        {
            Driver.Close();
            Driver.Quit();
            _instance = null;

         }

    }
}
