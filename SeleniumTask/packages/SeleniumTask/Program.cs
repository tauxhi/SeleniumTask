using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //to open website on browser 
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://subscribe.stctv.com/kw-en";
            driver.Manage().Window.Maximize();

            //to scroll down the page on specific position using Javascript executer 
            IJavaScriptExecutor JE = driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(5000);
            JE.ExecuteScript("window.scrollBy(0,250);");
            Thread.Sleep(5000);
            // to scroll up
            JE.ExecuteScript("window.scrollTo(0, 0)");

            Thread.Sleep(3000);
            // to open Country dropdown from top navbar
            driver.FindElement(By.XPath("//a[@id='country-btn']")).Click();
            Thread.Sleep(1000);
            //Click on KSA flag
            driver.FindElement(By.XPath("//a[@id='sa']")).Click();
            IJavaScriptExecutor JE1 = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            JE1.ExecuteScript("window.scrollBy(0,250);");
            Thread.Sleep(3000);
            JE.ExecuteScript("window.scrollTo(0, 0)");

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//a[@id='country-btn']")).Click();
            Thread.Sleep(1000);
            //Click on Bahrain flag
            driver.FindElement(By.XPath("//a[@id='bh']")).Click();
            IJavaScriptExecutor JE2 = driver as IJavaScriptExecutor;
            Thread.Sleep(5000);
            JE2.ExecuteScript("window.scrollBy(0,250);");
            Thread.Sleep(5000);
            JE.ExecuteScript("window.scrollTo(0, 0)");

            //To move cursor at specific position
            //Actions action = new Actions(driver);
            //action.MoveByOffset(400, 200).Perform();
            //Thread.Sleep(10000);
            //action.Click();

            Console.Read();
        }


       


    }
}
