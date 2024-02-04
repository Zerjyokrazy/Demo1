
using OpenQA.Selenium;

namespace IndeedJobBDD.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;
        public FeatureStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Indeed Home Page")]
        public void GivenIndeedHomePage()
        {
            //driver = new ChromeDriver();
            
        }


        [When(@"Search for Software Tester job post")]
        public void WhenSearchForSoftwareTesterJobpost()
        {
            driver.Url = "https://in.indeed.com/";
            driver.FindElement(By.Id("text-input-what")).Click();
            driver.FindElement(By.Id("text-input-what")).Clear();
            driver.FindElement(By.Id("text-input-what")).SendKeys("software tester");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"related Results Should display")]
        public void ThenRelatedResultsShouldDisplay()
        {
            Thread.Sleep(1000);
            //driver.Quit();
        }
    }
}
