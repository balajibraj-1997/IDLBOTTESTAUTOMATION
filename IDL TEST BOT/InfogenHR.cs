//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace IDL_TEST_BOT
//{
//    [TestFixture]
//    internal class InfogenHR
//    {
//        IWebDriver driver;
//        string url = "https://flow.runday.ai/runday/infogenhr";
//        [SetUp]
//       public void setup() 
//        {
//            driver = new ChromeDriver();
//            driver.Navigate().GoToUrl(url);
//            driver.Manage().Window.Maximize();
//            Thread.Sleep(8000);
//        }
//        [Test]
//        [Ignore("skip this test")]
//        public void Infogen()
//        {
//            //Click on yes
//            driver.FindElement(By.XPath("//p[text()='Yes']")).Click();
//            Thread.Sleep(4000);
//            //Enter First name
//            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Balaji");
//            Thread.Sleep(3000);
//            //click on next icon
//            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
//            Thread.Sleep(4000);
//            //Enter Last name
//            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Balaji");
//            Thread.Sleep(3000);
//            //click on next icon
//            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
//            Thread.Sleep(4000);
//            //Enter your Email
//            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("infogenbengaluru@gmail.com");
//            Thread.Sleep(3000);
//            //click on next icon
//            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
//            Thread.Sleep(4000);
//            //Click on yes
//            driver.FindElement(By.XPath("//p[text()='Yes']")).Click();
//            Thread.Sleep(4000);
//            //Enter your phone num
//            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("9686139206");
//            Thread.Sleep(3000);
//            //click on next icon
//            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
//            Thread.Sleep(4000);

//            //Click on resume upload
//            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Users\Balaji\Downloads\Zomato logo.jpg");

//        }
//        [TearDown]
//        public void end()
//        {
//            //driver.Quit();
//        }

//    }
//}
