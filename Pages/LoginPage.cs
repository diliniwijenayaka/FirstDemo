using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnect.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //Initiate the browser
            

            //Maximise the browser
            driver.Manage().Window.Maximize();

            //Load the webpage
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Locate the password textbox and fill in the value
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Locate the password textbox and fill in the value
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //Locate the login button and click on it
            IWebElement LogIn = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LogIn.Click();
            //System.Threading.Thread.Sleep(5000);

            //Check if the homepage is loaded
            IWebElement HelloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (HelloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully. Test Passed");
            }
            else
            {
                Console.WriteLine("Log in page not visible. Test Failed");
            }

        }
    }
}
