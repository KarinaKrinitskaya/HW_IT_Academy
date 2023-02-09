using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ExamITAcadeny;

public class Tests
{
    private IWebDriver driver;
    private const string epamCarrersUrl = "https://www.epam.com/careers";
    private const string trainingUrl = "https://training.by/";
    private WebDriverWait waiter;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(trainingUrl);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.1);

        waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

    }

    [Test]
    public void CheckButtonIsDisplayed()
    {
        driver.Navigate().GoToUrl(epamCarrersUrl);
        var butIsdisplayed = driver.FindElement(By.CssSelector("a[href='https://www.epam.com/support-ukraine']")).Displayed;
        var butIsEnabled = driver.FindElement(By.CssSelector("a[href='https://www.epam.com/support-ukraine']")).Enabled;
        var butActive = false;
        Assert.That(butIsdisplayed && butIsEnabled, Is.True, "Button is not displayed!");
    }

    [TestCase("TRAINING", "a.language-control__item:nth-child(1)")]
    [TestCase("ТРЕНИНГИ", "a.language-control__item:nth-child(2)")]
    [TestCase("ТРЕНІНГИ", "a.language-control__item:nth-child(3)")]
    public void CheckLanguagesSwich(string keyWord, string cssSelector)
    {
        Actions hover = new Actions(driver);

        waiter.Until(driver => driver.FindElement(By.CssSelector("div[class ='menu-control__toggle language-control__toggle ng-binding dropdown-toggle']"))).Click();
        driver.FindElement(By.CssSelector(cssSelector)).Click();
        var actualRes = driver.FindElement(By.CssSelector("h1[class='section-ui__title ng-binding']")).GetAttribute("innerText");
        Assert.That(actualRes, Is.EqualTo(keyWord), "Language not switсhed!");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
