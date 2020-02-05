using ClassLibrary1.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestFixture]

    public class BaseTestCalss
    {
        private Browser _browser;

        [SetUp]
        public virtual void BeforeTest()
        {
            _browser = Browser.GetInstance();
             Browser.WindowsMaximize();
        }

    
    [TearDown]


    public virtual void AfterTest()
    {
        Browser.CleanUpDriver();


    }

}
}
