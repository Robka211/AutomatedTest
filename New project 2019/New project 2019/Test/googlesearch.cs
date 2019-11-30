using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace New_project_2019.Test
{
    public class googlesearch
    {
        public void Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("How to find a dragon");
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
    }
}
