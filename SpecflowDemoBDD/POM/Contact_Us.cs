using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using QAworks.Test.Project.Helpers;
using System.Configuration;

namespace QAworks.Test.Project.PO
{
    public class Contact_Us
    {
        public WebDriverWait Wait { get; set; }
        public Contact_Us()
        {
            PageFactory.InitElements(Web_Drivers.Driver, this);
            Wait = new WebDriverWait(Web_Drivers.Driver, new TimeSpan(0, 0, 60));
        }





        [FindsBy(How = How.Name, Using = "your-name")] private IWebElement namebox;

        [FindsBy(How = How.Name, Using = "your-email")] private IWebElement emailbox;

        [FindsBy(How = How.Name, Using = "your-company")] private IWebElement subjectbox;

        [FindsBy(How = How.Name, Using = "your-message")] private IWebElement messagebox;

        [FindsBy(How = How.Id, Using = "contact-us-send")] private IWebElement sendBtn;

        [FindsBy(How = How.ClassName, Using = "screen-reader-response")] public IWebElement sendValidation;


        public void Navgiate_to_Contact_Us_page()
        {
            var contactus = ConfigurationManager.AppSettings["BaseUrl"];
            Web_Drivers.Driver.Navigate().GoToUrl(contactus);
        }
        public void Click_Name_Box_link(string Name)
        {
            try
            {
                namebox.SendKeys(Name);
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }


        public void Click_Email_Box(string Email)
        {
            try
            {
                emailbox.SendKeys(Email);
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }

        public void Click_Subject_Box(string Subject)
        {
            try
            {
                subjectbox.SendKeys(Subject);
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }

        public void Click_Message_Box(string Message)
        {
            try
            {
                messagebox.SendKeys(Message);
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }

        public void Click_Send_Button()
        {
            try
            {
                sendBtn.Click();
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }

        public void Maximise()
        {
            Web_Drivers.Driver.Manage().Window.Maximize();
        }


    }
}
