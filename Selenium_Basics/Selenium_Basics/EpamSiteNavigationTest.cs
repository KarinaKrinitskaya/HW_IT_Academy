namespace Selenium_Basics;

public class EpamSiteNavigationTest
{
    private IWebDriver driver;
    private const string urlMain = "https://www.epam.com/";
    private const string urlHowToDoIt = "https://www.epam.com/how-we-do-it";
    private const string urlWork = "https://www.epam.com/our-work";
    
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void CheckNavigationEpamSite()
    {
        driver.Navigate().GoToUrl(urlMain);
        Assert.That(driver.Url, Is.EqualTo(urlMain), "Incorrect url is present");
    }

    [Test]
    public void CheckBackPreviousPage()
    {
        driver.Navigate().GoToUrl(urlHowToDoIt);
        driver.Navigate().GoToUrl(urlWork);
        driver.Navigate().Refresh();
        driver.Navigate().Back();

        Assert.That(driver.Url, Is.EqualTo(urlHowToDoIt), "Page is not How to do it!");
    }

    //Bonus
    [TestCase("https://www.epam.com/cis", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[3]/a")]
    [TestCase("https://careers.epam-czech.cz/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[4]/a")]
    [TestCase("https://www.epam.de/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[10]/a")]
    [TestCase("https://www.epam.com/careers/epam-japan", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[8]/a")]
    [TestCase("https://careers.epam.ua/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[6]/a")]
    [TestCase("https://careers.epam.cn/", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li/div/nav/ul/li[9]/a")]
    public void LanguageSwitchCheck(string urlLang, string xPath)
    {
        driver.Navigate().GoToUrl(urlMain);
        driver.FindElement(By.ClassName("location-selector__button")).Click();
        Thread.Sleep(4000);
        driver.FindElement(By.XPath(xPath)).Click();
        Thread.Sleep(4000);
        Assert.That(driver.Url, Is.EqualTo(urlLang), "Language has not chenged!");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
