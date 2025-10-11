using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Input;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class GoogleTest
    {
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        private IWebDriver driver;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method

        [SetUp]
        public void Setup()
        {
            // Involking browser
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys("Selenium");
            driver.FindElement(By.XPath("#//input[@data-ved='0ahUKEwizlOyN0vOPAxWoErkGHSGyLlUQ4dUDCBo']")).Click();
        }

        [Test]
        /*
        public void Openyoutube()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.FindElement(By.XPath("//input[@name='search_query']")).SendKeys("Bhojpuri new song");
            driver.FindElement(By.XPath("//button[@title='Search']")).Click();
            
        }
        */
        

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}
