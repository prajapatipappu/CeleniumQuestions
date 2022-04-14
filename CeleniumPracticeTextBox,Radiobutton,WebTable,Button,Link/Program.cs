using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CeleniumPracticeTextBox_Radiobutton_WebTable_Button_Link
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            //Console.Write("Test Case Started:");
            //String FirstName = "Pappu ";
            //String LastName = "Kumar";
            //String Email = "pappukumarbcet2019@gmail.com";
            //String Gender = "Mail";
            //String Mobile = " 8507708583 ";
            //String Date of Birth = "11 jan 2000";
            //String Subjects = "Science";
            //String Hobbies = "Sports";
            //String CurrentAddress = "Sarai";
            //String State and City = "NCR";
            //String Select City = "Delhi";


            IWebDriver Driver = new ChromeDriver();

            //Thread.Sleep(2000);

            //Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            //Thread.Sleep(2000);

            //Driver.Manage().Window.Maximize();

            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("firstName")).SendKeys("Pappu");
            //Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            //Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmil.com");

            ////Driver.FindElement(By.Id("gender-radio-1")).Click();

            //Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();

            //Driver.FindElement(By.Id("userNumber")).SendKeys("8507708583");
            //Driver.FindElement(By.Id("dateOfBirthInput")).Click();
            //Driver.FindElement(By.Id("subjectsContainer")).SendKeys("c#");
            //Driver.FindElement(By.Id("hobbies-checkbox-1")).Click();
            //Driver.FindElement(By.Id("currentAddress")).SendKeys("vaishali");
            //Driver.FindElement(By.Id(" css-1uccc91-singleValue")).Click();
            //Driver.FindElement(By.Id("City")).Click();



            //Driver.FindElement(By.Id("submit")).Click();

            //Task.Delay(120000).Wait();

            //Console.Write("Test Case Closed:");

            //Driver.Close();
            //Driver.Quit();






            //IWebDriver Driver = new ChromeDriver();

            //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            //Thread.Sleep(2000);

            //Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            // Driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);
            // string name = "Pappu Kumar";
            // string email = "pappukumarbcet2019@gmail.com";
            // string Caddress = "sarai";
            // string Paddress = "sarai";

            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("userName")).SendKeys(name);
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("userEmail")).SendKeys(email);
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("currentAddress")).SendKeys(Caddress);
            // Thread.Sleep(2000);
            // Driver.FindElement(By.Id("permanentAddress")).SendKeys(Paddress);

            // Thread.Sleep(2000);
            // js.ExecuteScript("window.scrollBy(0,500)");
            // Thread.Sleep(2000);

            // Driver.FindElement(By.Id("submit")).Click();
            // Task.Delay(2000).Wait();

            // Console.WriteLine("test case ended");


            // Driver.Close();
            //Driver.Quit();


            //IWebDriver Driver = new ChromeDriver();
            //  Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //string Fname = "Pappu";
            //string Lname = "Kumar";
            //string email = "pappukumarbcet2019@gmail.com";
            //string name = "8507708583";
            //string DOB = "11 Jan 2000";
            //string Subjects = "";
            //string hob = "playing cricket";
            //string cadd="sarai";
            //string Padd = "sarai";
            //Driver.FindElement(By.Id("firstName")).SendKeys("pappu");
            //Driver.FindElement(By.Id("lastName")).SendKeys("Kumar");
            //Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            //Thread.Sleep(2000);
            //Driver.FindElements(By.XPath("//div[contains(@class,'custom-control')]"))[0].Click();
            //Driver.FindElement(By.Id("userNumber")).SendKeys("8507708583");
            ////Driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("11 Jan 2000");
            //Driver.FindElement(By.Id("subjectsContainer")).SendKeys("Computer");
            //Driver.FindElement(By.Id("hobbies-checkbox-1")).Click();
            //Driver.FindElement(By.Id("currentAddress")).SendKeys("sarai");
            //Driver.FindElement(By.Id("state")).SendKeys("sarai");

            //Driver.FindElement(By.Id("city")).SendKeys("sarai");

            /// radio button------------------------<>-----------------------

            //Driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
            // Driver.Manage().Window.Maximize();
            // Thread.Sleep(2000);
            //// Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---yes
             //Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[0].Click();//---impressive
            // Driver.FindElements(By.XPath("//label[contains(@class,'custom-control')]"))[1].Click();//--no


            // check box---------------------------<>

            //Driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
            //Driver.Manage().Window.Maximize();

            //Thread.Sleep(2000);

            // Driver.FindElement(By.XPath("//span[contains(@class,'rct-checkbox')]")).Click();




            // Buttons------------------------<>

            //Driver.Navigate().GoToUrl("https://demoqa.com/buttons");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);

            //Driver.FindElement(By.Id("rightClickBtn")).Click();
            //web tables




            //Driver.Navigate().GoToUrl("https://demoqa.com/webtables");
            //Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("addNewRecordButton")).Click();
            //Driver.FindElement(By.Id("firstName")).SendKeys("pappu");
            //Driver.FindElement(By.Id("lastName")).SendKeys("kumar");
            //Driver.FindElement(By.Id("userEmail")).SendKeys("pappukumarbcet2019@gmail.com");
            //Driver.FindElement(By.Id("age")).SendKeys("22");
            //Driver.FindElement(By.Id("salary")).SendKeys("2000");
            //Driver.FindElement(By.Id("department")).SendKeys("IT");
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("submit")).Click();

            //Thread.Sleep(2000);


            //link Table------------------------<>---------------------------------

            //Driver.Navigate().GoToUrl("https://demoqa.com/links");
            //Driver.Manage().Window.Maximize();

            //Driver.FindElement(By.Id("simpleLink")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.Id("dynamicLink")).Click();

            //Thread.Sleep(2000);

            //// Driver.Dispose();
            //Thread.Sleep(2000);
        }
    }

    //    internal class Driver
//    {
//    }
}
