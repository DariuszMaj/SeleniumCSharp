using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumCSharp.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

    }
}
