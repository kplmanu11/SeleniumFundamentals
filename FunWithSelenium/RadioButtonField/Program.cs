using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace RadioButtonField
{
    class Program
    {
        static IWebDriver driver ;
        static IWebElement element;

        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/radio-button-test/";
            
            //#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            string[] options = { "1", "3", "5" };
            for (int i = 0; i < options.Length; i++)
            {
                
                element = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + options[i] + ")"));

                //if (element.GetAttribute("checked") == "true")
                //{
                //    Console.WriteLine("The " + (i+1) +" radio button is checked");
                //}
                //else
                //{
                //    Console.Write("The radio button is unchecked");
                //}
                if (i == 2)
                {
                    element.Click();
                    Console.WriteLine("Female radio button is clicked");
                }
            }
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
