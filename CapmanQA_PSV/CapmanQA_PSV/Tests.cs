using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace CapmanQA_PSV
{
    public class Tests : Baseclass
    {
        [Test]
        public void TotalPayloadWeeklyPayload()
        {
            TotalPayload();
            Wait();
        }
        [Test]
       public void TotalPayloadServicewisePayload()
        {
            TotalPayload();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/mat-dialog-container/app-nip-dashboard-card-popup/div/div[2]/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]/div")).Click();
            Wait();
        }
        [Test]
        public void TotalPayloadTopSites()
        {
            TotalPayload();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/mat-dialog-container/app-nip-dashboard-card-popup/div/div[2]/mat-tab-group/mat-tab-header/div[2]/div/div/div[3]")).Click();
            Wait();

        }
        [Test]
        public void LowSpectralEfficiencyCellRatioMonthly()
        {
            LowSpectralEfficiencyCellRatio();
            Wait();
        }
        [Test]
        public void LowSpectralEfficiencyCellRatioTopSites()
        {
            LowSpectralEfficiencyCellRatio();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/mat-dialog-container/app-nip-dashboard-card-popup2/div/div[2]/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]/div")).Click();
            Wait();
        }
          [Test]
        public void AvgDlCellThroughputWeekly()
        {
            AvgDlCellThroughput();
            Wait();
        }
        [Test]
        public void AvgDlCellThroughputBandwise()
        {
            AvgDlCellThroughput();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/mat-dialog-container/app-nip-dashboard-card-popup3/div/div[2]/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]/div")).Click();
            Wait();
       }
        [Test]
        public void AvgDlCellThroughputTopSites()
        {
            AvgDlCellThroughput();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/mat-dialog-container/app-nip-dashboard-card-popup3/div/div[2]/mat-tab-group/mat-tab-header/div[2]/div/div/div[3]/div")).Click();
            Wait();
        }
        [Test]
        public void NetworkTotalRevenuMonthlyRevenue()
        {
            NetworkTotalRevenue();
            Wait();
        }
        [Test]
        public void NetworkTotalRevenueServiceWise()
        {
            NetworkTotalRevenue();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/mat-dialog-container/app-nip-dashboard-card-popup4/div/div[2]/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]/div")).Click();
            Wait();
        }
        [Test]
        public void NetworkTotalRevenueTopSites()
        {
            NetworkTotalRevenue();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/mat-dialog-container/app-nip-dashboard-card-popup4/div/div[2]/mat-tab-group/mat-tab-header/div[2]/div/div/div[3]/div")).Click();
            Wait();
        }

        [Test]
        public void ForecastTrendline()
        {
            ExplicitWait();
           // IWebElement button = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dashboard-middle-panel/div/div/div[1]/button/img")));
            e1=driver.FindElement(By.XPath("/html/body/app-root/app-networkinvestplanning/div[2]/app-nip-dashboard/div/mat-tab-group/div/mat-tab-body/div/div/app-nip-dashboard-middle-panel/div/div/div[1]/button/img"));
            NonClickableElement();
            Wait();
        }
       
    }
}