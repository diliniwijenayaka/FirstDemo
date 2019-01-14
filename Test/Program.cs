using IndustryConnect.Helpers;
using IndustryConnect.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnect.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            CommonDriver.driver = new ChromeDriver(@"C:\Users\User\source\repos\IndustryConnect\IndustryConnect\chromedriver_win32");

            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginSteps(CommonDriver.driver);

            HomePage HomeObj = new HomePage();
            HomeObj.NavigateToTM(CommonDriver.driver);

            TimeMaterialPage TimeMaterialObj = new TimeMaterialPage();
            TimeMaterialObj.AddTimeMaterial(CommonDriver.driver);

            TimeMaterialObj.EditTimeMaterial(CommonDriver.driver);

            TimeMaterialObj.DeleteTimeMaterial(CommonDriver.driver);

        }

    }
}
