using TechTalk.SpecFlow;
using OpenQA.Selenium.Edge;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using QAworks.Test.Project.Helpers;
using QAworks.Test.Project.PO;

namespace QAworks.Test.Project.Hooks
{
    [Binding]
    public sealed class Drivers
    {
        public static string baseurl = ConfigurationManager.AppSettings["BaseUrl"];
        Contact_Us contact = new Contact_Us();

        [BeforeFeature()]
        public static void BeforeScenario()
        {
            Web_Drivers.Driver = new ChromeDriver();
            Web_Drivers.Driver.Navigate().GoToUrl(baseurl);

        }

        [BeforeScenario]

        public void before()
        {

            contact.Maximise();
        }

        [AfterFeature()]

        public static void AfterScenario()
        {
            Web_Drivers.Driver.Quit();

        }
    }
}
