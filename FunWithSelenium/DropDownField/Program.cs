using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace DropDownField
{
    class Program
    {
        static IWebDriver driver = new ChromeDriver();
       
        static IWebElement selectionFromDropdown;
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/drop-down-menu-test/";
            string selectedDropdown = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
            driver.Navigate().GoToUrl(url);

            //element = driver.FindElement(By.Name("DropDownTest"));

            //Console.WriteLine("The initial selected value is " + element.GetAttribute("value"));

            //selectionFromDropdown = driver.FindElement(By.CssSelector(selectedDropdown));

            //selectionFromDropdown.Click();
            //Console.WriteLine("After Selection Value " + selectionFromDropdown.GetAttribute("value"));

            //Thread.Sleep(3000);
            for(int i =1; i <= 4; i++)
            {
                selectedDropdown = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+ i+")";
                selectionFromDropdown = driver.FindElement(By.CssSelector(selectedDropdown));
                Console.WriteLine("The selected value is :" + selectionFromDropdown.GetAttribute("value"));
            }
            Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
