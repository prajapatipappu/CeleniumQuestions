using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CeleniumPracticeQuestion02
{
    internal class Program
    {
        public static object By { get; private set; }

        static void Main(string[] args)
        {

            Console.Write("Test Case Started:");
            String FirstName = "Pappu ";
            String LastName = "Kumar";
            String Email = "pappukumarbcet2019@gmail.com";
            String Gender = "Mail";
            String Mobile = " 8507708583 ";
            String Date of Birth = "11 jan 2000";
            String Subjects = "Science";
            String Hobbies = "Sports";
            String CurrentAddress = "Sarai";
            String State and City = "NCR";
            String Select City = "Delhi";


            IWebDriver Driver = new ChromeDriver();

            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

            Driver.FindElement(By.Id("firstName")).SendKeys(FirstName);
            Driver.FindElement(By.Id("lastName")).SendKeys(LastName);
            Driver.FindElement(By.Id("userEmail")).SendKeys(Email);

            //Driver.FindElement(By.Id("gender-radio-1")).Click();

            Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();

            Driver.FindElement(By.Id("userNumber")).SendKeys(Mobile);
            Driver.FindElement(By.Id("dateOfBirthInput")).Click();
            Driver.FindElement(By.Id("subjectsContainer")).SendKeys(Subjects);
            Driver.FindElement(By.Id("currentAddress")).SendKeys(CurrentAddress);
            Driver.FindElement(By.Id("Select State")).Click();
            Driver.FindElement(By.Id("Select City")).Click();



            Driver.FindElement(By.Id("submit")).Click();

            Task.Delay(120000).Wait();

            Driver.Close();
            Driver.Quit();
        }
    }
}
