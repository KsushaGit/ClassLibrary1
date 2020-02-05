using ClassLibrary1.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.helper
{
    class Web_Element : IWebElement   // релиазоваваем методы интерфейса
    {

       
        public string Name { get; private set } // можем метод получить, но сетать не везде можем получить
        private IWebElement _container;
        private By _by; // наш приват локатор 

        private IWebElement Element
        {
            get
            {
                List<IWebElement> elements = _container.FindElements(@_by).ToList() ?? Browser.Driver.FindElements(@_by).ToList(); // как тернарный орператор. если поиск не прошел по контейнеру, то тогда ищем вообще

                if (elements.Count == 0) // не нашли элемент
                {
                    throw new NoSuchElementException($"Element {Name} was not found with locator {_by}");
                }
                if (elements.Count > 1) // у нас может быть больше 1го эелемента, амы работаем только с 1 
                {
                    throw new Exception($"Element {Name} is more then 1 on a page with locator {_by}");
                }

                return elements.FirstOrDefault();

            }
        }
        // создаем констурктор, как будет элемент создавтаь

            public Web_Element(string Xpath, string name = "")
        {
            _by = By.XPath(Xpath);
            Name = name;

        }


        public string TagName => throw new NotImplementedException();

        public string Text => throw new NotImplementedException();

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public Point Location => throw new NotImplementedException();

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
