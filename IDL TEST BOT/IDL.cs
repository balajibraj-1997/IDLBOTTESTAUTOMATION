using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDL_TEST_BOT
{
    [TestFixture]
    internal class IDL
    {
        IWebDriver driver;
        string url = "https://flow.runday.ai/runday/idltest";

        [SetUp]
        public void Open()
        {

            driver = new ChromeDriver();

            //Maximize browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
           
        }
        //[Ignore("Skip this test")]
        [Test]
        public void SignUp()
        {

            //wait for some Time
            var wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//p[@class='!text-chatbot-secondary-text'])[2]")));


            Thread.Sleep(5000);
            //Enter your Full name
            driver.FindElement(By.XPath("/input[@type='text']")).SendKeys("infogen labs");
            Thread.Sleep(4000);

            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);

            //Enter your Phone number
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("9012345670");
            Thread.Sleep(4000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);

            //Enter your email id
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("infogenbengaluru@gmail.com");
            Thread.Sleep(4000);
            //click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);

            
            //Click on west coast
            driver.FindElement(By.XPath("//p[contains(text(),'East Coast')]/following::button[1]")).Click();
            Thread.Sleep(5000);

            //wait for some Time
            var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(text(),'Lets schedule your interview with your matchmaker. What’s a good day?')]")));

            Thread.Sleep(3000);

            //Select Time
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //IWebElement Time = wait4.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='12:30 PM' or text()='3:30 PM' or text()='10:30 AM' or text()='11:30 AM' or text()='1 PM']")));
            IWebElement Time = wait4.Until(ExpectedConditions.ElementExists(By.XPath("(//button[starts-with(@class,'!rounded-md !bg-chatbot-primary !text-chatbot-primary-text !py-3 !drop-shadow-lg !text-center focus:!outline-none !text-chatbot-base')])")));

            Time.Click();

            //wait for some Time
            var wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[text()='IDL Test']")));

            Thread.Sleep(4000);
            //Enter your Facebook ID
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Infogen");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);

            //Enter your City
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Bangalore");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);

            //Enter your Original city
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("India");
            Thread.Sleep(3000);




            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);



            //Enter your birth date and year
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("31/08/1997");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);

            //Enter your maximum age for your partner
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("25");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(4000);

            //Enter your horoscope sign
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Cancer");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);

            //Click on never married
            driver.FindElement(By.XPath("//p[text()='Never married']")).Click();
            Thread.Sleep(5000);

            //Enter your Maximum height
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("6 1");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);

            //Click on Asian(Ethnicity)
            driver.FindElement(By.XPath("//p[text()='Asian']")).Click();
            Thread.Sleep(5000);


            //Select your relegion background
            driver.FindElement(By.XPath("//p[text()='East Asian']")).Click();
            Thread.Sleep(5000);



            //Selct your partners relegion 
            driver.FindElement(By.XPath("//p[text()='Hindu']")).Click();
            Thread.Sleep(5000);

            //Select your education level
            driver.FindElement(By.XPath("//p[text()='Bachelors Degree']")).Click();
            Thread.Sleep(5000);

            //Enter your occuption
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("QA Engineer");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(3000);

            //Enter your daily routine
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Automation testing");
            Thread.Sleep(3000);
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);
            
            //Click on No(Do yo have any children)
            driver.FindElement(By.XPath("//p[text()='No']")).Click();
            Thread.Sleep(5000);

            //Select your hair colour
            driver.FindElement(By.XPath("//p[text()='Black']")).Click();
            Thread.Sleep(5000);

            //Select your eye colour
            driver.FindElement(By.XPath("//p[text()='Blue']")).Click();
            Thread.Sleep(5000);

            //Enter languages 
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Kannada,English");
            Thread.Sleep(3000);
            
            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);

            //Enter your  political affiiation(None)
            driver.FindElement(By.XPath("//p[text()='None']")).Click();
            Thread.Sleep(5000);

            //click on No(Do you drink Alchohol)
            driver.FindElement(By.XPath("//p[text()='No']")).Click();
            Thread.Sleep(5000);

            //Click on No(would you date someone who drinks Alchohol)
            driver.FindElement(By.XPath("(//p[text()='No'])[2]")).Click();
            Thread.Sleep(5000);

            //Click on No(Do you smoke nicotine cigarettes)
            driver.FindElement(By.XPath("(//p[text()='No'])[3]")).Click();
            Thread.Sleep(5000);

            //Click on No(Do you smoke weed)
            driver.FindElement(By.XPath("(//p[text()='No'])[3]")).Click();
            Thread.Sleep(5000);

            //Click on No(would you date someone who who smokes cigarettes)
            driver.FindElement(By.XPath("(//p[text()='No'])[3]")).Click();
            Thread.Sleep(5000);

            //click on yes(Do you have pets)
            driver.FindElement(By.XPath("(//p[text()='Yes'])")).Click();
            Thread.Sleep(5000);

            //Click on Any(Do you have any pet allergies)
            driver.FindElement(By.XPath("(//p[text()='Any'])")).Click();
            Thread.Sleep(5000);

            //Enter activities
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Playing ,reading,travelling,learning");
            Thread.Sleep(3000);

            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);

            //What are you looking for a partner
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Sincere ,innocent,Kind");
            Thread.Sleep(3000);

            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);

            //What do you want big picture relationship wise
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Kids");
            Thread.Sleep(3000);

            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);

            //Preferred marital status
            driver.FindElement(By.XPath("//p[text()='Never married']")).Click();
            Thread.Sleep(5000);

            //Do you have a preferred ethnicity or are you open?
            driver.FindElement(By.XPath("//p[text()='Indian']")).Click();
            Thread.Sleep(5000);

            //Ideally, how much should your match make
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("50000");
            Thread.Sleep(3000);

            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);


            //Preferred minimum height of your match?
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("6");
            Thread.Sleep(3000);

            //Click on Arrow
            driver.FindElement(By.XPath("(//*[@fill='none'])[2]")).Click();
            Thread.Sleep(5000);

            //What type of body do you prefer?
            driver.FindElement(By.XPath("//p[text()='Average']")).Click();
            Thread.Sleep(5000);

            //Would you date someone with children?
            driver.FindElement(By.XPath("//p[text()='No']")).Click();
            Thread.Sleep(5000);


            //Would you date someone who wants to have children?
            driver.FindElement(By.XPath("(//p[text()='No'])[2]")).Click();
            Thread.Sleep(5000);

            //Would you date someone who has pets?
            driver.FindElement(By.XPath("(//p[text()='Yes'])")).Click();
            Thread.Sleep(5000);


            //Do you have a dietary restrictions that matter in your match
            driver.FindElement(By.XPath("(//p[text()='Yes'])[2]")).Click();
            Thread.Sleep(5000);

         }

        [TearDown]
        public void Close()
        {
            // driver.Quit();
        }

    }
}

    

