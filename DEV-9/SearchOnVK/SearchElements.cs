using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace SearchOnVK
{
    class SearchElements
    {
        IWebDriver driver = new ChromeDriver();
        public void Info(string login, string password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://vk.com/";
            driver.FindElement(By.XPath("//*[@id='index_email']")).SendKeys(login);
            driver.FindElement(By.XPath("//*[@id='index_pass']")).SendKeys(password + Keys.Enter);
            driver.FindElement(By.XPath("//li[@id='l_msg']")).Click();
            driver.FindElements(By.XPath("//div[@class='nim-dialog--cw']")).First().Click();
            driver.FindElements(By.XPath("//div[@class='im-mess--text wall_module _im_log_body']")).Last().Click();
        }
    }
}