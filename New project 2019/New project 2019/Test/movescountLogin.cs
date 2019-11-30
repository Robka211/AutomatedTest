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
  public  class movescountLogin
    {
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.movescount.com/");
            driver.Manage().Window.FullScreen();
            driver.FindElement(By.XPath("//li[@class='row-flex row-flex--middle']//a[contains(@class,'button--cancel button')][contains(text(),'Sign in')]")).Click();
            driver.FindElement(By.Id("splEmail")).SendKeys("gerasimovic.r@gmail.com");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("splPassword")).SendKeys("robka211");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@id='splLoginButton']")).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

        }
    }

}
