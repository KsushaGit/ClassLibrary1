using ClassLibrary1.helper;
using ClassLibrary1.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BusinessCase
{
    class JournalPage
    {
        
        public static void VerifyPageAppearance()
        {
            var aacrHomePage = new AacrHomePage(); // istance of journal page


            Assert.IsTrue(aacrHomePage.JournalCover.Displayed, "Journal cover is not displayed");
            Assert.IsTrue(aacrHomePage.Title.Displayed, "Journal title is not displayed");
        }


        public static void NavigateToAacrHomePage()
        {
            Browser.NavigateToUrl("https://stage-journals.lww.com/aacr/pages/default.aspx");
        }

        public static void VerifyCurrentIssueDerscription()
        {
             var aacrHomePage = new AacrHomePage(); // istance of jurnal page, чтоб мы внашем методе понимали из какого класса мы вызываем метод

            Assert.IsTrue(aacrHomePage.JournalCover.Displayed, "Journal Cover in Current issue section is not displayed");

            Assert.AreEqual("Executive Editor:", aacrHomePage.ExecutiveEditor.Text, "Execturive Editor text has wrong value");

            Assert.That(aacrHomePage.ExecutiveEditorBody.Text, Is.EqualTo("Hans-Joachim Priebe, MD, FRCA, FCAI"), "Execturive Editor Body text has wrong value");
            Assert.That(aacrHomePage.Issn.Text, Is.EqualTo("ISSN:"), "ISSN text is wrong");
           Assert.That(aacrHomePage.IssnNumber.Text, Is.EqualTo("2575-3126"), "issn number has wrong value");  // xpath верный, но падает exception
            Assert.AreEqual("Online ISSN:", aacrHomePage.OnlineIssn.Text, "Online Issn text is wrong");
            Assert.AreEqual("2575-3126", aacrHomePage.OnlineIssnNumber.Text, "Online Issn number has wrong value");
            Assert.AreEqual("Frequency:", aacrHomePage.Frequency.Text, "Frequency text is wrong");
            Assert.AreEqual("Biweekly", aacrHomePage.FrequencyValue.Text, "Friquency value number has wrong value");
            Assert.IsTrue(aacrHomePage.EnvelopeIcon.Displayed, "Envelope icon- Subscribe to Etoc is not displayed");
            Assert.AreEqual("Subscribe to eTOC", aacrHomePage.SubscribeToETocTitle.Text, "Subscribe to eTOC text is wrong");
            Assert.AreEqual("Biweekly", aacrHomePage.FrequencyValue.Text, "Friquency value number has wrong value");
            Assert.AreEqual("July 15, 2019 - Volume 13 - Issue 2", aacrHomePage.TitleOfCurrentIssue.Text, "Title of current issue is wrong");
            Assert.AreEqual(aacrHomePage.TitleOfCurrentIssueLink.GetAttribute("href"), @"https://stage-journals.lww.com/aacr/pages/currenttoc.aspx", "Link for Current issue is incorrect" );

       

        }

    }
}
