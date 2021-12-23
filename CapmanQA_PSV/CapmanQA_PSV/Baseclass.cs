using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace CapmanQA_PSV
{
    [TestFixture]
    public class Baseclass
    {
        public WebDriverWait wait;
        public IWebElement ele,e1;
            public IWebDriver driver;
            [SetUp]
            public void Launch()
            {
                //Launching Chrome browser
                driver = new ChromeDriver();
                //Giving URL
                driver.Navigate().GoToUrl("http://172.16.21.22:9009/capman-pack-v2/#/nip/dashboard");
                //Maximizing the window
                driver.Manage().Window.Maximize();
                
            }
        public void ExplicitWait()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
        }
        public void Wait()
        {
            Thread.Sleep(5000);
        }

        public void ClickButton(IWebElement ele)
             {
                ele.Click();
             }
        public void NonClickableElement()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", e1);
        }
       
        public void TotalPayload()
        {
            ExplicitWait();
            IWebElement button = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[1]/div/button/img")));
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[1]/div/button/img"));
            e1.Click();
         
        }
        public void LowSpectralEfficiencyCellRatio()
        {
            ExplicitWait();
            IWebElement button = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[2]/div/button/img")));
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[2]/div/button/img"));
            e1.Click();
            
        }
        public void AvgDlCellThroughput()
        {
            ExplicitWait();
            IWebElement button = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[3]/div/button/img")));
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[3]/div/button/img"));
            e1.Click();
        }
        public void NetworkTotalRevenue()
        {
            ExplicitWait();
            IWebElement button = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[4]/div/button/img")));
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dasboard-top-panel/div/div[4]/div/button/img"));
            e1.Click();
        }

        [TearDown]
            public void Teardown()
            {
            //Closes all the browser once action is done
            driver.Quit();
            }

   }
}
