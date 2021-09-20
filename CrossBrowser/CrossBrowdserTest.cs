/* Project = Cross Browser Testing
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CrossBrowser
{
    //To run specified browser
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(FirefoxDriver))]
    [Parallelizable]

    public class Login <Multi> where Multi : IWebDriver, new()
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()

        {
            driver = new Multi();
        }
        //Test Face login page
        [Test]
        public void LoginPage()
        {
           // driver = new Multi();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("email")).SendKeys("9384613347");
            driver.FindElement(By.Id("pass")).SendKeys("test@123");
            driver.FindElement(By.Name("login")).Click();


        }
        [TearDown]
        //Close Browser
        public void CloseBrowser()
        {
            driver.Quit();

        }
    }

}
