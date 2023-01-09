namespace Selenium_Advanced;

public class EpamSiteNavigationTestAdvanced
{
    private IWebDriver driver;
    private const string urlMain = "https://www.epam.com/";
    private WebDriverWait waiter;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(urlMain);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.1);

        waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
        //waiter.Until(driver => driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']"))).Click();
    }

    [Test]
    public void CheckCareersMenuJoinOurTeam() //using IJavaScriptExecutor here
    {
        string urlJoinOurTeam = "https://www.epam.com/careers/job-listings";
        Actions hover = new Actions(driver);
        IJavaScriptExecutor? js = driver as IJavaScriptExecutor;

        var careersMenuBut = driver.FindElement(By.XPath("//*[@href='/careers']"));
        hover.MoveToElement(careersMenuBut).Build().Perform();
        var joinTeamLink = driver.FindElement(By.XPath("//*[@href='/careers/job-listings']"));
        string javascript = "arguments[0].click()";
        js.ExecuteScript(javascript, joinTeamLink);

        Assert.That(driver.Url, Is.EqualTo(urlJoinOurTeam), "Join our team page is not opened!");
    }

    [Test]
    public void CheckLanguageslist()
    {
        List<string> expectedLanguagesList = new List<string>()
        {
            "Global (English)",
            "Hungary (English)",
            "СНГ (Русский)",
            "Česká Republika (Čeština)",
            "India (English)",
            "Україна (Українська)",
            "Czech Republic (English)",
            "日本 (日本語)",
            "中国 (中文)",
            "DACH (Deutsch)",
            "Polska (Polski)"
        };
        Actions hover = new Actions(driver);

        waiter.Until(driver => driver.FindElement(By.XPath("//*[@class='location-selector__button']"))).Click();
        var actualLanguagesList = waiter.Until(driver => driver.FindElements(By.XPath("//*[@class='location-selector__item']")).Select(item => item.GetAttribute("innerText")));

        Assert.That(actualLanguagesList, Is.EqualTo(expectedLanguagesList), "List of languages does not match the expected!");
    }

    [Test]
    public void Check20Articlesonpage()
    {
        Actions act = new Actions(driver);
        int countArticle = 20;

        waiter.Until(driver => driver.FindElement(By.XPath("//*[@class='header-search-ui header__control']"))).Click();
        waiter.Until(driver => driver.FindElement(By.XPath("//li[@class='frequent-searches__item'][2]"))).Click();
        waiter.Until(driver => driver.FindElement(By.XPath("//form[@action='/search']/child::button[@class='header-search__submit']"))).Click();

        act.ScrollToElement(waiter.Until(driver => driver.FindElement(By.XPath("//article[@class='search-results__item']")))).Build().Perform();
        act.ScrollToElement(driver.FindElement(By.XPath("//*[@class='search-results__footer']"))).Build().Perform();
        var actualCountArticles = waiter.Until(driver=>driver.FindElements(By.XPath("//*[@class='search-results__item']")));

        Assert.That(actualCountArticles, Has.Count.EqualTo(countArticle), "There are not 20 articles on the one page!");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
