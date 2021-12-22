using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TextBoxField
{
    class Program
    {
        static IWebDriver driver;
        static IWebElement element;
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/text-input-field/";

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            element = driver.FindElement(By.Name("username"));

            element.SendKeys("Hey wassup");
            Thread.Sleep(3000);
            Console.WriteLine(element.GetAttribute("value"));
            driver.Quit();
        }
    }
}
