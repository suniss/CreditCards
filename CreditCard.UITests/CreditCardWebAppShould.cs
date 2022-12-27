using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CreditCard.UITests
{
    public class CreditCardWebAppShould
    {
        private const string HomeUrl = "http://localhost:44108/";
        private const string AboutUrl = "http://localhost:44108/Home/About";
        private const string HomeTitle = "Home Page - Credit Cards";
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicatuibPage()
        {
            using (IWebDriver driver = new ChromeDriver()) 
            {
              
                driver.Navigate().GoToUrl(HomeUrl);

                TestHelper.Pause();

                Assert.Equal(HomeTitle, driver.Title);
                Assert.Equal(HomeUrl, driver.Url);
            }

        }
        [Fact]
        [Trait("Category", "Smoke")]
        public void ReloadHomePage()
        {
            using (IWebDriver driver = new ChromeDriver()) 
            {
               
                driver.Navigate().GoToUrl(HomeUrl);
                TestHelper.Pause();
                driver.Navigate().Refresh();

                Assert.Equal(HomeTitle, driver.Title);
                Assert.Equal(HomeUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category","Smoke")]
        public void GetHomePage() 
        { 
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);
                TestHelper.Pause();
                driver.Navigate().GoToUrl(AboutUrl);
                TestHelper.Pause();
                driver.Navigate().Back();
                TestHelper.Pause();

                Assert.Equal(HomeTitle, driver.Title);  
                Assert.Equal(HomeUrl, driver.Url);

                // TODO: assert that page was reloaded
            }
        }
        [Fact]
        [Trait("Category", "Smoke")]
        public void ReloadHomePageOnForward() 
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomeUrl);
                TestHelper.Pause();

                driver.Navigate().GoToUrl(HomeUrl);
                TestHelper.Pause();

                driver.Navigate().Forward();
                TestHelper.Pause(); 

                Assert.Equal(HomeTitle, driver.Title);
                Assert.Equal(HomeUrl, driver.Url);

                //TODO: assert that page was reloaded
            }
        }
            
    }
}
