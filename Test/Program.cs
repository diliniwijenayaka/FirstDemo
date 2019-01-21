using IndustryConnect.Helpers;
using IndustryConnect.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IndustryConnect.Test
{
    [TestFixture]
    class Program
    
    {
        [SetUp]
        public void loginNavigate()
        {
            CommonDriver.driver = new ChromeDriver(@"C:\Users\User\source\repos\IndustryConnect\IndustryConnect\chromedriver_win32");

            LoginPage LoginObj = new LoginPage();            //Common Step 
            LoginObj.LoginSteps(CommonDriver.driver);

            HomePage HomeObj = new HomePage();               //Common Step 
            HomeObj.NavigateToTM(CommonDriver.driver);

        }

        [Test]
        public void AddTM()
        {
            TimeMaterialPage TimeMaterialObj = new TimeMaterialPage();  //test
            TimeMaterialObj.AddTimeMaterial(CommonDriver.driver);
        }

        [Test]
        public void EditTM()
        {
            TimeMaterialPage TimeMaterialObj = new TimeMaterialPage();
            TimeMaterialObj.EditTimeMaterial(CommonDriver.driver);  //test
        }

        [Test]
        public void DeleteTM()
        {
            TimeMaterialPage TimeMaterialObj = new TimeMaterialPage();
            TimeMaterialObj.DeleteTimeMaterial(CommonDriver.driver); //test
        }

        [TearDown]
        public void exitWindow()
        {
            CommonDriver.driver.Close(); //teardown
        }

        static void Main(string[] args) 
        {
            }

    }
}
