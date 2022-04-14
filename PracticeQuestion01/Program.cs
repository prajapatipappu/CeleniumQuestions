using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeQuestion01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");
            String Name = "Pappu Kumar";
            String Email = "pappukumarbcet2019@gmail.com";
            String Cadd = "Sarai vaishali(Bihar)";
            String Padd = " Vaishali Bihar ";

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;


            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userName")).SendKeys(Name);

            Driver.FindElement(By.Id("userEmail")).SendKeys(Email);

            Driver.FindElement(By.Id("currentAddress")).SendKeys(Cadd);

            Driver.FindElement(By.Id("permanentAddress")).SendKeys(Padd);

            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);


            Driver.FindElement(By.Id("submit")).Click();

            Task.Delay(120000).Wait();

            Console.Write("Test Case Closed:");

            Driver.Close();
            Driver.Quit();






        }
    }
}
