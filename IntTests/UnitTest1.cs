using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace IntTests
{
    public class Tests
    {
        IWebDriver driver;

        
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver("/home/garanin/newsrvapp/driver/");
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://localhost:5000";
            
            Thread.Sleep(1000);

            IWebElement exampleInputEmail1 = driver.FindElement(By.Id("exampleInputEmail1"));
            exampleInputEmail1.SendKeys("test123@tut.by");

            IWebElement exampleInputPassword1 = driver.FindElement(By.Id("exampleInputPassword1"));
            exampleInputPassword1.SendKeys("Pa$$w0rd");

            IWebElement exampleCheck1 = driver.FindElement(By.Id("exampleCheck1"));
            exampleCheck1.Click();
            
            Thread.Sleep(3000);

        }

        [TearDown]
        public void closeBrowser() {
            driver.Close();
        }
    }
}