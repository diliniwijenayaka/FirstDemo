using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnect.Pages
{
    class TimeMaterialPage
    {
        public void AddTimeMaterial(IWebDriver driver)
        {
            //Click on Create New button
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNew.Click();

            //Select TypeCode - Time
            IWebElement TypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            TypeCode.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement Time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Time.Click();

            //Enter  a value for Code
            IWebElement Code = driver.FindElement(By.XPath("//*[@id='Code']"));
            Code.SendKeys("123TestCode");

            //Enter the Description
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='Description']"));
            Description.SendKeys("Test Description");

            // Enter the price 
            IWebElement Price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Price.Clear();
            //IWebElement Price1 = driver.FindElement(By.XPath("//*[@id='Price']"));
            IWebElement Price1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Price1.SendKeys("200");

            //Click on the Save button
            IWebElement Save = driver.FindElement(By.Id("SaveButton"));
            Save.Click();

            //Check if Time and Material created successfully
            System.Threading.Thread.Sleep(2000);
            //IWebElement ForwardButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            IWebElement ForwardButton = driver.FindElement(By.XPath("//*[@title='Go to the last page']"));
            ForwardButton.Click();
            System.Threading.Thread.Sleep(4000);
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Text == "123TestCode")
            {
                Console.WriteLine("Time and Material added successfully");
            }
            else
            {
                Console.WriteLine("Item is not visible. Test failed");
            }
        }

        public void EditTimeMaterial(IWebDriver driver)
        {
            // Locate and click on the Edit button
            System.Threading.Thread.Sleep(2000);
            IWebElement Edit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[1]"));
            Edit.Click();

            //Edit the Time and Material
            //Change the TypeCode
            IWebElement EditTypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            EditTypeCode.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement SelectMaterial = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            SelectMaterial.Click();

            //Edit the Code
            IWebElement EditCode = driver.FindElement(By.XPath("//*[@id='Code']"));
            EditCode.Clear();
            IWebElement EditCode1 = driver.FindElement(By.XPath("//*[@id='Code']"));
            EditCode1.SendKeys("Edited Code");

            //Edit Description
            IWebElement EditDescription = driver.FindElement(By.XPath("//*[@id='Description']"));
            EditDescription.Clear();
            IWebElement EditDescription1 = driver.FindElement(By.XPath("//*[@id='Description']"));
            EditDescription1.SendKeys("Edited Description");

            //Edit Price
            //IWebElement EditPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //EditPrice.Clear();
            //IWebElement EditPrice2 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //EditPrice2.Clear();
            //System.Threading.Thread.Sleep(1000);
            //IWebElement EditPrice1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //EditPrice1.SendKeys("500");

            //Click on Save Button
            IWebElement SaveEdit = driver.FindElement(By.Id("SaveButton"));
            SaveEdit.Click();

            //Check Edited Time and Material saved successfully
            System.Threading.Thread.Sleep(2000);
            //IWebElement ForwardButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            IWebElement ForwardButton1 = driver.FindElement(By.XPath("//*[@title='Go to the last page']"));
            ForwardButton1.Click();

            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text == "Edited Code")
            {
                Console.WriteLine("Time and Material Edited successfully");
            }
            else
            {
                Console.WriteLine("Edited item could not be found. Test failed");
            }
        }

        public void DeleteTimeMaterial(IWebDriver driver)
        {
            //Locate Delete button and delete the edited item
            IWebElement Delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[5]/a[2]"));
            Delete.Click();

            //Capture the text appear in the alart box
            String alart = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alart);
            if (alart == "Are you sure you want to delete this record?")
            {
                driver.SwitchTo().Alert().Accept();
                Console.WriteLine("Deleted successfully, Test passed");
            }
            else
            {
                Console.WriteLine("Deleted Test failed");
            }
        }
    }
}
