using System;
using TechTalk.SpecFlow;
using System.Threading;
using QAworks.Test.Project.PO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using QAworks.Test.Project.Helpers;

namespace QAworks.Test.Project
{
    [Binding]
    public class Contact_UsSteps
    {
        Contact_Us contactUs = new Contact_Us();

        [Given(@"I am on the QAWorks contacts page")]
        public void GivenIAmOnTheQAWorksContactsPage()
        {
            contactUs.Navgiate_to_Contact_Us_page();
        }

        [When(@"I send the ""(.*)"" Name ""(.*)"" Email ""(.*)"" Subject ""(.*)"" Message")]
        public void WhenISendTheNameEmailSubjectMessage(string p0, string p1, string p2, string p3)
        {
            contactUs.Click_Name_Box_link(p0);
            contactUs.Click_Email_Box(p1);
            contactUs.Click_Subject_Box(p2);
            contactUs.Click_Message_Box(p3);

        }


        [Then(@"I should see ""(.*)""")]
        public void ThenIShouldSee(string p0)
        {


            contactUs.Click_Send_Button();
            Thread.Sleep(6000);
            Assert.AreEqual(p0, EmailValidation());
        }


        private string EmailValidation()
        {
            return contactUs.sendValidation.Text;
        }
    }
}
