using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace CheckBoxField
{
    class Program
    {
        static IWebDriver driver;
        static IWebElement element;
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/check-button-test-3/";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            string options = "1";

            element = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + options + ")"));
            element.Click();
            Thread.Sleep(3000);
            Console.WriteLine(element.GetAttribute("value"));

            options = "3";
            element = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + options + ")"));
            bool x = element.Selected;
            if (x == true)
            {
                element.Click();
            }
            Thread.Sleep(3000);
            Console.WriteLine(element.GetAttribute("value"));




            driver.Quit();

        }
    }
}
