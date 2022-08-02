using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using NPOI.XSSF.UserModel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using TideBDDProject.Utilities;
using System.Collections.ObjectModel;
namespace TideBDDProject.CommonObjectMethod
{
    public class commonMethod : Utilities.BaseClass
    {
        public void OpenTideURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);

        }
        public void Register()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
            Thread.Sleep(1000);
        }
        public void SignUP()
        {
            BaseClass.driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();


            ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);


            }
            Thread.Sleep(5000);
          

            BaseClass.driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("Prabha");
            BaseClass.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("rakhi.ag991@gmail.com");
            BaseClass.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Abcde@12345");
        }
        public void ClickOnCreateAccount()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
            BaseClass.driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/account-setup/tide-coupons/");
            BaseClass.driver.FindElement(By.XPath("//*[@id='__next']/div/div[2]/div[2]/div/div[1]/div/div[4]/button")).Click();


        }


        public void OpenTideURL1()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void OpenLoginPage()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
            Thread.Sleep(1000);

            //BaseClass.driver.FindElement(By.XPath("//*[@id='scroll']/div/div/div/div/div[2]/form/div[7]/div/button"));

            BaseClass.driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/login/");
            
            Thread.Sleep(1000);
        }
        public void EnterInformation()
        {
            

            BaseClass.driver.FindElement(By.XPath("//input[@name='signInEmailAddress']")).SendKeys("rakhi.ag991@gmail.com");

            BaseClass.driver.FindElement(By.XPath("//input[@name='currentPassword']")).SendKeys("Abcde@12345");
            
        
        }
        public void ClickOnLogin()
        {


            BaseClass.driver.FindElement(By.XPath("//input[@value='LOG IN']")).Click();
            BaseClass.driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/coupons/"); ;
            Thread.Sleep(1000);

        }


        public void Url()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);

        }
        public void ClickOnWashClothes()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@data-action-detail='How to Wash Clothes']")).Click();

        }
        public void FindStainRemoval()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us/shop/special-needs/stain-removal");
            BaseClass.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        public void Url2()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void ClickOnLocation()
        {
            BaseClass.driver.FindElement(By.XPath("//button[text()='US - English']")).Click();
        }

        public void Url3()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void ClickOnShopProduct()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/shop']")).Click();
        }
        public void FindProductByRating()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//select[@aria-label='Sort products by']")).Click();
        }
        public void SelectProductRating()
        {
            BaseClass.driver.FindElement(By.XPath("//option[@value='title_az']")).Click();
        }


        public void Url4()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);

        }
        public void ContactUs()
        {
            BaseClass.driver.FindElement(By.XPath("//a[text()='Contact Us']")).Click();
            Thread.Sleep(1000);
        }


        public void Url5()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void SearchProduct()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@aria-label='Search']")).SendKeys("Product");

            BaseClass.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();

        }

        public void Url6()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void OpenLiveChat()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
        }


        public void Site()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void FindNewProducts()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/latest-news']")).Click();
        }
        public void SearchArticleSection()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us/latest-news");
        
            BaseClass.driver.FindElement(By.XPath("//*[@id='site-content']/div/div/div/div[3]/div[1]/div/div/div/section/div[2]/div[2]/div/a")).Click();
            Thread.Sleep(1000);
        }


        public void TideUrl3()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }

        public void OpenCouponAndRewards()
        {
            //obj = extents.CreateTest("OpenCouponAndRewards").Info("Test Started");
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/coupons-and-rewards']")).Click();
        }
        public void Save()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us/coupons-and-rewards");
           BaseClass.driver.FindElement(By.XPath("//a[@href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click();
            ReadOnlyCollection<string> tabss = BaseClass.driver.WindowHandles;
            foreach (string tab in tabss)
            {
                BaseClass.driver.SwitchTo().Window(tab);

            }
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//input[@name='firstName']")).SendKeys("PrabhaAgrawal");
            BaseClass.driver.FindElement(By.XPath("//input[@name='emailAddress']")).SendKeys("xyz.ag991@gmail.com");
            BaseClass.driver.FindElement(By.XPath("//input[@name='newPassword']")).SendKeys("Abccde@12345");

            BaseClass.driver.FindElement(By.XPath("//*[@id='scroll']/div/div/div/div/div[2]/form/div[6]/div/input")).Click();

        }
        public void LoginAccount()
        {
            

            ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            foreach(string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);


            }
            Thread.Sleep(5000);
        

            string path = @"C:\Users\DELL\source\repos\DataExcelSheet.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var validFirstName = workbook.GetSheetAt(0).GetRow(0).GetCell(0).StringCellValue.Trim();
            var validEmail = workbook.GetSheetAt(0).GetRow(0).GetCell(0).StringCellValue.Trim();
            var validPass = workbook.GetSheetAt(0).GetRow(0).GetCell(0).StringCellValue.Trim();

            //obj.Log(Status.Debug, "Accessed data from excel sheet");
            //obj.Log.Debug("Accessed data and Entered Successfully");

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("validFirstName");
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("validEmail");

            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("validPass");           
            Thread.Sleep(1000);

            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile
           (@"C:\Users\DELL\source\repos\TideBDDProject\TideBDDProject\Screenshot\validSignUp.png");
            
           

            // Log.Information("Executed_Successfully");
        }
        



    }
}
