using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharp.BaseClass;
using SeleniumCSharp.Utilities;
using System.Threading;

namespace SeleniumCSharp
{
    [TestFixture]
    public class ParallelTesting : BaseTest
    {
        IWebDriver driver;
        [Test,Category("UAT Testing"),Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement Cookiebtn = Driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            Cookiebtn.Click();
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

    }
}
