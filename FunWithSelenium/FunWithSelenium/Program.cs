using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace FunWithSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            Thread.Sleep(3000);
            driver.Quit();
     
        }
    }
}
