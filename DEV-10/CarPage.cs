using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_10
{
    class CarPage
    {
        ChromeDriver driver;
        public CarPage(ChromeDriver Driver)
            {
                this.driver = Driver;
            }
        public void SearchModels()
            {
                IWebElement element;
                List<string> brands = new List<string>();
                List<string> amount = new List<string>();
                var cars = driver.FindElements(By.ClassName("brandslist"));
                foreach (var el in cars)
                {
                    element = driver.FindElement(By.XPath("//cpan"));
                    brands.Add(element.Text);
                    element = driver.FindElement(By.XPath("//small"));
                    amount.Add(element.Text);
                }
            int i = 0;
            foreach (string el in brands)
                {
                    Console.WriteLine(el + " " + amount[i]);
                        i++;
            }
        }
    }
}