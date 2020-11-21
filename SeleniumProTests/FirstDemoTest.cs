using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumProTests
{
    class FirstDemoTest
    { 

        #region Test

    IWebDriver driver;

    [Test]
        public void Test()
        {
            driver = new ChromeDriver(@"C:\Workspace\SeleniumProTests\SeleniumProTests\chromeDriver");
            driver.Url = "http://www.opreaweb.com";
            driver.FindElement(By.XPath("/html//div[@id='root']//nav//ul[@class='ml-auto navbar-nav']/li[2]/button[@type='button']") ).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']//nav//ul[@class='ml-auto navbar-nav']/li[3]/button[@type='button']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']//nav//ul[@class='ml-auto navbar-nav']/li[1]/button[@type='button']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']/div[@class='App']//ul[@class='list-group']/li/button[3]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']/div[@class='App']/div[2]/div[@class='container']/div/div[@class='container']/ul[@class='list-group']/li/button[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']/div[@class='App']/div[2]/div[@class='container']/div/div[2]/div[@class='container']/div/button[@type='button']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//input[@id='item']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//input[@id='item']")).SendKeys("Selenium Test");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]//div[@role='dialog']/div[@role='document']//form//button[.='AddIt']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']/div[@class='App']/div[2]/div[@class='container']/div/div[@class='container']/ul[@class='list-group']/li/button[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']/div[@class='App']//ul[@class='list-group']/li/button[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']/div[@class='App']/div[2]/div[@class='container']/div/div[2]/div[@class='container']/ul[@class='list-group']/div/li[1]/button[@type='button']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html//div[@id='root']/div[@class='App']//ul[@class='list-group']//a[@href='https://github.com/opreararesstefan/Recongnize_Text_Console']")).Click();
            Thread.Sleep(4000);
            driver.Quit();
        }

        #endregion

    }
}