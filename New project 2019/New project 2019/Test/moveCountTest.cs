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
    public static class moveCountTest
    {
        public static void FillRegitrationForm()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.movescount.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[contains(@class,'button--action button')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("sprEmail")).SendKeys("test@email.com");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("sprReEmail")).SendKeys("test@email.com");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("sprPassword")).SendKeys("suunto123");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("sprRePassword")).SendKeys("suunto123");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("sprUsername")).SendKeys("Crazymen");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//i[@id='sprContactMcSuunto']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
            driver.Close();
        }
    }
}
