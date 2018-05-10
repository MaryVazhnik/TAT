using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://av.by/");
            driver.FindElement(By.ClassName("js-brands-show-all")).Click();
            CarPage carPage = new CarPage(driver);
        }
    }
}