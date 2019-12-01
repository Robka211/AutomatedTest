using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace New_project_2019.Test
{
    public class ClearTexBox
    {
        public void Clear()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("How to find a cat");
            Thread.Sleep(2000);
            driver.FindElement(By.Name("q")).Clear();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
    }
}