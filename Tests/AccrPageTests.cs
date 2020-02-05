using ClassLibrary1.BusinessCase;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{

    [TestFixture] // атрибут тестово класса

       public class AacrPageTests :BaseTestCalss  // наследование, чтоб бразуер открылся, до теста, а затем закрыл брайзер  - заклинапился
    {
        [Test]

        public void Verify_Page_Appearance()// наподобии BDD- четко видны наши сценарии
        {
           
            JournalPage.NavigateToAacrHomePage();

            JournalPage.VerifyPageAppearance();

            JournalPage.VerifyCurrentIssueDerscription();     


        }

    }
}
