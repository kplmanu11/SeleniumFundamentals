using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace IDSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/id/";
            string ID = "testImage";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement element;

            try
            {
                element = driver.FindElement(By.Id(ID));
                if (element.Displayed)
                {
                    GreenMessage("ID Element is visible");
                }
            }
            catch (NoSuchElementException)
            {

                RedMessage("ID Element is not visible");
            }

            
          
            driver.Quit();

        }

        private static void RedMessage(string v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(v);
            //Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
