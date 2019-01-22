using IndustryConnect.Helpers;
using IndustryConnect.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IndustryConnect.StepDefinitions
{
    [Binding]
    public class TimeandMaterialSteps
    {
        [Given(@"I have logged into the portal")]
        public void GivenIHaveLoggedIntoThePortal()
        {
            CommonDriver.driver = new ChromeDriver(@"C:\Users\User\source\repos\IndustryConnect\IndustryConnect\chromedriver_win32");

            LoginPage LoginObj = new LoginPage();             
            LoginObj.LoginSteps(CommonDriver.driver);
        }
        
        [Given(@"I have navigated to the Time and Material Page")]
        public void GivenIHaveNavigatedToTheTimeAndMaterialPage()
        {
            HomePage HomeObj = new HomePage();               //Common Step 
            HomeObj.NavigateToTM(CommonDriver.driver);
        }
        
        [Then(@"I have added Time and Material successfully")]
        public void ThenIHaveAddedTimeAndMaterialSuccessfully()
        {
            TimeMaterialPage TimeMaterialObj = new TimeMaterialPage();  //test
            TimeMaterialObj.AddTimeMaterial(CommonDriver.driver);
        }

        [Then(@"I have edited the added Time and Material Successfully")]
        public void ThenIHaveEditedTheAddedTimeAndMaterialSuccessfully()
        {
            TimeMaterialPage TimeMaterialObj = new TimeMaterialPage();
            TimeMaterialObj.EditTimeMaterial(CommonDriver.driver);
        }

        [Then(@"I have deleted the edited Time and Materil successfully")]
        public void ThenIHaveDeletedTheEditedTimeAndMaterilSuccessfully()
        {
            TimeMaterialPage TimeMaterialObj = new TimeMaterialPage();
            TimeMaterialObj.DeleteTimeMaterial(CommonDriver.driver);
        }


    }
}
