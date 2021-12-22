using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NameSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://testing.todorvachev.com/name/");

            IWebElement element = driver.FindElement(By.Name("myName"));
            Console.WriteLine(element.Text);

            if (element.Displayed)
            {
                GreenMessage("Element is visible");
            }
            else
            {
                RedMessage("Element is not visible");
            }

            driver.Quit();

        }

        private static void RedMessage(string v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(v);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    }
