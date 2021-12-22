using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ClassNameSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/class-name/";
            string className = "testClass";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.ClassName(className));

            Console.WriteLine(element.Text);

            driver.Quit();


        }
    }
}
