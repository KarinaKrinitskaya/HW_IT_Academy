using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium_Test;

public class Tests
{

    private IWebDriver driver;
    private const string urlMain = "https://www.epam.com/";

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(urlMain);
    }

    [Test]
    public void CheckHeader()
    {
        var isDispl = driver.FindElement(By.XPath("//*[@href=\"/careers\"]")).Displayed;
        Assert.IsTrue(isDispl, "Header is not displayed");
    }

    [Test]
    public void ChecklocpagesOpen()
    {
        var action = new Actions(driver);

        var careersMenuElement = driver.FindElement(By.XPath("//*[@href='/careers']"));
        action.MoveToElement(careersMenuElement).Build().Perform();
        var carLink = driver.FindElement(By.XPath("//*[@href='/careers/locations']"));
        carLink.Click();
        Assert.That(driver.Url, Is.EqualTo("https://www.epam.com/careers/locations"), "Page is not opened!");
        bool isDispapplyBut = driver.FindElement(By.XPath("//*[@class='button-ui bg-color-light-blue standard' and contains(@data-gtm-category,'Apply - Careers LP')]")).Displayed;
        Assert.IsTrue(isDispapplyBut, "Button Applay is not displayed");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
