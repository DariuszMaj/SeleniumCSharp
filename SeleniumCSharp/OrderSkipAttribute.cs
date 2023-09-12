using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp
{
    class OrderSkipAttribute
    {
        [Test,Order(0),Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            //Assert.Ignore("Defect 1234");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

    }
}
