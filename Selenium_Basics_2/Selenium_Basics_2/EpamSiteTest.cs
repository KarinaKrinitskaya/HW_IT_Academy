namespace Selenium_Basics_2;

public class EpamSiteTest
{
    private IWebDriver driver;
    private const string urlMain = "https://www.epam.com/";

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(urlMain);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        Thread.Sleep(10000);
        driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']")).Click();
    }

    [Test]
    public void CheckListAvailableCountries()
    {
        List<string> webElemList = new List<string>() { "AMERICAS", "EMEA", "APAC" };
        driver.FindElement(By.XPath("//*[@href='/careers']")).Click();
        var actualCountriesList = driver.FindElements(By.XPath("//*[@class='tabs__title' and contains(@role,'presentation')]")).Select(item => item.Text);

        Assert.That(actualCountriesList, Is.EqualTo(webElemList), "List of countries doesn't have: Americas, EMEA, APAC");
    }

    [Test]
    public void CheckSearchInputAutomation()
    {
        string urlSearch = "https://www.epam.com/search?q=Automation";

        driver.FindElement(By.XPath("//*[@class='header-search-ui header__control']")).Click();
        driver.FindElement(By.Id("new_form_search")).SendKeys("Automation");
        driver.FindElement(By.XPath("//form[@action='/search']/child::button[@class='header-search__submit']")).Click();

        Assert.That(driver.Url, Is.EqualTo(urlSearch), "Search doesn't work!");
        bool isContains = driver.PageSource.Contains("Automation");

        Assert.IsTrue(isContains,"Text was not found");
    }

    [Test]
    public void CheckSearchInputBusinessAnalysis()
    {
        string urlSearch = "https://www.epam.com/search?q=Business+Analysis";

        driver.FindElement(By.XPath("//*[@class='header-search-ui header__control']")).Click();
        driver.FindElement(By.Id("new_form_search")).SendKeys("Business Analysis");
        driver.FindElement(By.XPath("//form[@action='/search']/child::button[@class='header-search__submit']")).Click();

        Assert.That(driver.Url, Is.EqualTo(urlSearch), "Search doesn't work!");
        var expRes = driver.FindElement(By.XPath("//*[@class='search-results__title-link']")).Text;
        driver.FindElement(By.XPath("//*[@class='search-results__title-link']")).Click();
        var actualRes = driver.FindElement(By.XPath("//h1")).Text;

        Assert.That(actualRes, Is.EqualTo(expRes), "The title of the article does not match the title from the search!");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}

//Task 5
//Keyword contains - //*[@class='tabs__title' and contains(@role,'presentation')]
//axis following-sibling/preceding-sibling - //*[@class="button-ui bg-color-white standard"]//following-sibling::span /
//*[@class="top-navigation__item continuum"]//preceding-sibling::a
//axis parent - //*[@class="tabs__link js-tabs-link"]//parent::div

//Site for check:https://www.epam.com/search?q=Business+Analysis
//axis first/last - //article[@class='search-results__item'][1] / //article[@class='search-results__item'][last()]
//axis child - //form[@action='/search']/child::button[@class='header-search__submit']