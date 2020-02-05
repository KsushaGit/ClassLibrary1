using ClassLibrary1.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.helper
{
   public class AacrHomePage
    {
        public IWebElement JournalCover => Browser.Driver.FindElement(By.XPath("//*[@class = 'preview-image']"));
        public IWebElement Title => Browser.Driver.FindElement(By.XPath("//*[@class='logo-main-text']"));

        public IWebElement TitleOfCurrentIssue => Browser.Driver.FindElement(By.XPath("//h3/a")); // поиск по осям
                                                                                                  
        public IWebElement TitleOfCurrentIssueLink => Browser.Driver.FindElement(By.XPath("//h3/a"));



        public IWebElement ExecutiveEditor => Browser.Driver.FindElement(By.XPath("//div[@class ='content-box-body' ]/div/div/ul/li/label"));
        public IWebElement ExecutiveEditorBody => Browser.Driver.FindElement(By.XPath("//div[@class ='content-box-body' ]/div/div/ul/li/span")); // иерархия

         

        public IWebElement Issn => Browser.Driver.FindElement(By.XPath("//*[contains(@id,'ctl00_liIssn')]//label"));
        public IWebElement IssnNumber => Browser.Driver.FindElement(By.XPath("//*[contains(@id,'ctl00_liIssn')]//label//following-sibling::span"));// сиблинги

        public IWebElement OnlineIssn => Browser.Driver.FindElement(By.XPath("//*[contains(@id,'ctl00_onlineIssnLabel')]//preceding-sibling::label"));//сиблинги
       
      
        public IWebElement OnlineIssnNumber => Browser.Driver.FindElement(By.XPath("//*[contains(@id,'ctl00_onlineIssnLabel')]"));

        public IWebElement Frequency => Browser.Driver.FindElement(By.XPath("//*[contains(@id,'ctl00_liFrequency')]//label"));
        public IWebElement FrequencyValue => Browser.Driver.FindElement(By.XPath("//*[contains(@id,'ctl00_liFrequency')]//span"));

        public IWebElement EnvelopeIcon => Browser.Driver.FindElement(By.XPath("//i[@class ='fa fa-envelope']"));

        public IWebElement SubscribeToETocTitle => Browser.Driver.FindElement(By.XPath("//div[@class ='subscribe-to-etoc']//span"));

        
       // !!!! public IWebElement SubscribeToETocTitleLink => Browser.Driver.FindElement(By.XPath("//div[@class ='subscribe-to-etoc']/a"));



    }
}
