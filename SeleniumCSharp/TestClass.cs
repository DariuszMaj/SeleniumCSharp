using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharp.BaseClass;
using System.Threading;

namespace SeleniumCSharp
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement Cookiebtn = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement registerbtn = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
            registerbtn.Click();
            IWebElement monthDropDownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByIndex(1);
            element.SelectByText("mar");
            element.SelectByValue("6");
        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
