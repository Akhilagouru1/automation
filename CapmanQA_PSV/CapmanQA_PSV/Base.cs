using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CapmanQA_PSV
{

    [TestFixture]
    public class Base
    {
        public IWebDriver driver;
        public IWebElement e1;
        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            //Navigates to NIP dashboard
            driver.Navigate().GoToUrl("http://172.16.21.22:9009/capman-pack-v2/#/nip/dashboard");

            Thread.Sleep(6000);
            
            //Maximizes the Page
            driver.Manage().Window.Maximize();
        }

        //Called after the invocation of each test method in the class
        [TearDown]
        public void Teardown()
        {
            //Closes the browser
            driver.Quit();
        }

        //Method that handles ClickInterceptedException
        public void NonClickableMethod()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", e1);
        }
    }
}
