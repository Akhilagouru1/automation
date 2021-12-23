using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CapmanQA_PSV
{
    public class Tests : Base
    { 
        [Test]
        public void HierarchyFilter()
        {
            //Waits for 40 seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

            //Click on the symbol at top right corner of the page
            driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/div/app-filter-button/button/img")).Click();

            //Click on 'Global Filter'
            driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/app-filter-panel/mat-sidenav/div/div/div/mat-tab-group/div/mat-tab-body[1]/div/mat-accordion/mat-expansion-panel[1]/mat-expansion-panel-header/span[1]")).Click();

            //Click on 'Selct Network' dropdown and deselects 'Default'
            driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/app-filter-panel/mat-sidenav/div/div/div/mat-tab-group/div/mat-tab-body[1]/div/mat-accordion/mat-expansion-panel[1]/div/div/div/div[1]/mat-form-field/div/div[1]/div/mat-select/div/div[1]/span")).Click();
            e1 = driver.FindElement(By.CssSelector("#mat-option-0 > mat-pseudo-checkbox"));
            //Calls 'NonClickableMethod' from 'Base' class
            NonClickableMethod();
            //Click anywhere on the screen 
            driver.FindElement(By.XPath("/html/body/div[5]/div[1]")).Click();

            //Click on 'Technology' dropdown and selects '5G'
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/app-filter-panel/mat-sidenav/div/div/div/mat-tab-group/div/mat-tab-body[1]/div/mat-accordion/mat-expansion-panel[1]/div/div/div/div[2]/mat-form-field/div/div[1]/div"));
            NonClickableMethod();
            e1 = driver.FindElement(By.CssSelector("#mat-option-3 > span"));
            NonClickableMethod();

            //Click on 'Clear' button
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/app-filter-panel/mat-sidenav/div/div/div/mat-tab-group/div/mat-tab-body[1]/div/mat-accordion/mat-expansion-panel[1]/div/div/div/div[4]/button[1]"));
            NonClickableMethod();

            //Click on 'Vendor' dropdown and selects 'Nokia'
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/app-filter-panel/mat-sidenav/div/div/div/mat-tab-group/div/mat-tab-body[1]/div/mat-accordion/mat-expansion-panel[1]/div/div/div/div[3]/mat-form-field/div/div[1]/div/mat-select/div/div[2]/div"));
            NonClickableMethod();
            e1 = driver.FindElement(By.CssSelector("#mat-option-5 > div"));
            NonClickableMethod();
            //Click anywhere on the screen
            driver.FindElement(By.XPath("/html/body/div[5]/div[1]")).Click();
          
            //Click on 'Apply' button
            e1 = driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/app-filter-panel/mat-sidenav/div/div/div/mat-tab-group/div/mat-tab-body[1]/div/mat-accordion/mat-expansion-panel[1]/div/div/div/div[4]/button[2]"));
            NonClickableMethod();
            Thread.Sleep(2000);

            //Click on 'Network Element'
            driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/app-filter-panel/mat-sidenav/div/div/div/mat-tab-group/div/mat-tab-body[1]/div/mat-accordion/mat-expansion-panel[2]/mat-expansion-panel-header")).Click();
           //  driver.FindElement(By.XPath(""));
        }
        [Test]
        public void TotalPayload()
        {
            //WebDriver wait = new WebDriverWait
            //try
            //{
                 driver.FindElement(By.XPath("//mat-tab-body[@id='mat-tab-content-1-0']/div/div/app-nip-dasboard-top-panel/div/div/div/button/img")).Click();
            //}catch(NoSuchElementException)
            //{

            //}
            //driver.FindElement(By.XPath("")).Click();
        }
    }
}