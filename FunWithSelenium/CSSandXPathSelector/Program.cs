using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CSSandXPathSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/css-path/";
            string cssSelector = "#post-108 > div > figure > img";
            string xPathSelector = "//*[@id=\"post-108\"]/div/figure/img";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            IWebElement cssElement = driver.FindElement(By.CssSelector(cssSelector));
            IWebElement xPathElement = driver.FindElement(By.XPath(xPathSelector));

            if (cssElement.Displayed)
            {
                GreenMessage("CSS Element is visible");
            }
            else
            {
                RedMessage("CSS Element is not visible");
            }

            if (xPathElement.Displayed)
            {
                GreenMessage("XPath element is visible");
            }
            else
            {
                RedMessage("XPath Element is not visible");
            }

            driver.Quit();
        }

        private static void GreenMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
        }

        private static void RedMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
        }
    }
}
