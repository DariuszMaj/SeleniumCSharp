using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp
{
    [TestFixture]
    class SeleniumCSharp104
    {
       [Test]
       [Author("Dariusz Maj","somexample@mail.com")]
       [Description("Facebook login verify")]
       [TestCaseSource("DataDrivenTesting")]
       public void Test1(String urlName)
        {
            IWebDriver driver=null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile(@"DisaredPath", ScreenshotImageFormat.Png);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
            }
            
        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com");
            //list.Add("https://www.youtube.com");
            //list.Add("https://www.gmail.com");

            return list;
        }

        //[Test]
        //[Author("Dariusz Maj", "somexample@mail.com")]
        //[Description("Facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com";
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}
    }
}
